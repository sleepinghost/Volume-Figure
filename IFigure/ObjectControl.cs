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

namespace Figure
{
    public partial class ObjectControl : UserControl
    {
        public ObjectControl()
        {
            InitializeComponent();
        }


        private Object _object;

        public Object Object
        {
            get
            {
                if (comboBoxFigures.SelectedIndex == 0)
                {
                    var bl = new Model.Ball();

                    bl.StartPoint.StartX = Convert.ToDouble(maskedTextBoxStartX.Text);
                    bl.StartPoint.StartY = Convert.ToDouble(maskedTextBoxStartY.Text);
                    bl.StartPoint.StartY = Convert.ToDouble(maskedTextBoxStartY.Text);

                    bl.Radius = Convert.ToDouble(maskedTextBoxRadius.Text);
                    _object = bl;
                }
                else if (comboBoxFigures.SelectedIndex == 1)
                {
                    var par = new Model.Parallelepiped();

                    par.StartPoint.StartX = Convert.ToDouble(maskedTextBoxStartX.Text);
                    par.StartPoint.StartY = Convert.ToDouble(maskedTextBoxStartY.Text);
                    par.StartPoint.StartZ = Convert.ToDouble(maskedTextBoxStartZ.Text);

                    par.Width = Convert.ToDouble(maskedTextBoxWidth.Text);
                    par.Heigth = Convert.ToDouble(maskedTextBoxHeigth.Text);
                    par.Length = Convert.ToDouble(maskedTextBoxLength.Text);
                    _object = par;
                }
                else if (comboBoxFigures.SelectedIndex == 2)
                {
                    var pyr = new Model.Pyramid();

                    pyr.StartPoint.StartX = Convert.ToDouble(maskedTextBoxStartX.Text);
                    pyr.StartPoint.StartY = Convert.ToDouble(maskedTextBoxStartY.Text);
                    pyr.StartPoint.StartZ = Convert.ToDouble(maskedTextBoxStartZ.Text);


                    pyr.A = Convert.ToDouble(maskedTextBoxA);
                    pyr.H = Convert.ToDouble(maskedTextBoxH);
                    _object = pyr;
                }
                return _object;
            }
            set
            {
                var fig = (Model.IFigure)value;
                maskedTextBoxStartX.Text = Convert.ToString(fig.StartPoint.StartX);
                maskedTextBoxStartY.Text = Convert.ToString(fig.StartPoint.StartY);
                maskedTextBoxStartZ.Text = Convert.ToString(fig.StartPoint.StartZ);

                if (value is Model.Ball)
                {
                    var bl = (Model.Ball)value;
                    comboBoxFigures.SelectedIndex = 0;

                    maskedTextBoxRadius.Text = Convert.ToString(bl.Radius);
                }
                else if (value is Model.Parallelepiped)
                {
                    var par = (Model.Parallelepiped)value;
                    comboBoxFigures.SelectedIndex = 1;

                    maskedTextBoxWidth.Text = Convert.ToString(par.Width);
                    maskedTextBoxHeigth.Text = Convert.ToString(par.Heigth);
                    maskedTextBoxLength.Text = Convert.ToString(par.Width);
                }
                else if (value is Model.Pyramid)
                {
                    var pyr = (Model.Pyramid)value;
                    comboBoxFigures.SelectedIndex = 2;

                    maskedTextBoxA.Text = Convert.ToString(pyr.A);
                    maskedTextBoxH.Text = Convert.ToString(pyr.H);
                }
            }
        }

        public bool ReadOnly
        {
            get { return ReadOnly; }
            set
            {
                maskedTextBoxStartX.ReadOnly = true;
                maskedTextBoxStartY.ReadOnly = true;
                maskedTextBoxStartZ.ReadOnly = true;
                maskedTextBoxWidth.ReadOnly = true;
                maskedTextBoxHeigth.ReadOnly = true;
                maskedTextBoxLength.ReadOnly = true;
                maskedTextBoxRadius.ReadOnly = true;
                maskedTextBoxA.ReadOnly = true;
                maskedTextBoxH.ReadOnly = true;
            }
        }

    }
}
