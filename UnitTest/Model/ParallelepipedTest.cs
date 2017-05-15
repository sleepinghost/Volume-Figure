using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using NUnit.Framework;

namespace UnitTest.Model
{
    [TestFixture]
    class ParallelepipedTest
    {
        /// <summary>
        /// Тестирование ввода координаты Х (не должна быть меньше 0)
        /// </summary>
        /// /// <param name="StartX">Координата Х параллелепипеда</param>

        [Test]
        [TestCase(0, TestName = "Тестирование ввода координаты Х при значении 0")]
        [TestCase(15, TestName = "Тестирование ввода координаты Х при значении 15")]
        [TestCase(-15, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование ввода координаты Х при значении -15")]

        public void StartXTest(double _startX)
        {
            var startXParallelepiped = new Parallelepiped();
            startXParallelepiped.StartPoint.StartX = _startX;
        }

        /// <summary>
        /// Тестирование ввода координаты У (не должна быть меньше 0)
        /// </summary>
        /// /// <param name="StartY">Координата У шара</param>

        [Test]
        [TestCase(0, TestName = "Тестирование ввода координаты У при значении 0")]
        [TestCase(15, TestName = "Тестирование ввода координаты У при значении 15")]
        [TestCase(-15, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование ввода координаты У при значении -15")]

        public void StartУTest(double _startУ)
        {
            var startYParallelepiped = new Parallelepiped();
            startYParallelepiped.StartPoint.StartY = _startУ;
        }

        /// <summary>
        /// Тестирование ввода координаты Z (не должна быть меньше 0)
        /// </summary>
        /// /// <param name="StartZ">Координата Z шара</param>

        [Test]
        [TestCase(0, TestName = "Тестирование ввода координаты Z при значении 0")]
        [TestCase(15, TestName = "Тестирование ввода координаты Z при значении 15")]
        [TestCase(-15, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование ввода координаты Z при значении -15")]

        public void StartZTest(double _startZ)
        {
            var startZParallelepiped = new Parallelepiped();
            startZParallelepiped.StartPoint.StartZ = _startZ;
        }


        /// <summary>
        /// Тестирование ввода ширины (не должен быть меньше 0)
        /// </summary>
        /// /// <param name="Width">Ширина </param>

        [Test]
        [TestCase(0, TestName = "Тестирование ввода ширины при значении 0")]
        [TestCase(15, TestName = "Тестирование ввода ширины при значении 15")]
        [TestCase(-15, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование ввода ширины при значении -15")]

        public void WidthTest(double _width)
        {
            var widthP = new Parallelepiped();
            widthP.Width = _width;
        }

        /// <summary>
        /// Тестирование ввода высоты (не должен быть меньше 0)
        /// </summary>
        /// /// <param name="Height">Высота </param>

        [Test]
        [TestCase(0, TestName = "Тестирование ввода высоты при значении 0")]
        [TestCase(15, TestName = "Тестирование ввода высоты при значении 15")]
        [TestCase(-15, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование ввода высоты при значении -15")]

        public void HeightTest(double _height)
        {
            var heightP = new Parallelepiped();
            heightP.Heigth = _height;
        }

        /// <summary>
        /// Тестирование ввода длины (не должен быть меньше 0)
        /// </summary>
        /// /// <param name="Length">Длина </param>

        [Test]
        [TestCase(0, TestName = "Тестирование ввода длины при значении 0")]
        [TestCase(15, TestName = "Тестирование ввода длины при значении 15")]
        [TestCase(-15, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование ввода длины при значении -15")]

        public void LengthTest(double _length)
        {
            var lengthP = new Parallelepiped();
            lengthP.Length = _length;
        }

        /// <summary>
        /// Тестирование вывода итогового рассчета объема Параллелепипеда
        /// </summary>
        /// <returns>Объем параллелепипеда</returns>
        [Test]
        [TestCase(2, 3, 4, 24, TestName = "Тестирование итогового расчета объема параллелепипеда")]
        public void volumeTest(double _width, double _height, double _length, double _volume)
        {
            var volumePar = new Parallelepiped();
            volumePar.Width = _width;
            volumePar.Heigth = _height;
            volumePar.Length = _length;
            var result = volumePar.GetVolume();
            Assert.AreEqual(_volume, result);
        }

    }
}
