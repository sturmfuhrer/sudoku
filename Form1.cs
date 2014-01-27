using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MaindataGridView.ColumnCount = 9;
            MaindataGridView.RowCount = 9;
            for (int i = 0; i < 9; i++)
            {
                MaindataGridView.Rows[i].Height = 35;
                MaindataGridView.Columns[i].Width = 35;
            }
            MaindataGridView.Columns[2].DividerWidth = 3;
            MaindataGridView.Columns[5].DividerWidth = 3;
            MaindataGridView.Rows[2].DividerHeight = 3;
            MaindataGridView.Rows[5].DividerHeight = 3;
        }

    }
}
