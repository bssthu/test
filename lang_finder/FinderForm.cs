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
    public partial class FinderForm : Form
    {
        private CsvLoader csvLoader;

        private delegate void UnlockUiDelegate();
        private UnlockUiDelegate unlockUi;

        private delegate void ShowSearchResultDelegate(List<LangLine> results);
        private ShowSearchResultDelegate showSearchResult;

        private String currentCellValue = "";

        public FinderForm()
        {
            InitializeComponent();
            LangDef.Initialize();

            checkBoxRegex.Checked = Properties.Settings.Default.useRegex;
            checkBoxIgnoreCase.Checked = Properties.Settings.Default.ignoreCase;
            checkBoxAutoSizeRows.Checked = Properties.Settings.Default.autoSizeRows;
            AcceptButton = buttonSearchEn;

            unlockUi = () => EnableSearchButtons(true);
            showSearchResult = (results) => ShowSearchResult(results);
            // 异步加载原文数据
            Task.Run(new Action(LoadCsv));
        }

        private void Finder_Load(object sender, EventArgs e)
        {
            // 初始化 GridView
            InitResultView();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            // save settings
            Properties.Settings.Default.useRegex = checkBoxRegex.Checked;
            Properties.Settings.Default.ignoreCase = checkBoxIgnoreCase.Checked;
            Properties.Settings.Default.autoSizeRows = checkBoxAutoSizeRows.Checked;
            Properties.Settings.Default.Save();
            base.OnClosing(e);
        }

        // 初始化 ListView
        private void InitResultView()
        {
            dataGridViewResult.Columns.Add("categoryName", "类型");
            dataGridViewResult.Columns.Add("id", "编号");
            dataGridViewResult.Columns.Add("text", "原文");
            dataGridViewResult.Columns.Add("textZh", "译文");
            dataGridViewResult.Columns[0].Width = 80;
            dataGridViewResult.Columns[1].Width = 160;
            dataGridViewResult.Columns[2].Width = 300;
            dataGridViewResult.Columns[3].Width = 300;
            dataGridViewResult.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewResult.ReadOnly = false;
            dataGridViewResult.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            if (checkBoxAutoSizeRows.Checked)
            {
                dataGridViewResult.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }

        // 从文件加载原文数据
        private void LoadCsv()
        {
            try
            {
                csvLoader = new CsvLoader("./en.lang.csv", "./zh.lang.csv");
                Invoke(unlockUi);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        // 双击进入编辑模式
        private void dataGridViewResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridViewResult.CurrentCell = dataGridViewResult.Rows[e.RowIndex].Cells[e.ColumnIndex];
            dataGridViewResult.BeginEdit(false);
        }

        private void dataGridViewResult_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            currentCellValue = dataGridViewResult.CurrentCell.Value.ToString();
        }

        private void dataGridViewResult_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewResult.CurrentCell.Value = currentCellValue;
        }

        // 搜索英文
        private void buttonSearchEn_Click(object sender, EventArgs e)
        {
            dataGridViewResult.Rows.Clear();
            EnableSearchButtons(false);
            // 异步搜索
            Task.Run(new Action(SearchEn));
        }

        // 搜索中文
        private void buttonSearchZh_Click(object sender, EventArgs e)
        {
            dataGridViewResult.Rows.Clear();
            EnableSearchButtons(false);
            // 异步搜索
            Task.Run(new Action(SearchZh));
        }

        // 搜索编号
        private void buttonSearchId_Click(object sender, EventArgs e)
        {
            dataGridViewResult.Rows.Clear();
            EnableSearchButtons(false);
            // 异步搜索
            Task.Run(new Action(SearchId));
        }

        // 异步搜索英文
        private void SearchEn()
        {
            List<LangLine> results = csvLoader.SearchEn(textBoxKeyword.Text,
                checkBoxRegex.Checked, checkBoxIgnoreCase.Checked);
            Invoke(showSearchResult, new object[] { results });
            Invoke(unlockUi);
        }

        // 异步搜索中文
        private void SearchZh()
        {
            List<LangLine> results = csvLoader.SearchZh(textBoxKeyword.Text,
                checkBoxRegex.Checked, checkBoxIgnoreCase.Checked);
            Invoke(showSearchResult, new object[] { results });
            Invoke(unlockUi);
        }

        // 异步搜索编号
        private void SearchId()
        {
            List<LangLine> results = csvLoader.SearchId(textBoxKeyword.Text,
                checkBoxRegex.Checked, checkBoxIgnoreCase.Checked);
            Invoke(showSearchResult, new object[] { results });
            Invoke(unlockUi);
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
            string categoryName = langLine.categoryName;
            string id = langLine.id;
            string text = langLine.text;
            string textZh = langLine.textZh;
            dataGridViewResult.Rows.Add(categoryName, id, text, textZh);
        }

        // 启用/禁用 搜索 按钮
        private void EnableSearchButtons(bool enable)
        {
            buttonSearchEn.Enabled = enable;
            buttonSearchZh.Enabled = enable;
            buttonSearchId.Enabled = enable;
        }

        // 是否启用自动行高
        private void checkBoxAutoSizeRows_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoSizeRows.Checked)
            {
                dataGridViewResult.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            else
            {
                dataGridViewResult.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            }
        }
    }
}
