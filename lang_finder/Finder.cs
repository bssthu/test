using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lang_finder
{
    public partial class Finder : Form
    {
        private CsvLoader csvLoader;
        private LangDef langDef;

        private delegate void UnlockUiDelegate();
        private UnlockUiDelegate unlockUi;

        private delegate void ShowSearchResultDelegate(List<LangLine> results);
        private ShowSearchResultDelegate showSearchResult;

        public Finder()
        {
            InitializeComponent();
            langDef = new LangDef();

            AcceptButton = buttonSearch;
            unlockUi = () => buttonSearch.Enabled = true;
            showSearchResult = (results) => ShowSearchResult(results);
            // 异步加载原文数据
            Task.Run(new Action(LoadCsv));
        }

        private void Finder_Load(object sender, EventArgs e)
        {
            // 初始化 GridView
            InitResultView();
        }

        // 初始化 ListView
        private void InitResultView()
        {
            dataGridViewResult.Columns.Add("categoryName", "类型");
            dataGridViewResult.Columns.Add("id", "编号");
            dataGridViewResult.Columns.Add("text", "原文");
            dataGridViewResult.Columns[0].Width = 80;
            dataGridViewResult.Columns[1].Width = 160;
            dataGridViewResult.Columns[2].Width = 400;
        }

        // 从文件加载原文数据
        private void LoadCsv()
        {
            try
            {
                csvLoader = new CsvLoader("./en.lang.csv");
                Invoke(unlockUi);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        // 搜索
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewResult.Rows.Clear();
            // 异步搜索
            Task.Run(new Action(Search));
        }

        // 异步搜索
        private void Search()
        {
            List<LangLine> results = csvLoader.Search(textBoxKeyword.Text,
                checkBoxRegex.Checked, checkBoxIgnoreCase.Checked);
            Invoke(showSearchResult, new object[] { results });
        }

        // 异步显示搜索结果
        private void ShowSearchResult(List<LangLine> results)
        {
            foreach (LangLine langLine in results)
            {
                AddLangLineResult(langLine);
            }
            if (results.Count <= 0)
            {
                AddLangLineResult(new LangLine(",,,,'未找到结果'"));
            }
        }

        // 添加一项
        private void AddLangLineResult(LangLine langLine)
        {
            string categoryName = langDef.GetCategoryName(langLine.fileid);
            string id = langDef.GetCategory(langLine.fileid) + '-' + langLine.id;
            string text = langLine.text;
            dataGridViewResult.Rows.Add(categoryName, id, text);
        }
    }
}
