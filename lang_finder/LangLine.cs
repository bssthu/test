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
        public string textZh { get; private set; }

        // 类别名字（中文）
        public string categoryName { get; private set; }
        // 用于显示的 ID
        public string id { get; private set; }

        public LangLine(string line)
        {
            string[] words = line.Trim().Split(new char[] { ',' }, 5);
            fileid = words[0].Trim('"');
            unknown = words[1].Trim('"');
            index = words[2].Trim('"');
            text = words[4].Substring(1, words[4].Length - 2);
            textZh = text;

            categoryName = LangDef.instance.GetCategoryName(fileid);
            if (fileid == "UI")
            {
                id = index;
            }
            else
            {
                id = LangDef.instance.GetCategory(fileid) + '-'
                    + GetIdWithoutCategory(LangDef.instance.IsPair(fileid));
            }
        }

        // 更新中文文本
        public void UpdateTextZh(string textZh)
        {
            this.textZh = textZh;
        }

        public string GetIdWithoutCategory(bool isPair)
        {
            string fileidP = fileid;
            string unknownP = unknown;
            string indexP = index;
            try
            {
                if (fileidP != "" && fileid != "UI")
                {
                    // 补前导0
                    fileidP = Convert.ToUInt32(fileidP).ToString("D9");
                    unknownP = Convert.ToUInt32(unknownP).ToString("D2");
                    indexP = Convert.ToUInt32(indexP).ToString("D5");
                }
            }
            catch (Exception) { }
            if (isPair)
            {
                return indexP;
            }
            else
            {
                return fileidP + '-' + unknownP + '-' + indexP;
            }
        }
    }
}
