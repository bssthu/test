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
        private LangLine[] langLines;

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
    }
}
