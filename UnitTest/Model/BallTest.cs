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
    class BallTest
    {
        /// <summary>
        /// Тестирование ввода координаты Х (не должна быть меньше 0)
        /// </summary>
        /// /// <param name="StartX">Координата Х шара</param>

        [Test]
        [TestCase(0, TestName = "Тестирование ввода координаты Х при значении 0")]
        [TestCase(15, TestName = "Тестирование ввода координаты Х при значении 15")]
        [TestCase(-15, ExpectedException = typeof(ArgumentException), TestName = "Тестирование ввода координаты Х при значении -15")]

        public void StartXTest(double _startX)
        {
            var startXBall = new Ball();
            startXBall.StartPoint.StartX = _startX;
        }

        /// <summary>
        /// Тестирование ввода координаты У (не должна быть меньше 0)
        /// </summary>
        /// /// <param name="StartY">Координата У шара</param>

        [Test]
        [TestCase(0, TestName = "Тестирование ввода координаты У при значении 0")]
        [TestCase(15, TestName = "Тестирование ввода координаты У при значении 15")]
        [TestCase(-15, ExpectedException = typeof(ArgumentException), TestName = "Тестирование ввода координаты У при значении -15")]

        public void StartУTest(double _startУ)
        {
            var startYBall = new Ball();
            startYBall.StartPoint.StartY = _startУ;
        }

        /// <summary>
        /// Тестирование ввода координаты Z (не должна быть меньше 0)
        /// </summary>
        /// /// <param name="StartZ">Координата Z шара</param>

        [Test]
        [TestCase(0, TestName = "Тестирование ввода координаты Z при значении 0")]
        [TestCase(15, TestName = "Тестирование ввода координаты Z при значении 15")]
        [TestCase(-15, ExpectedException = typeof(ArgumentException), TestName = "Тестирование ввода координаты Z при значении -15")]

        public void StartZTest(double _startZ)
        {
            var startZBall = new Ball();
            startZBall.StartPoint.StartZ = _startZ;
        }


        /// <summary>
        /// Тестирование ввода радиуса (не должен быть меньше 0)
        /// </summary>
        /// /// <param name="Radius">Радиус шара</param>

        [Test]
        [TestCase(0, TestName = "Тестирование ввода радиуса при значении 0")]
        [TestCase(15, TestName = "Тестирование ввода радиуса при значении 15")]
        [TestCase(-15, ExpectedException = typeof(ArgumentException), TestName = "Тестирование ввода радиуса при значении -15")]

        public void RadiusTest(double _radius)
        {
            var radiusB = new Ball();
            radiusB.Radius = _radius;
        }

        /// <summary>
        /// Тестирование вывода итогового рассчета объема Шара
        /// </summary>
        /// <param name="Radius">Радиус шара</param>
        /// <returns>Объем шара</returns>
        [Test]
        [TestCase(2, 33.510321638291124, TestName = "Тестирование итогового расчета объема шара")]
        public void volumeTest(double _radius, double _volume)
        {
            var volumeBall = new Ball();
            volumeBall.Radius = _radius;
            var result = volumeBall.GetVolume();
            Assert.AreEqual(_volume, result);
        }
    }
}

