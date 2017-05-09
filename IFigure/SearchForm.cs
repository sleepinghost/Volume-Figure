using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Figure
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        public DataGridView Figures { get; set; }

        /// <summary>
        /// Кнопка поиска данных по названию фигуры
        /// </summary>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //MainForm frm = (MainForm)this.Owner;
            //MainForm main = this.Owner as MainForm;
            Figures.ClearSelection();


            for (int i = 0; i < Figures.Rows.Count; i++)
                {
                    Figures.Rows[i].Visible = false;
                    if (Figures[0, i].Value.ToString() == textBoxSearch.Text)
                    {
                        Figures.Rows[i].Visible = true;
                        Figures.Rows[i].DefaultCellStyle.BackColor = Color.DeepSkyBlue;
                    }
                }

        }
    }
}
