using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lang_finder
{
    class CsvLoader
    {
        private const int MAX_RESULT_NUM = 1000;
        private LangLine[] langLines;
        private LangLine overflow = new LangLine(",,,,'最多保留前" + MAX_RESULT_NUM + "项结果'");

        private delegate string GetMatchTextDelegate(LangLine langLine);

        public CsvLoader(string path, string pathZh)
        {
            string[] lines = File.ReadAllLines(path);
            string[] linesZh = File.ReadAllLines(pathZh);
            ParseText(lines, linesZh);
        }

        // 解析每一行
        private void ParseText(string[] lines, string[] linesZh)
        {
            Dictionary<string, LangLine> langLineDict = new Dictionary<string, LangLine>();
            // en
            foreach (string line in lines)
            {
                try
                {
                    LangLine langLine = new LangLine(line);
                    langLineDict.Add(langLine.GetIdWithoutCategory(false), langLine);
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.ToString());
                }
            }
            // zh
            foreach (string lineZh in linesZh)
            {
                try
                {
                    LangLine langLineZh = new LangLine(lineZh);
                    string key = langLineZh.GetIdWithoutCategory(false);
                    langLineDict[key].UpdateTextZh(langLineZh.text);
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.ToString());
                }
            }
            // convert
            langLines = langLineDict.Values.ToArray();
        }

        // 搜索英文
        public List<LangLine> SearchEn(string keyword, bool useRegex, bool ignoreCase)
        {
            return Search((langLine) => langLine.text, useRegex, keyword, ignoreCase);
        }

        // 搜索中文
        public List<LangLine> SearchZh(string keyword, bool useRegex, bool ignoreCase)
        {
            return Search((langLine) => langLine.textZh, useRegex, keyword, ignoreCase);
        }

        // 搜索编号
        public List<LangLine> SearchId(string keyword, bool useRegex, bool ignoreCase)
        {
            return Search((langLine) => langLine.id, useRegex, keyword, ignoreCase);
        }

        // 搜索
        private List<LangLine> Search(GetMatchTextDelegate GetMatchText,
            bool useRegex, string keyword, bool ignoreCase)
        {
            if (useRegex)
            {
                return SearchRegex(GetMatchText, keyword, ignoreCase);
            }

            List<LangLine> results = new List<LangLine>();
            foreach (LangLine langLine in langLines)
            {
                // 如果找到就添加
                if (IsMatch(GetMatchText(langLine), keyword, ignoreCase))
                {
                    results.Add(langLine);
                }
                if (results.Count >= MAX_RESULT_NUM)
                {
                    results.Add(overflow);
                    break;
                }
            }

            return results;
        }

        // 正则搜索
        private List<LangLine> SearchRegex(GetMatchTextDelegate GetMatchText, string pattern, bool ignoreCase)
        {
            RegexOptions option = RegexOptions.Compiled;
            if (ignoreCase)
            {
                option |= RegexOptions.IgnoreCase;
            }
            Regex r = new Regex(pattern, option);

            // 第一遍查找
            // 因为正则查找太慢，所以先大致找一次
            string[] keywords = pattern
                .Trim('$')
                .Trim('^')
                .Split(new string[] { ".*" }, StringSplitOptions.RemoveEmptyEntries);
            List<LangLine> firstPassResults = new List<LangLine>();
            foreach (LangLine langLine in langLines)
            {
                foreach (string keyword in keywords)
                {
                    if (IsMatch(GetMatchText(langLine), keyword, ignoreCase))
                    {
                        firstPassResults.Add(langLine);
                        break;
                    }
                }
            }

            // 第二遍查找
            List<LangLine> results = new List<LangLine>();
            foreach (LangLine langLine in firstPassResults)
            {
                // 如果找到就添加
                if (IsMatchRegex(GetMatchText(langLine), r))
                {
                    results.Add(langLine);
                }
                if (results.Count >= MAX_RESULT_NUM)
                {
                    results.Add(overflow);
                    break;
                }
            }

            return results;
        }

        // 匹配关键字
        private bool IsMatch(String text, string keyword, bool ignoreCase)
        {
            if (ignoreCase)
            {
                keyword = keyword.ToLower();
                text = text.ToLower();
            }

            return text.Contains(keyword);
        }

        // 正则匹配
        private bool IsMatchRegex(string text, Regex r)
        {
            Match m = r.Match(text);
            return m.Success;
        }
    }
}
