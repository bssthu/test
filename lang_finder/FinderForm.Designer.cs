namespace lang_finder
{
    partial class FinderForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinderForm));
            this.textBoxKeyword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearchEn = new System.Windows.Forms.Button();
            this.checkBoxRegex = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxIgnoreCase = new System.Windows.Forms.CheckBox();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.buttonSearchZh = new System.Windows.Forms.Button();
            this.buttonSearchId = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxKeyword
            // 
            this.textBoxKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKeyword.Location = new System.Drawing.Point(47, 12);
            this.textBoxKeyword.Name = "textBoxKeyword";
            this.textBoxKeyword.Size = new System.Drawing.Size(450, 21);
            this.textBoxKeyword.TabIndex = 0;
            this.textBoxKeyword.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "原文";
            // 
            // buttonSearchEn
            // 
            this.buttonSearchEn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchEn.Enabled = false;
            this.buttonSearchEn.Location = new System.Drawing.Point(503, 10);
            this.buttonSearchEn.Name = "buttonSearchEn";
            this.buttonSearchEn.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchEn.TabIndex = 2;
            this.buttonSearchEn.Text = "搜英文(&E)";
            this.buttonSearchEn.UseVisualStyleBackColor = true;
            this.buttonSearchEn.Click += new System.EventHandler(this.buttonSearchEn_Click);
            // 
            // checkBoxRegex
            // 
            this.checkBoxRegex.AutoSize = true;
            this.checkBoxRegex.Location = new System.Drawing.Point(14, 39);
            this.checkBoxRegex.Name = "checkBoxRegex";
            this.checkBoxRegex.Size = new System.Drawing.Size(84, 16);
            this.checkBoxRegex.TabIndex = 3;
            this.checkBoxRegex.Text = "正则表达式";
            this.checkBoxRegex.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(105, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "模糊匹配，暂只支持\".*\"表示任意（不含引号），\"^\"表示文本开始，\"$\"表示结束";
            // 
            // checkBoxIgnoreCase
            // 
            this.checkBoxIgnoreCase.AutoSize = true;
            this.checkBoxIgnoreCase.Location = new System.Drawing.Point(14, 61);
            this.checkBoxIgnoreCase.Name = "checkBoxIgnoreCase";
            this.checkBoxIgnoreCase.Size = new System.Drawing.Size(84, 16);
            this.checkBoxIgnoreCase.TabIndex = 6;
            this.checkBoxIgnoreCase.Text = "忽略大小写";
            this.checkBoxIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResult.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Location = new System.Drawing.Point(14, 84);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.ReadOnly = true;
            this.dataGridViewResult.RowTemplate.Height = 23;
            this.dataGridViewResult.Size = new System.Drawing.Size(726, 465);
            this.dataGridViewResult.TabIndex = 7;
            this.dataGridViewResult.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewResult_CellBeginEdit);
            this.dataGridViewResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResult_CellDoubleClick);
            this.dataGridViewResult.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResult_CellEndEdit);
            // 
            // buttonSearchZh
            // 
            this.buttonSearchZh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchZh.Enabled = false;
            this.buttonSearchZh.Location = new System.Drawing.Point(584, 10);
            this.buttonSearchZh.Name = "buttonSearchZh";
            this.buttonSearchZh.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchZh.TabIndex = 2;
            this.buttonSearchZh.Text = "搜中文(&C)";
            this.buttonSearchZh.UseVisualStyleBackColor = true;
            this.buttonSearchZh.Click += new System.EventHandler(this.buttonSearchZh_Click);
            // 
            // buttonSearchId
            // 
            this.buttonSearchId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchId.Enabled = false;
            this.buttonSearchId.Location = new System.Drawing.Point(665, 10);
            this.buttonSearchId.Name = "buttonSearchId";
            this.buttonSearchId.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchId.TabIndex = 2;
            this.buttonSearchId.Text = "搜编号(&I)";
            this.buttonSearchId.UseVisualStyleBackColor = true;
            this.buttonSearchId.Click += new System.EventHandler(this.buttonSearchId_Click);
            // 
            // FinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 561);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.checkBoxIgnoreCase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxRegex);
            this.Controls.Add(this.buttonSearchId);
            this.Controls.Add(this.buttonSearchZh);
            this.Controls.Add(this.buttonSearchEn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKeyword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FinderForm";
            this.Text = "ESO 文本搜索";
            this.Load += new System.EventHandler(this.Finder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKeyword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearchEn;
        private System.Windows.Forms.CheckBox checkBoxRegex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxIgnoreCase;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Button buttonSearchZh;
        private System.Windows.Forms.Button buttonSearchId;
    }
}

