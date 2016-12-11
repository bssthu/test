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
        private const int MAX_RESULT_NUM = 100;
        private LangLine[] langLines;
        private LangLine overflow = new LangLine(",,,,'最多显示前" + MAX_RESULT_NUM + "项结果'");

        public CsvLoader(string path)
        {
            string[] lines = File.ReadAllLines(path);
            ParseText(lines);
        }

        // 解析每一行
        private void ParseText(string[] lines)
        {
            List<LangLine> langLineList = new List<LangLine>();
            foreach (string line in lines)
            {
                try
                {
                    langLineList.Add(new LangLine(line));
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.ToString());
                }
            }
            langLines = langLineList.ToArray();
        }

        // 搜索
        public List<LangLine> Search(string keyword, bool useRegex, bool ignoreCase)
        {
            if (useRegex)
            {
                return SearchRegex(keyword, ignoreCase);
            }

            List<LangLine> results = new List<LangLine>();
            foreach (LangLine langLine in langLines)
            {
                // 如果找到就添加
                if (IsMatch(langLine, keyword, ignoreCase))
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
        private List<LangLine> SearchRegex(string pattern, bool ignoreCase)
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
                    if (IsMatch(langLine, keyword, ignoreCase))
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
                if (IsMatchRegex(langLine, r))
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
        private bool IsMatch(LangLine langLine, string keyword, bool ignoreCase)
        {
            string text = langLine.text;
            if (ignoreCase)
            {
                keyword = keyword.ToLower();
                text = text.ToLower();
            }
            
            return text.Contains(keyword);
        }

        // 正则匹配
        private bool IsMatchRegex(LangLine langLine, Regex r)
        {
            Match m = r.Match(langLine.text);
            return m.Success;
        }
    }
}
