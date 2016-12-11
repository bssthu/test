using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lang_finder
{
    class LangDef
    {
        private Dictionary<string, string> fileidToCategory;
        private Dictionary<string, string> categoryToName;

        public LangDef()
        {
            InitCategoryToName();
            InitFileidToCategory();
        }

        // 英文类型名
        public string GetCategory(string fileid)
        {
            if (fileidToCategory.ContainsKey(fileid))
            {
                string category = fileidToCategory[fileid];
                return category;
            }
            return "";
        }

        // 中文类型名
        public string GetCategoryName(string fileid)
        {
            string category = GetCategory(fileid);
            if (categoryToName.ContainsKey(category))
            {
                return categoryToName[category];
            }
            return "";
        }

        private void InitCategoryToName()
        {
            categoryToName = new Dictionary<string, string>();

            categoryToName.Add("book", "书信");
            categoryToName.Add("crown", "皇冠商店");
            categoryToName.Add("item", "物品");
            categoryToName.Add("journey", "任务日志");
            categoryToName.Add("loadscreen", "载入画面");
            categoryToName.Add("merchant-talk", "商人等对话");
            categoryToName.Add("mount", "坐骑宠物服装等");
            categoryToName.Add("questitem", "任务物品");
            categoryToName.Add("skill", "技能");
            categoryToName.Add("three-alliance", "三阵营描述");
            categoryToName.Add("chat", "聊天");
            categoryToName.Add("country-or-region", "国家地区");
            categoryToName.Add("greeting", "NPC打招呼");
            categoryToName.Add("interact-action", "交互动作");
            categoryToName.Add("interact-win", "按E的非任务对话");
            categoryToName.Add("item-type", "物品修饰");
            categoryToName.Add("letter", "letter");
            categoryToName.Add("location-and-object", "可交互物和地名");
            categoryToName.Add("more-desc", "其他描述");
            categoryToName.Add("more-ui", "其他界面相关");
            categoryToName.Add("npc-name", "人名怪名");
            categoryToName.Add("quest-end", "任务结束");
            categoryToName.Add("quest-talk-long", "任务长对话");
            categoryToName.Add("set", "套装名");
            categoryToName.Add("tip", "提示帮助");
            categoryToName.Add("title", "人物称谓");
            categoryToName.Add("trap", "陷阱");
            categoryToName.Add("treasure-map", "藏宝图");
            categoryToName.Add("achievement", "成就");
            categoryToName.Add("location-object", "地点及目标");
            categoryToName.Add("quest-obj", "任务目标");
            categoryToName.Add("quest-talk-short", "任务短对话");
        }

        private void InitFileidToCategory()
        {
            fileidToCategory = new Dictionary<string, string>();

            fileidToCategory.Add("51188213", "book");
            fileidToCategory.Add("21337012", "book");
            fileidToCategory.Add("70328405", "crown");
            fileidToCategory.Add("263796174", "crown");
            fileidToCategory.Add("242841733", "item");
            fileidToCategory.Add("228378404", "item");
            fileidToCategory.Add("52420949", "journey");
            fileidToCategory.Add("265851556", "journey");
            fileidToCategory.Add("162658389", "loadscreen");
            fileidToCategory.Add("70901198", "loadscreen");
            fileidToCategory.Add("8290981", "merchant-talk");
            fileidToCategory.Add("165399380", "merchant-talk");
            fileidToCategory.Add("18173141", "mount");
            fileidToCategory.Add("211640654", "mount");
            fileidToCategory.Add("267697733", "questitem");
            fileidToCategory.Add("139139780", "questitem");
            fileidToCategory.Add("198758357", "skill");
            fileidToCategory.Add("132143172", "skill");
            fileidToCategory.Add("116704773", "three-alliance");
            fileidToCategory.Add("235463860", "three-alliance");
            fileidToCategory.Add("78205445", "chat");
            fileidToCategory.Add("121778053", "chat");
            fileidToCategory.Add("152988005", "country-or-region");
            fileidToCategory.Add("75236676", "greeting");
            fileidToCategory.Add("75237444", "greeting");
            fileidToCategory.Add("75238212", "greeting");
            fileidToCategory.Add("75240772", "greeting");
            fileidToCategory.Add("75241540", "greeting");
            fileidToCategory.Add("75242308", "greeting");
            fileidToCategory.Add("75244868", "greeting");
            fileidToCategory.Add("75245636", "greeting");
            fileidToCategory.Add("75246404", "greeting");
            fileidToCategory.Add("75248964", "greeting");
            fileidToCategory.Add("75249732", "greeting");
            fileidToCategory.Add("75250500", "greeting");
            fileidToCategory.Add("75253060", "greeting");
            fileidToCategory.Add("75253828", "greeting");
            fileidToCategory.Add("75254596", "greeting");
            fileidToCategory.Add("75257156", "greeting");
            fileidToCategory.Add("75257924", "greeting");
            fileidToCategory.Add("75258692", "greeting");
            fileidToCategory.Add("75261252", "greeting");
            fileidToCategory.Add("75262020", "greeting");
            fileidToCategory.Add("75262788", "greeting");
            fileidToCategory.Add("75265348", "greeting");
            fileidToCategory.Add("75266116", "greeting");
            fileidToCategory.Add("75266884", "greeting");
            fileidToCategory.Add("149979604", "greeting");
            fileidToCategory.Add("149983700", "greeting");
            fileidToCategory.Add("149987796", "greeting");
            fileidToCategory.Add("149991892", "greeting");
            fileidToCategory.Add("149995988", "greeting");
            fileidToCategory.Add("150000084", "greeting");
            fileidToCategory.Add("150004180", "greeting");
            fileidToCategory.Add("150008276", "greeting");
            fileidToCategory.Add("150045140", "greeting");
            fileidToCategory.Add("150049236", "greeting");
            fileidToCategory.Add("150053332", "greeting");
            fileidToCategory.Add("150057428", "greeting");
            fileidToCategory.Add("150061524", "greeting");
            fileidToCategory.Add("150065620", "greeting");
            fileidToCategory.Add("150069716", "greeting");
            fileidToCategory.Add("150073812", "greeting");
            fileidToCategory.Add("150525940", "greeting");
            fileidToCategory.Add("150962644", "greeting");
            fileidToCategory.Add("150966740", "greeting");
            fileidToCategory.Add("150970836", "greeting");
            fileidToCategory.Add("150974932", "greeting");
            fileidToCategory.Add("150979028", "greeting");
            fileidToCategory.Add("150983124", "greeting");
            fileidToCategory.Add("150987220", "greeting");
            fileidToCategory.Add("150991316", "greeting");
            fileidToCategory.Add("3427285", "interact-action");
            fileidToCategory.Add("6658117", "interact-action");
            fileidToCategory.Add("8158238", "interact-action");
            fileidToCategory.Add("12320021", "interact-action");
            fileidToCategory.Add("12912341", "interact-action");
            fileidToCategory.Add("34717246", "interact-action");
            fileidToCategory.Add("45275092", "interact-action");
            fileidToCategory.Add("45608037", "interact-action");
            fileidToCategory.Add("70307621", "interact-action");
            fileidToCategory.Add("74865733", "interact-action");
            fileidToCategory.Add("84555781", "interact-action");
            fileidToCategory.Add("108533454", "interact-action");
            fileidToCategory.Add("139475237", "interact-action");
            fileidToCategory.Add("219689294", "interact-action");
            fileidToCategory.Add("263004526", "interact-action");
            fileidToCategory.Add("149328292", "interact-win");
            fileidToCategory.Add("33378341", "item-type");
            fileidToCategory.Add("41262789", "item-type");
            fileidToCategory.Add("52856117", "item-type");
            fileidToCategory.Add("59621621", "item-type");
            fileidToCategory.Add("68494373", "item-type");
            fileidToCategory.Add("124119973", "item-type");
            fileidToCategory.Add("217370677", "item-type");
            fileidToCategory.Add("219317028", "letter");
            fileidToCategory.Add("142250453", "location-and-object");
            fileidToCategory.Add("146361138", "location-and-object");
            fileidToCategory.Add("157886597", "location-and-object");
            fileidToCategory.Add("162946485", "location-and-object");
            fileidToCategory.Add("164009093", "location-and-object");
            fileidToCategory.Add("19398485", "location-and-object");
            fileidToCategory.Add("211899940", "location-and-object");
            fileidToCategory.Add("247934532", "location-and-object");
            fileidToCategory.Add("260523861", "location-and-object");
            fileidToCategory.Add("267200725", "location-and-object");
            fileidToCategory.Add("268015829", "location-and-object");
            fileidToCategory.Add("28666901", "location-and-object");
            fileidToCategory.Add("39619172", "location-and-object");
            fileidToCategory.Add("57008677", "location-and-object");
            fileidToCategory.Add("76200101", "location-and-object");
            fileidToCategory.Add("77659573", "location-and-object");
            fileidToCategory.Add("81344020", "location-and-object");
            fileidToCategory.Add("87370069", "location-and-object");
            fileidToCategory.Add("8379076", "more-desc");
            fileidToCategory.Add("50040644", "more-desc");
            fileidToCategory.Add("52183620", "more-desc");
            fileidToCategory.Add("127454222", "more-desc");
            fileidToCategory.Add("151931684", "more-desc");
            fileidToCategory.Add("164317956", "more-desc");
            fileidToCategory.Add("171157587", "more-desc");
            fileidToCategory.Add("191189508", "more-desc");
            fileidToCategory.Add("206046340", "more-desc");
            fileidToCategory.Add("224875171", "more-desc");
            fileidToCategory.Add("5759525", "more-ui");
            fileidToCategory.Add("17915077", "more-ui");
            fileidToCategory.Add("37408565", "more-ui");
            fileidToCategory.Add("51109077", "more-ui");
            fileidToCategory.Add("65447205", "more-ui");
            fileidToCategory.Add("68561141", "more-ui");
            fileidToCategory.Add("79246725", "more-ui");
            fileidToCategory.Add("92356820", "more-ui");
            fileidToCategory.Add("96962005", "more-ui");
            fileidToCategory.Add("99527054", "more-ui");
            fileidToCategory.Add("101034709", "more-ui");
            fileidToCategory.Add("106474997", "more-ui");
            fileidToCategory.Add("108643301", "more-ui");
            fileidToCategory.Add("111863941", "more-ui");
            fileidToCategory.Add("112758405", "more-ui");
            fileidToCategory.Add("115337253", "more-ui");
            fileidToCategory.Add("119308740", "more-ui");
            fileidToCategory.Add("121402798", "more-ui");
            fileidToCategory.Add("124318053", "more-ui");
            fileidToCategory.Add("131421317", "more-ui");
            fileidToCategory.Add("143563989", "more-ui");
            fileidToCategory.Add("143811061", "more-ui");
            fileidToCategory.Add("148355781", "more-ui");
            fileidToCategory.Add("156152165", "more-ui");
            fileidToCategory.Add("173340693", "more-ui");
            fileidToCategory.Add("191379205", "more-ui");
            fileidToCategory.Add("196014052", "more-ui");
            fileidToCategory.Add("200521140", "more-ui");
            fileidToCategory.Add("203274254", "more-ui");
            fileidToCategory.Add("204530069", "more-ui");
            fileidToCategory.Add("207758933", "more-ui");
            fileidToCategory.Add("210579221", "more-ui");
            fileidToCategory.Add("216055893", "more-ui");
            fileidToCategory.Add("219429541", "more-ui");
            fileidToCategory.Add("224768149", "more-ui");
            fileidToCategory.Add("224972965", "more-ui");
            fileidToCategory.Add("236931909", "more-ui");
            fileidToCategory.Add("245765621", "more-ui");
            fileidToCategory.Add("257983733", "more-ui");
            fileidToCategory.Add("33425332", "npc-name");
            fileidToCategory.Add("51188660", "npc-name");
            fileidToCategory.Add("191999749", "npc-name");
            fileidToCategory.Add("207398837", "npc-name");
            fileidToCategory.Add("116521668", "quest-end");
            fileidToCategory.Add("168415844", "quest-end");
            fileidToCategory.Add("3952276", "quest-talk-long");
            fileidToCategory.Add("55049764", "quest-talk-long");
            fileidToCategory.Add("200879108", "quest-talk-long");
            fileidToCategory.Add("103224356", "quest-talk-long");
            fileidToCategory.Add("115740052", "quest-talk-long");
            fileidToCategory.Add("187173764", "quest-talk-long");
            fileidToCategory.Add("121487972", "quest-talk-long");
            fileidToCategory.Add("204987124", "quest-talk-long");
            fileidToCategory.Add("228103012", "quest-talk-long");
            fileidToCategory.Add("232026500", "quest-talk-long");
            fileidToCategory.Add("249936564", "quest-talk-long");
            fileidToCategory.Add("256430276", "quest-talk-long");
            fileidToCategory.Add("38727365", "set");
            fileidToCategory.Add("4922190", "tip");
            fileidToCategory.Add("13753646", "tip");
            fileidToCategory.Add("18104308", "tip");
            fileidToCategory.Add("25948373", "tip");
            fileidToCategory.Add("37288388", "tip");
            fileidToCategory.Add("41714900", "tip");
            fileidToCategory.Add("49496084", "tip");
            fileidToCategory.Add("50143374", "tip");
            fileidToCategory.Add("58548677", "tip");
            fileidToCategory.Add("62156964", "tip");
            fileidToCategory.Add("69169806", "tip");
            fileidToCategory.Add("74148292", "tip");
            fileidToCategory.Add("81761156", "tip");
            fileidToCategory.Add("84281828", "tip");
            fileidToCategory.Add("86601028", "tip");
            fileidToCategory.Add("86917166", "tip");
            fileidToCategory.Add("117539474", "tip");
            fileidToCategory.Add("123557796", "tip");
            fileidToCategory.Add("130851621", "tip");
            fileidToCategory.Add("144446238", "tip");
            fileidToCategory.Add("145410824", "tip");
            fileidToCategory.Add("148453652", "tip");
            fileidToCategory.Add("154416852", "tip");
            fileidToCategory.Add("155022052", "tip");
            fileidToCategory.Add("156570558", "tip");
            fileidToCategory.Add("156664686", "tip");
            fileidToCategory.Add("159929300", "tip");
            fileidToCategory.Add("160227428", "tip");
            fileidToCategory.Add("164328533", "tip");
            fileidToCategory.Add("164387044", "tip");
            fileidToCategory.Add("168351172", "tip");
            fileidToCategory.Add("168857941", "tip");
            fileidToCategory.Add("185724645", "tip");
            fileidToCategory.Add("193511764", "tip");
            fileidToCategory.Add("193678788", "tip");
            fileidToCategory.Add("213229525", "tip");
            fileidToCategory.Add("220262196", "tip");
            fileidToCategory.Add("221172404", "tip");
            fileidToCategory.Add("229654260", "tip");
            fileidToCategory.Add("230486948", "tip");
            fileidToCategory.Add("235850260", "tip");
            fileidToCategory.Add("243094948", "tip");
            fileidToCategory.Add("246790420", "tip");
            fileidToCategory.Add("252100948", "tip");
            fileidToCategory.Add("252855860", "tip");
            fileidToCategory.Add("254784612", "tip");
            fileidToCategory.Add("256705124", "tip");
            fileidToCategory.Add("259956452", "tip");
            fileidToCategory.Add("266730334", "tip");
            fileidToCategory.Add("22296053", "title");
            fileidToCategory.Add("60155541", "title");
            fileidToCategory.Add("63563637", "title");
            fileidToCategory.Add("87522148", "title");
            fileidToCategory.Add("143348165", "title");
            fileidToCategory.Add("186232436", "title");
            fileidToCategory.Add("215700677", "title");
            fileidToCategory.Add("221887989", "title");
            fileidToCategory.Add("14464837", "trap");
            fileidToCategory.Add("39160885", "treasure-map");
            fileidToCategory.Add("12529189", "achievement");
            fileidToCategory.Add("188155806", "achievement");
            fileidToCategory.Add("172030117", "achievement");
            fileidToCategory.Add("10860933", "location-object");
            fileidToCategory.Add("129979412", "location-object");
            fileidToCategory.Add("108566804", "location-object");
            fileidToCategory.Add("7949764", "quest-obj");
            fileidToCategory.Add("234743124", "quest-obj");
            fileidToCategory.Add("144228340", "quest-obj");
            fileidToCategory.Add("66848564", "quest-talk-short");
            fileidToCategory.Add("20958740", "quest-talk-short");
            fileidToCategory.Add("205344756", "quest-talk-short");
        }
    }
}
