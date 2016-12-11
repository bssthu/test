using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lang_finder
{
    class LangLine
    {
        public string fileid { get; private set; }
        public string unknown { get; private set; }
        public string index { get; private set; }
        public string text { get; private set; }

        public LangLine(string line)
        {
            string[] words = line.Trim().Split(new char[] { ',' }, 5);
            fileid = words[0];
            unknown = words[1];
            index = words[2];
            text = words[4];
        }
    }
}
