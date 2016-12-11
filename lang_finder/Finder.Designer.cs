namespace lang_finder
{
    partial class Finder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finder));
            this.textBoxKeyword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.checkBoxRegex = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewResult = new System.Windows.Forms.ListView();
            this.checkBoxCase = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxKeyword
            // 
            this.textBoxKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKeyword.Location = new System.Drawing.Point(47, 12);
            this.textBoxKeyword.Name = "textBoxKeyword";
            this.textBoxKeyword.Size = new System.Drawing.Size(441, 21);
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
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Enabled = false;
            this.buttonSearch.Location = new System.Drawing.Point(494, 10);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "搜索";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
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
            this.label2.Size = new System.Drawing.Size(413, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "模糊匹配，例如\".*\"表示任意（不含引号），\"^\"表示文本开始，\"$\"表示结束";
            // 
            // listViewResult
            // 
            this.listViewResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewResult.Location = new System.Drawing.Point(14, 83);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(555, 389);
            this.listViewResult.TabIndex = 5;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            this.listViewResult.View = System.Windows.Forms.View.Details;
            // 
            // checkBoxCase
            // 
            this.checkBoxCase.AutoSize = true;
            this.checkBoxCase.Location = new System.Drawing.Point(14, 61);
            this.checkBoxCase.Name = "checkBoxCase";
            this.checkBoxCase.Size = new System.Drawing.Size(84, 16);
            this.checkBoxCase.TabIndex = 6;
            this.checkBoxCase.Text = "区分大小写";
            this.checkBoxCase.UseVisualStyleBackColor = true;
            // 
            // Finder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 484);
            this.Controls.Add(this.checkBoxCase);
            this.Controls.Add(this.listViewResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxRegex);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKeyword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Finder";
            this.Text = "ESO 文本搜索";
            this.Load += new System.EventHandler(this.Finder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKeyword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.CheckBox checkBoxRegex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewResult;
        private System.Windows.Forms.CheckBox checkBoxCase;
    }
}

