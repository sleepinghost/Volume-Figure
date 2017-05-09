using System;

namespace Model
{
    /// <summary>
    /// Класс Поинт
    /// Основа фигуры
    /// </summary>
    public class Point 
    {
        double _startX;
        double _startY;
        double _startZ;
        /// <summary>
        /// Установления значения координаты Х, начальной точки
        /// </summary>
        public double StartX
        {
            get
            {
                return _startX;
            }
            set
            {
                if (value <0) throw new ArgumentException("Введённое значене меньше 0");
                _startX = value;
            }
        }
        /// <summary>
        /// Установления значения координаты Y, начальной точки
        /// </summary>
        public double StartY
        {
            get
            {
                return _startY;
            }
            set
            {
                if (value < 0) throw new ArgumentException("Введённое значене меньше 0");
                _startY = value;
            }
        }
        /// <summary>
        /// Установления значения координаты Z, начальной точки
        /// </summary>
        public double StartZ
        {
            get
            {
                return _startZ;
            }
            set
            {
                if (value < 0) throw new ArgumentException("Введённое значене меньше 0");
                _startZ = value;
            }
        }
    }
}

