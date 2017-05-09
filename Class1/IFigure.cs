namespace Model
{
    /// <summary>
    /// Интерфейс
    /// </summary>
   public interface IFigure
    {

        /// <summary>
        /// Переменная, которая хранит начальные координаты в классе Point
        /// </summary>
        Point StartPoint
        {
            get;
            set;
        }

        /// <returns> имеет доступ к начальным координатам, класса Поинт </returns>
        double GetVolume();
    }
}
