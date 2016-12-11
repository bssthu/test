using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lang_finder
{
    class CsvLoader
    {
        private const int MAX_RESULT_NUM = 100;
        private LangLine[] langLines;
        private LangLine overflow = new LangLine(",,,,最多显示前" + MAX_RESULT_NUM + "项结果");

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
        public List<LangLine> Search(string keyword)
        {
            List<LangLine> results = new List<LangLine>();

            foreach (LangLine langLine in langLines)
            {
                if (Match(langLine, keyword))
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
        private bool Match(LangLine langLine, string keyword)
        {
            return langLine.text.Contains(keyword);
        }
    }
}
