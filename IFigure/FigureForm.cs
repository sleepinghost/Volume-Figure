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
using IFigure = Model.IFigure;

namespace Figure
{
    public partial class FigureForm : Form
    {
        private FiguresControl EditFiguresControl = new FiguresControl();

        public Model.IFigure EditFigures;

        

        public FigureForm()
        {
            InitializeComponent();

            EditFiguresControl.Parent = groupBoxEdit;
            EditFiguresControl.Location = new Point (16, 20);
            EditFiguresControl.ReadOnly = false;
            EditFiguresControl.Size = new Size(420, 345 );



            #if DEBUG
            buttonRandom.Visible = true;
            #endif

        }


        /// <summary>
        /// Кнопка добавления данных о фигуре в список из формы создания фигуры
        /// </summary>
        private void OK_Click(object sender, EventArgs e)
        {

            if (EditFiguresControl.Closed())
            {
                EditFigures = EditFiguresControl.Figure;
                Close();
            }
        }

        /// <summary>
        /// Кнопка "Отменить действие" 
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }


        public FigureForm(int numRow, FigureList _listing)
        {
            InitializeComponent();

            EditFiguresControl.Parent = groupBoxEdit;
            EditFiguresControl.Location = new Point(16, 20);
            EditFiguresControl.ReadOnly = false;
            EditFiguresControl.Size = new Size(600, 345);
            EditFiguresControl.Figure = _listing.listFigures[numRow];
        }


        /// <summary>
        /// Кнопка, добавляющая случайные данные о фигуре
        /// </summary>
        private void buttonRandom_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int figureName = random.Next(3);
            EditFiguresControl.FigureRandomName(figureName);

            if (figureName == 0)
            {
                var bl = new Model.Ball();
                bl.StartPoint.StartX = Convert.ToDouble(1.111 + random.NextDouble() * (999.999 - 1.111));
                bl.StartPoint.StartY = Convert.ToDouble(1.111 + random.NextDouble() * (999.999 - 1.111));
                bl.StartPoint.StartZ = Convert.ToDouble(1.111 + random.NextDouble() * (999.999 - 1.111));
                bl.Radius = Convert.ToDouble(1.111 + random.NextDouble() * (99.999 - 1.111));
                EditFiguresControl.Figure = bl;
            }
            else if (figureName == 1)
            {
                var pyr = new Pyramid();
                pyr.StartPoint.StartX = Convert.ToDouble(1.111 + random.NextDouble() * (999.999 - 1.111));
                pyr.StartPoint.StartY = Convert.ToDouble(1.111 + random.NextDouble() * (999.999 - 1.111));
                pyr.StartPoint.StartZ = Convert.ToDouble(1.111 + random.NextDouble() * (999.999 - 1.111));
                pyr.A = Convert.ToDouble(1.111 + random.NextDouble() * (99.999 - 1.111));
                pyr.H = Convert.ToDouble(1.111 + random.NextDouble() * (99.999 - 1.111));
                EditFiguresControl.Figure = pyr;
            }
            else if (figureName == 2)
            {
                var par = new Parallelepiped();
                par.StartPoint.StartX = Convert.ToDouble(1.111 + random.NextDouble() * (999.999 - 1.111));
                par.StartPoint.StartY = Convert.ToDouble(1.111 + random.NextDouble() * (999.999 - 1.111));
                par.StartPoint.StartZ = Convert.ToDouble(1.111 + random.NextDouble() * (999.999 - 1.111));
                par.Width = Convert.ToDouble(11.111 + random.NextDouble() * (19.999 - 11.111));
                par.Height = Convert.ToDouble(11.111 + random.NextDouble() * (19.999 - 11.111));
                par.Length = Convert.ToDouble(11.111 + random.NextDouble() * (19.999 - 11.111));
                EditFiguresControl.Figure = par;
            }

        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            try
            {
                EditFigures = EditFiguresControl.Figure;
                EditFigures.GetVolume();
                EditFiguresControl.Figure = EditFigures;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Возможно, данные сторон геометрической фигуры не соответствуют правилам построения ");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Не были введены параметры одной из фигур");
            }
        }
    }
}
