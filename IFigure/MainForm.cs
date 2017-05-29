using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;
using Model;

namespace Figure
{
    public partial class MainForm : Form
    {
        public FigureList _listing = new FigureList();


        public MainForm()
        {
            InitializeComponent();
            mainControl.Parent = groupBoxDataFigures;
            mainControl.Location = new System.Drawing.Point(7, 15);
            mainControl.ReadOnly = true;
            mainControl.Size = new System.Drawing.Size(600, 345);

            if (_listing.listFigures.Count != 0)
            {
                mainControl.Figure = _listing.listFigures[dataGridViewFigures.SelectedCells[0].RowIndex];
            }
        }

        private FiguresControl mainControl = new FiguresControl();





        /// <summary>
        /// Кнопка добавления строки с данными о фигуре в список через форму создания фигуры
        /// </summary>
        private void buttonAdd_Figure_Click(object sender, EventArgs e)
        {
            FigureForm formAdded = new FigureForm();
            formAdded.ShowDialog();

            var figure = formAdded.EditFigures;
            if (figure == null)
            {
                return;
            }
            dataGridViewFigures.Rows.Add(figure.GetType().Name, figure.StartPoint.StartX, figure.StartPoint.StartY,figure.StartPoint.StartZ, figure.GetVolume());
            _listing.listFigures.Add(figure);
            mainControl.Figure = _listing.listFigures[dataGridViewFigures.SelectedCells[0].RowIndex];
        }

        /// <summary>
        /// Кнопка удаления строки из списка 
        /// </summary>
        private void buttonRemove_Figure_Click(object sender, EventArgs e)
        {
            if (dataGridViewFigures.Rows.Count == 0)
            {
                MessageBox.Show("Список пуст!");
            }
            else
            {
                int removeIndex = dataGridViewFigures.CurrentCell.RowIndex;
                dataGridViewFigures.Rows.RemoveAt(removeIndex);
                _listing.listFigures.RemoveAt(removeIndex);
                mainControl.Clear(); ;
            }

        }

        /// <summary>
        /// Кнопка поиска данных c другой формы
        /// </summary>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchForm f = new SearchForm();
            //f.Owner = this;
            f.Figures = dataGridViewFigures;
            f.ShowDialog();

        }

        /// <summary>
        /// Кнопка изменения данных в строке списка через форму создания фигуры
        /// </summary>
        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (dataGridViewFigures.Rows.Count == 0)
            {
                MessageBox.Show("Список пуст!");
            }
            else
            {
                int modIndex = dataGridViewFigures.CurrentCell.RowIndex;

                FigureForm formMod = new FigureForm(modIndex, _listing);
                formMod.EditFigures = _listing.listFigures[modIndex];
                formMod.ShowDialog();
                var newFigure = formMod.EditFigures;
                if (formMod.EditFigures == null)
                {
                    return;
                }
                _listing.listFigures.Insert(dataGridViewFigures.SelectedCells[0].RowIndex, newFigure);
                _listing.listFigures.RemoveAt(dataGridViewFigures.SelectedCells[0].RowIndex + 1);
                dataGridViewFigures.Rows.Clear();
                foreach (var data in _listing.listFigures)
                {
                    dataGridViewFigures.Rows.Add(data.GetType().Name, data.StartPoint.StartX, data.StartPoint.StartY,data.StartPoint.StartZ, data.GetVolume());
                }
            }
        }

        /// <summary>
        /// Десериализация списка
        /// </summary>
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serialization serial = new Serialization();

            openFile.Filter = "Списки фигур (.ifgr)|*.ifgr";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                serial.Deserializing(openFile, _listing);
                foreach (var data in _listing.listFigures)
                {
                    dataGridViewFigures.Rows.Add(data.GetType().Name, data.StartPoint.StartX, data.StartPoint.StartY,data.StartPoint.StartZ, data.GetVolume());
                }
            }

        }

        /// <summary>
        /// Сериализация списка
        /// </summary>
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Serialization serial = new Serialization();

            saveFile.Filter = "Списки фигур (*.ifgr)|*.ifgr";
            if (_listing.listFigures.Count == 0)
            {
                MessageBox.Show("Список фигур пуст.");
            }
            else if (saveFile.ShowDialog() == DialogResult.OK)
            {
                serial.Serializing(saveFile, _listing);

                MessageBox.Show("Список сохранен.");
            }
        }

        private void dataGridViewFigures_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dataGridViewFigures.CurrentCell;
            int position = cell.RowIndex;
            mainControl.Figure = _listing.listFigures[position];
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
