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
    public partial class FigureForm : Form
    {
        private bool _maskedX = false;
        private bool _maskedY = false;
        private bool _maskedZ = false;
        private bool _maskedRadius = false;
        private bool _maskedWidth = false;
        private bool _maskedHeight = false;
        private bool _maskedLength = false;
        private bool _maskedSideA = false;
        private bool _maskedSideH = false;

        public FigureForm()
        {
            InitializeComponent();

#if DEBUG
            buttonRandom.Visible = true;
#endif

        }


        /// <summary>
        /// Кнопка добавления данных о фигуре в список из формы создания фигуры
        /// </summary>
        private void OK_Click(object sender, EventArgs e)
        {
            bool exitCondition = false;

            if ((maskedTextBoxStartX.Text != "     ,") || (maskedTextBoxStartY.Text != "     ,") || (maskedTextBoxStartZ.Text != "     ,") || (maskedTextBoxWidth.Text != "    ,") || (maskedTextBoxHeight.Text != "     ,") || (maskedTextBoxLength.Text != "    ,") || (maskedTextBoxRadius.Text != "    ,") || (maskedTextBoxA.Text != "    ,") || (maskedTextBoxH.Text != "    ,"))
            {
                exitCondition = true;
            }
            if (!(_maskedX && _maskedY && _maskedZ) && !(exitCondition))
            {
                {
                    MessageBox.Show("Одна из начальных координат или обе координаты не были введены!");
                    return;
                }
            }
            else if (comboBoxFigures.SelectedIndex == -1)
            {
                {
                    MessageBox.Show("Не была выбрана геометрическая фигура");
                    return;
                }
            }
            else if ((comboBoxFigures.SelectedIndex == 0) && !(exitCondition))
            {
                if (!(_maskedRadius))
                {
                    MessageBox.Show("Введите значение радиуса !");
                    return;
                }
                else
                    exitCondition = true;
            }
            else if ((comboBoxFigures.SelectedIndex == 1) && !(exitCondition))
            {
                if (!(_maskedWidth && _maskedHeight && _maskedLength))
                {
                    MessageBox.Show("Одна из сторон не была введена");
                    return;
                }
                else
                    exitCondition = true;
            }
            else if ((comboBoxFigures.SelectedIndex == 2) && !(exitCondition))
            {
                if (!(_maskedSideA && _maskedSideH))
                {
                    MessageBox.Show("Одна или несколько сторон не были введены!");
                    return;
                }
                else
                    exitCondition = true;
            }

            if (exitCondition)
            {
                this.DialogResult = DialogResult.OK;
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

        private void comboBoxFigures_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxFigures.SelectedIndex)
            {
                case 0:
                    {
                        maskedTextBoxRadius.Visible = true;
                        maskedTextBoxWidth.Visible = false;
                        maskedTextBoxHeight.Visible = false;
                        maskedTextBoxLength.Visible = false;
                        maskedTextBoxA.Visible = false;
                        maskedTextBoxH.Visible = false;

                        break;
                    }

                case 1:

                    {
                        maskedTextBoxRadius.Visible = false;
                        maskedTextBoxWidth.Visible = true;
                        maskedTextBoxHeight.Visible = true;
                        maskedTextBoxLength.Visible = true;
                        maskedTextBoxA.Visible = false;
                        maskedTextBoxH.Visible = false;
                        break;
                    }

                case 2:
                    {
                        maskedTextBoxRadius.Visible = false;
                        maskedTextBoxWidth.Visible = false;
                        maskedTextBoxHeight.Visible = false;
                        maskedTextBoxLength.Visible = false;
                        maskedTextBoxA.Visible = true;
                        maskedTextBoxH.Visible = true;
                        break;
                    }
            }
        }

        private Model.IFigure _figure;

        /// <summary>
        /// Описание данных о фигуре
        /// </summary>
        public Model.IFigure Figure
        {
            get
            {
                if (comboBoxFigures.SelectedIndex == 0)
                {
                    var bl = new Ball();

                    bl.StartPoint.StartX = Convert.ToDouble(maskedTextBoxStartX.Text);
                    bl.StartPoint.StartY = Convert.ToDouble(maskedTextBoxStartY.Text);
                    bl.StartPoint.StartZ = Convert.ToDouble(maskedTextBoxStartZ.Text);

                    bl.Radius = Convert.ToDouble(maskedTextBoxRadius.Text);
                    _figure=bl;
                }

                else if (comboBoxFigures.SelectedIndex == 1)
                {
                    var par = new Parallelepiped();
                    par.StartPoint.StartX = Convert.ToDouble(maskedTextBoxStartX.Text);
                    par.StartPoint.StartY = Convert.ToDouble(maskedTextBoxStartY.Text);
                    par.StartPoint.StartZ = Convert.ToDouble(maskedTextBoxStartZ.Text);

                    par.Width = Convert.ToDouble(maskedTextBoxWidth.Text);
                    par.Heigth = Convert.ToDouble(maskedTextBoxHeight.Text);
                    par.Length = Convert.ToDouble(maskedTextBoxLength.Text);
                    _figure=par;
                }
                else if (comboBoxFigures.SelectedIndex == 2)
                {
                    var pyr = new Pyramid();
                    pyr.StartPoint.StartX = Convert.ToDouble(maskedTextBoxStartX.Text);
                    pyr.StartPoint.StartY = Convert.ToDouble(maskedTextBoxStartY.Text);
                    pyr.StartPoint.StartZ = Convert.ToDouble(maskedTextBoxStartZ.Text);

                    pyr.A = Convert.ToDouble(maskedTextBoxA.Text);
                    pyr.H = Convert.ToDouble(maskedTextBoxH.Text);
                    _figure=pyr;
                }
                return _figure;
            }
            set
            {
                maskedTextBoxStartX.Text = Convert.ToString(value.StartPoint.StartX);
                maskedTextBoxStartY.Text = Convert.ToString(value.StartPoint.StartY);
                maskedTextBoxStartZ.Text = Convert.ToString(value.StartPoint.StartZ);

                if (value is Ball)
                {
                    var bl = (Ball)value;
                    comboBoxFigures.SelectedIndex = 0;
                    maskedTextBoxRadius.Text = Convert.ToString(bl.Radius);
                }

                else if (value is Parallelepiped)
                {
                    var par = (Parallelepiped)value;
                    comboBoxFigures.SelectedIndex = 1;
                    maskedTextBoxWidth.Text = Convert.ToString(par.Width);
                    maskedTextBoxHeight.Text = Convert.ToString(par.Heigth);
                    maskedTextBoxLength.Text = Convert.ToString(par.Length);
                }

                else if (value is Pyramid)
                {
                    var pyr = (Pyramid)value;
                    comboBoxFigures.SelectedIndex = 2;
                    maskedTextBoxA.Text = Convert.ToString(pyr.A);
                    maskedTextBoxH.Text = Convert.ToString(pyr.H);
                }
            }
        }

        /// <summary>
        /// Кнопка для рассчёта объёма геометрической фигуры
        /// </summary>
        private void buttonCount_Volume_Click(object sender, EventArgs e)
        {
            if((_maskedRadius) || (_maskedHeight && _maskedLength && _maskedWidth) || (_maskedSideA && _maskedSideH))
            textBoxCountVolume.Text = Convert.ToString(Figure.GetVolume());
            else
            {
                {
                    MessageBox.Show(" Не все величины были введены");
                    return;
                }
            }
        }



        private void maskedTextBoxStartZ_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBoxStartZ.SelectionStart = 0;
        }

        private void maskedTextBoxStartZ_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxStartZ.Text == "    .")
            {
                errorProviderZ.SetError(maskedTextBoxStartZ, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderZ.Clear();
                _maskedZ = true;
            }
        }

        private void maskedTextBoxStartX_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBoxStartX.SelectionStart = 0;
        }

        private void maskedTextBoxStartX_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxStartX.Text == "    .")
            {
                errorProviderX.SetError(maskedTextBoxStartX, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderX.Clear();
                _maskedX = true;
            }
        }

        private void maskedTextBoxStartY_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBoxStartY.SelectionStart = 0;
        }

        private void maskedTextBoxStartY_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxStartY.Text == "    .")
            {
                errorProviderY.SetError(maskedTextBoxStartY, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderY.Clear();
                _maskedY = true;
            }
        }

        private void maskedTextBoxWidth_MouseClick_1(object sender, MouseEventArgs e)
        {
            maskedTextBoxWidth.SelectionStart = 0;
        }

        private void maskedTextBoxWidth_Leave_1(object sender, EventArgs e)
        {
            if (maskedTextBoxWidth.Text == "     .")
            {
                errorProviderWidth.SetError(maskedTextBoxWidth, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderWidth.Clear();
                _maskedWidth = true;
            }
        }

        private void maskedTextBoxHeight_MouseClick_1(object sender, MouseEventArgs e)
        {
            maskedTextBoxHeight.SelectionStart = 0;
        }

        private void maskedTextBoxHeight_Leave_1(object sender, EventArgs e)
        {
            if (maskedTextBoxHeight.Text == "   .")
            {
                errorProviderHeight.SetError(maskedTextBoxHeight, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderHeight.Clear();
                _maskedHeight = true;
            }
        }

        private void maskedTextBoxLength_MouseClick_1(object sender, MouseEventArgs e)
        {
            maskedTextBoxLength.SelectionStart = 0;
        }

        private void maskedTextBoxLength_Leave_1(object sender, EventArgs e)
        {
            if (maskedTextBoxLength.Text == "    .")
            {
                errorProviderLength.SetError(maskedTextBoxLength, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderLength.Clear();
                _maskedLength = true;
            }
        }

        private void maskedTextBoxRadius_MouseClick_1(object sender, MouseEventArgs e)
        {
            maskedTextBoxRadius.SelectionStart = 0;

        }

        private void maskedTextBoxRadius_Leave_1(object sender, EventArgs e)
        {
            if (maskedTextBoxRadius.Text == "   .")
            {
                errorProviderRadius.SetError(maskedTextBoxRadius, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderRadius.Clear();
                _maskedRadius = true;
            }
        }

        private void maskedTextBoxA_MouseClick_1(object sender, MouseEventArgs e)
        {
            maskedTextBoxA.SelectionStart = 0;
        }

        private void maskedTextBoxA_Leave_1(object sender, EventArgs e)
        {
            if (maskedTextBoxA.Text == "    .")
            {
                errorProviderA.SetError(maskedTextBoxH, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderH.Clear();
                _maskedSideA = true;
            }

        }

        private void maskedTextBoxH_MouseClick_1(object sender, MouseEventArgs e)
        {
            maskedTextBoxH.SelectionStart = 0;
        }

        private void maskedTextBoxH_Leave_1(object sender, EventArgs e)
        {
            if (maskedTextBoxH.Text == "    .")
            {
                errorProviderH.SetError(maskedTextBoxH, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderH.Clear();
                _maskedSideH = true;
            }
        }

        /// <summary>
        /// Кнопка, добавляющая случайные данные о фигуре
        /// </summary>
        private void buttonRandom_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            int figureName = rand.Next(3);

            switch (figureName)
            {
                case 0:
                    {
                        comboBoxFigures.SelectedIndex = 0;
                        break;
                    }
                case 1:
                    {
                        comboBoxFigures.SelectedIndex = 1;
                        break;
                    }
                case 2:
                    {
                        comboBoxFigures.SelectedIndex = 2;
                        break;
                    }
            }
            maskedTextBoxStartX.Text = Convert.ToString(11111.111 + rand.NextDouble() * (99999.999 - 11111.111));
            maskedTextBoxStartY.Text = Convert.ToString(11111.111 + rand.NextDouble() * (99999.999 - 11111.111));
            maskedTextBoxStartZ.Text = Convert.ToString(11111.111 + rand.NextDouble() * (99999.999 - 11111.111));
            _maskedX = true;
            _maskedY = true;
            _maskedZ = true;

            if (comboBoxFigures.SelectedIndex == 0)
            {
                maskedTextBoxRadius.Text = Convert.ToString(1111.111 + rand.NextDouble() * (9999.999 - 1111.111));
                _maskedRadius = true;
            }
            else if (comboBoxFigures.SelectedIndex == 1)
            {
                maskedTextBoxWidth.Text = Convert.ToString(1111.111 + rand.NextDouble() * (9999.999 - 1111.111));
                maskedTextBoxHeight.Text = Convert.ToString(1111.111 + rand.NextDouble() * (9999.999 - 1111.111));
                maskedTextBoxLength.Text = Convert.ToString(1111.111 + rand.NextDouble() * (9999.999 - 1111.111));
                _maskedWidth = true;
                _maskedHeight = true;
                _maskedLength = true;

            }
            else if (comboBoxFigures.SelectedIndex == 2)
            {
                maskedTextBoxA.Text = Convert.ToString(1111.111 + rand.NextDouble() * (1999.999 - 1111.111));
                maskedTextBoxH.Text = Convert.ToString(1111.111 + rand.NextDouble() * (1999.999 - 1111.111));
                _maskedSideA = true;
                _maskedSideH = true;

            }
        }
    }
}
