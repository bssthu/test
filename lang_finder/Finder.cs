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

        private delegate void UnlockUiDelegate();
        private UnlockUiDelegate unlockUi;

        public Finder()
        {
            InitializeComponent();
            unlockUi = () => buttonSearch.Enabled = true;
            // 异步加载原文数据
            Task.Run(new Action(LoadCsv));
        }

        private void Finder_Load(object sender, EventArgs e)
        {
            // 初始化 ListView
            InitListView();
        }

        // 初始化 ListView
        private void InitListView()
        {
            listViewResult.GridLines = true;
            listViewResult.Columns.Add("类型", 80);
            listViewResult.Columns.Add("编号", 160);
            listViewResult.Columns.Add("原文", 400);
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
            listViewResult.Clear();
            InitListView();
            List<LangLine> results = csvLoader.Search(textBoxKeyword.Text);
            foreach (LangLine langLine in results)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = "未知";
                item.SubItems.Add(langLine.id);
                item.SubItems.Add(langLine.text);
                listViewResult.Items.Add(item);
            }
        }
    }
}
