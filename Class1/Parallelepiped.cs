using System;

namespace Model
{
    /// <summary>
    /// Класс Параллелепипед
    /// </summary>
    public class Parallelepiped : IFigure
    {
        double _width;
        double _height;
        double _length;
        /// <summary>
        /// Установления значения и возврат ширины Параллелепипеда
        /// </summary>
        public double Width
        {
            get { return _width; }
            set
            {
                if (value < 0) throw new ArgumentException("Значение меньше 0. Введите число больше 0");
                _width = value;
            }
        }
        /// <summary>
        /// Установления значения высоты
        /// </summary>
        public double Heigth
        {
            get { return _height; }
            set
            {
                if (value < 0) throw new ArgumentException("Значение меньше 0. Введите число больше 0");
                _height = value;
            }
        }
        /// <summary>
        /// Установления значения длины
        /// </summary>
        public double Length
        {
            get { return _length; }
            set
            {
                if (value < 0) throw new ArgumentException("Значение меньше 0. Введите число больше 0");
                _length = value;
            }
        }

        /// <summary>
        /// Начальные координаты, которые хранятся в классе Point
        /// </summary>
        public Point StartPoint { get; set; } = new Point();
       
        /// <summary>
        /// Рассчитывем площадь
        /// </summary>
        public double GetArea()
        {
            return 2 * (_width * _length + _width * _height + _length * _height);
        }
        
        /// <summary>
        /// Рассчитывем объем
        /// </summary>
        public double GetVolume()
        {
            return _width * _height * _length;
        }
    }
}
