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
        public MainForm()
        {
            InitializeComponent();

        }

        JsonSerializer serializer = new JsonSerializer()
        {
            TypeNameHandling = TypeNameHandling.All,
            Formatting = Formatting.Indented,
            NullValueHandling = NullValueHandling.Include
        };



        /// <summary>
        /// Кнопка добавления строки с данными о фигуре в список через форму создания фигуры
        /// </summary>
        private void buttonAdd_Figure_Click(object sender, EventArgs e)
        {
            FigureForm formAdd = new FigureForm();

            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                var figure = formAdd.Figure;

                this.dataGridViewFigures.Rows.Add(figure.GetType().Name, figure.StartPoint.StartX,
                    figure.StartPoint.StartY, figure.StartPoint.StartZ, figure.GetVolume());
                FigureList.listFigures.Add(figure);
            }
        }

        /// <summary>
        /// Кнопка удаления строки из списка 
        /// </summary>
        private void buttonRemove_Figure_Click(object sender, EventArgs e)
        {
            int removeIndex = dataGridViewFigures.CurrentCell.RowIndex;
            dataGridViewFigures.Rows.RemoveAt(removeIndex);
            FigureList.listFigures.RemoveAt(removeIndex);

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
                FigureForm formMod = new FigureForm();
                int modIndex = dataGridViewFigures.CurrentCell.RowIndex;
                formMod.Figure = FigureList.listFigures[modIndex];

                if (formMod.ShowDialog() == DialogResult.OK)
                {
                    var newFigure = formMod.Figure;
                    FigureList.listFigures.Insert(dataGridViewFigures.SelectedCells[0].RowIndex, newFigure);
                    FigureList.listFigures.RemoveAt(dataGridViewFigures.SelectedCells[0].RowIndex + 1);
                    dataGridViewFigures.Rows.Clear();
                    foreach (var data in FigureList.listFigures)
                    {
                        dataGridViewFigures.Rows.Add(data.GetType().Name, data.StartPoint.StartX,
                            data.StartPoint.StartY, data.StartPoint.StartZ, data.GetVolume());
                    }
                }
            }
        }

        /// <summary>
        /// Десериализация списка
        /// </summary>
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile.Filter = "Списки фигур (.ifgr)|*.ifgr";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFile.FileName))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    FigureList.listFigures = (List<Model.IFigure>)serializer.Deserialize(reader, typeof(List<Model.IFigure>));
                    dataGridViewFigures.Rows.Clear();
                    foreach (var data in FigureList.listFigures)
                    {
                        dataGridViewFigures.Rows.Add(data.GetType().Name, data.StartPoint.StartX, data.StartPoint.StartY, data.StartPoint.StartZ, data.GetVolume());
                    }
                }
            }

        }

        /// <summary>
        /// Сериализация списка
        /// </summary>
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FigureList.listFigures.Count == 0)
            {
                MessageBox.Show("Список фигур пуст.");
            }

            saveFile.Filter = "Списки фигур (.ifgr)|*.ifgr";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, FigureList.listFigures);
                }
                MessageBox.Show("Список сохранен.");
            }
        }
    }
}
