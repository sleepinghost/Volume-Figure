using System;

namespace Model
{
    public  class Ball : IFigure
    {
       
        double _radius;

        /// <summary>
        /// Установления значения и возврат радиуса Шара
        /// </summary>
        public double Radius
        {

            get { return _radius; }
            set
            {
                if (value < 0) throw new ArgumentException("Значение меньше 0. Введите число больше 0");
                _radius = value;
            }

        }
        /// <summary>
        /// Начальные координаты, которые хранятся в классе Point
        /// </summary>
        public Point StartPoint { get; set; } = new Point();

        /// <summary>
        /// Рассчитываем объем
        /// </summary>
        public double GetVolume()
        {
            return ((4.0 / 3.0) * Math.PI * Radius * Radius * Radius);
        }
    }
}
