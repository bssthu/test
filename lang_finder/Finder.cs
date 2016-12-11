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
        public Finder()
        {
            InitializeComponent();
        }

        private void Finder_Load(object sender, EventArgs e)
        {
            listViewResult.GridLines = true;
            listViewResult.Columns.Add("类型", 80);
            listViewResult.Columns.Add("编号", 160);
            listViewResult.Columns.Add("原文", 400);
        }
    }
}
