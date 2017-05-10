using System;

namespace Model
{
    public  class Pyramid : IFigure
    {
        double _a;
        double _h;

        /// <summary>
        /// Установления значения и возврат стороны А 
        /// </summary>
        public double A
        {
            get { return _a; }
            set
            {
                if (value < 0) throw new ArgumentException("Значение меньше 0. Введите число больше 0");
                _a = value;
            }
        }
        /// <summary>
        /// Установления  значения и возврат высоты H
        /// </summary>
        public double H
        {
            get { return _h; }
            set
            {
                if (value < 0) throw new ArgumentException("Значение меньше 0. Введите число больше 0");
                _h = value;
            }
        }

        /// <summary>
        /// Начальные координаты, которые хранятся в классе Point
        /// </summary>
        public Point StartPoint { get; set; } = new Point();
        /// <summary>
        /// Рассчитываем площадь Пирамиды
        /// </summary>
        public double GetArea()
        {
            return _a * _a;
        }

        /// <summary>
        /// Рассчитываем объем Пирамиды
        /// </summary>
        /// <returns></returns>
        public double GetVolume()
        {
            return ((1.0 / 3.0) * _a * _a * _h);
        }
    }
}
