using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.Text.RegularExpressions;

namespace Figure
{
    public partial class FiguresControl : UserControl
    {

        public FiguresControl()
        {
            InitializeComponent();
        }

        private bool _readOnly;
        private bool _closed;
        private Model.IFigure _objected;


        public bool Closed()
        {
            _closed = false;
            if (maskedTextBoxStartX.Text == "   ," && maskedTextBoxStartY.Text == "   ," && maskedTextBoxStartZ.Text == "   ,")
            {
                MessageBox.Show("Не были введены начальные координаты фигуры!");
                return _closed;
            }

            if (comboBoxFigure.SelectedIndex == 0 && maskedTextBoxRadius.Text == "  ,")
            {
                MessageBox.Show("Не был введен радиус шара");
                return _closed;
            }

            if (comboBoxFigure.SelectedIndex == 1 && (maskedTextBoxA.Text == "  ," || maskedTextBoxH.Text == "  ,"))
            {
                MessageBox.Show("Не была введена сторона или высота пирамиды!");
                return _closed;
            }

            if (comboBoxFigure.SelectedIndex == 2 && (maskedTextBoxA.Text == "  ," || maskedTextBoxH.Text == "  ,"))
            {
                MessageBox.Show("Не все стороны параллелепипеда были введены");
                return _closed;
            }
            return _closed = true;
        }

        public Model.IFigure Figure
        {
            get
            {
                if (comboBoxFigure.SelectedIndex == 0)
                {
                    var bl = new Ball();

                    bl.StartPoint.StartX = Convert.ToDouble(maskedTextBoxStartX.Text);
                    bl.StartPoint.StartY = Convert.ToDouble(maskedTextBoxStartY.Text);
                    bl.StartPoint.StartZ = Convert.ToDouble(maskedTextBoxStartZ.Text);
                    bl.Radius = Convert.ToDouble(maskedTextBoxRadius.Text);

                    _objected = bl;
                }
                else if (comboBoxFigure.SelectedIndex == 1)
                {
                    var pyr = new Pyramid();

                    pyr.StartPoint.StartX = Convert.ToDouble(maskedTextBoxStartX.Text);
                    pyr.StartPoint.StartY = Convert.ToDouble(maskedTextBoxStartY.Text);
                    pyr.StartPoint.StartZ = Convert.ToDouble(maskedTextBoxStartZ.Text);
                    pyr.A = Convert.ToDouble(maskedTextBoxA.Text);
                    pyr.H = Convert.ToDouble(maskedTextBoxH.Text);

                    return pyr;
                }
                else if (comboBoxFigure.SelectedIndex == 2)
                {
                    var par = new Parallelepiped();

                    par.StartPoint.StartX = Convert.ToDouble(maskedTextBoxStartX.Text);
                    par.StartPoint.StartY = Convert.ToDouble(maskedTextBoxStartY.Text);
                    par.StartPoint.StartZ = Convert.ToDouble(maskedTextBoxStartZ.Text);
                    par.Width = Convert.ToDouble(maskedTextBoxWidth.Text);
                    par.Height = Convert.ToDouble(maskedTextBoxHeight.Text);
                    par.Length = Convert.ToDouble(maskedTextBoxLength.Text);
                    _objected = par;
                }
                return _objected;
            }

            set
            {
                _objected = value;
                maskedTextBoxStartX.Text = Convert.ToString(value.StartPoint.StartX);
                maskedTextBoxStartY.Text = Convert.ToString(value.StartPoint.StartY);
                maskedTextBoxStartZ.Text = Convert.ToString(value.StartPoint.StartZ);
                textBoxVolume.Text = Convert.ToString(value.GetVolume());
                if (value is Model.Ball)
                {
                    var bl = (Model.Ball)value;
                    comboBoxFigure.SelectedIndex = 0;

                    maskedTextBoxRadius.Text = Convert.ToString(bl.Radius);
                }
                else if (value is Model.Pyramid)
                {
                    var pyr = (Model.Pyramid)value;
                    comboBoxFigure.SelectedIndex = 1;

                    maskedTextBoxA.Text = Convert.ToString(pyr.A);
                    maskedTextBoxH.Text = Convert.ToString(pyr.H);
                }
                else if (value is Model.Parallelepiped)
                {
                    var par = (Model.Parallelepiped)value;
                    comboBoxFigure.SelectedIndex = 2;

                    maskedTextBoxWidth.Text = Convert.ToString(par.Width);
                    maskedTextBoxHeight.Text = Convert.ToString(par.Height);
                    maskedTextBoxLength.Text = Convert.ToString(par.Length);
                }
            }
        }

        public bool ReadOnly
        {
            get
            {
                return _readOnly;
            }
            set
            {
                _readOnly = value;
                if (_readOnly)
                {
                    comboBoxFigure.Enabled = false;
                    maskedTextBoxStartX.ReadOnly = true;
                    maskedTextBoxStartY.ReadOnly = true;
                    maskedTextBoxStartZ.ReadOnly = true;
                    maskedTextBoxRadius.ReadOnly = true;
                    maskedTextBoxA.ReadOnly = true;
                    maskedTextBoxH.ReadOnly = true;
                    maskedTextBoxWidth.ReadOnly = true;
                    maskedTextBoxHeight.ReadOnly = true;
                    maskedTextBoxLength.ReadOnly = true;
                    _readOnly = true;
                }
                else
                {
                    comboBoxFigure.Enabled = true;
                    maskedTextBoxStartX.ReadOnly = false;
                    maskedTextBoxStartY.ReadOnly = false;
                    maskedTextBoxStartZ.ReadOnly = false;
                    maskedTextBoxRadius.ReadOnly = false;
                    maskedTextBoxA.ReadOnly = false;
                    maskedTextBoxH.ReadOnly = false;
                    maskedTextBoxWidth.ReadOnly = false;
                    maskedTextBoxHeight.ReadOnly = false;
                    maskedTextBoxLength.ReadOnly = false;
                    _readOnly = false;
                }
            }
        }

        public void FigureRandomName(int random)
        {
            if (random == 0)
                comboBoxFigure.SelectedIndex = 0;
            if (random == 1)
                comboBoxFigure.SelectedIndex = 1;
            if (random == 2)
                comboBoxFigure.SelectedIndex = 2;
        }

        public void Clear()
        {
            if (ReadOnly)
            {
                comboBoxFigure.SelectedIndex = -1;
                maskedTextBoxStartX.Text = "";
                maskedTextBoxStartY.Text = "";
                maskedTextBoxStartZ.Text = "";
                maskedTextBoxRadius.Text = "";
                maskedTextBoxA.Text = "";
                maskedTextBoxH.Text = "";
                maskedTextBoxWidth.Text = "";
                maskedTextBoxHeight.Text = "";
                maskedTextBoxLength.Text = "";
                textBoxVolume.Text = "";
            }
        }


        private void comboBoxFigure_SelectedIndexChanged(object sender, EventArgs e)
        {
            maskedTextBoxRadius.Visible = comboBoxFigure.SelectedIndex == 0;
            maskedTextBoxA.Visible = comboBoxFigure.SelectedIndex == 1;
            maskedTextBoxH.Visible = comboBoxFigure.SelectedIndex == 1;
            maskedTextBoxWidth.Visible = comboBoxFigure.SelectedIndex == 2;
            maskedTextBoxHeight.Visible = comboBoxFigure.SelectedIndex == 2;
            maskedTextBoxLength.Visible = comboBoxFigure.SelectedIndex == 2;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxStartX_TextChanged(object sender, EventArgs e)
        {
            maskedTextBoxStartX.Text = new Regex(@"[ ]{2,}", RegexOptions.None).Replace(maskedTextBoxStartX.Text, @" ");
        }

        private void maskedTextBoxStartY_TextChanged(object sender, EventArgs e)
        {
            maskedTextBoxStartY.Text = new Regex(@"[ ]{2,}", RegexOptions.None).Replace(maskedTextBoxStartY.Text, @" ");
        }

        private void maskedTextBoxStartZ_TextChanged(object sender, EventArgs e)
        {
            maskedTextBoxStartZ.Text = new Regex(@"[ ]{2,}", RegexOptions.None).Replace(maskedTextBoxStartZ.Text, @" ");
        }

        private void maskedTextBoxRadius_TextChanged(object sender, EventArgs e)
        {
            maskedTextBoxRadius.Text = new Regex(@"[ ]{2,}", RegexOptions.None).Replace(maskedTextBoxRadius.Text, @" ");
        }

        private void maskedTextBoxA_TextChanged(object sender, EventArgs e)
        {
            maskedTextBoxA.Text = new Regex(@"[ ]{2,}", RegexOptions.None).Replace(maskedTextBoxA.Text, @" ");
        }

        private void maskedTextBoxH_TextChanged(object sender, EventArgs e)
        {
            maskedTextBoxH.Text = new Regex(@"[ ]{2,}", RegexOptions.None).Replace(maskedTextBoxH.Text, @" ");
        }

        private void maskedTextBoxWidth_TextChanged(object sender, EventArgs e)
        {
            maskedTextBoxWidth.Text = new Regex(@"[ ]{2,}", RegexOptions.None).Replace(maskedTextBoxWidth.Text, @" ");
        }

        private void maskedTextBoxHeight_TextChanged(object sender, EventArgs e)
        {
            maskedTextBoxHeight.Text = new Regex(@"[ ]{2,}", RegexOptions.None).Replace(maskedTextBoxHeight.Text, @" ");
        }

        private void maskedTextBoxLength_TextChanged(object sender, EventArgs e)
        {
            maskedTextBoxLength.Text = new Regex(@"[ ]{2,}", RegexOptions.None).Replace(maskedTextBoxLength.Text, @" ");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
