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
    class PyramidTest
    {
        /// <summary>
        /// Тестирование ввода координаты Х (не должна быть меньше 0)
        /// </summary>
        /// /// <param name="StartX">Координата Х пирамиды</param>

        [Test]
        [TestCase(0, TestName = "Тестирование ввода координаты Х при значении 0")]
        [TestCase(15, TestName = "Тестирование ввода координаты Х при значении 15")]
        [TestCase(-15, ExpectedException = typeof(ArgumentException), TestName = "Тестирование ввода координаты Х при значении -15")]

        public void StartXTest(double _startX)
        {
            var startXPyramid = new Pyramid();
            startXPyramid.StartPoint.StartX = _startX;
        }

        /// <summary>
        /// Тестирование ввода координаты У (не должна быть меньше 0)
        /// </summary>
        /// /// <param name="StartY">Координата У пирамиды</param>

        [Test]
        [TestCase(0, TestName = "Тестирование ввода координаты У при значении 0")]
        [TestCase(15, TestName = "Тестирование ввода координаты У при значении 15")]
        [TestCase(-15, ExpectedException = typeof(ArgumentException), TestName = "Тестирование ввода координаты У при значении -15")]

        public void StartУTest(double _startУ)
        {
            var startYPyramid = new Pyramid();
            startYPyramid.StartPoint.StartY = _startУ;
        }

        /// <summary>
        /// Тестирование ввода координаты Z (не должна быть меньше 0)
        /// </summary>
        /// /// <param name="StartZ">Координата Z пирамиды</param>

        [Test]
        [TestCase(0, TestName = "Тестирование ввода координаты Z при значении 0")]
        [TestCase(15, TestName = "Тестирование ввода координаты Z при значении 15")]
        [TestCase(-15, ExpectedException = typeof(ArgumentException), TestName = "Тестирование ввода координаты Z при значении -15")]

        public void StartZTest(double _startZ)
        {
            var startZPyramid = new Pyramid();
            startZPyramid.StartPoint.StartZ = _startZ;
        }


        /// <summary>
        /// Тестирование ввода cтороны А (не должен быть меньше 0)
        /// </summary>
        /// /// <param name="A">cтороны А Пирамиды</param>

        [Test]
        [TestCase(0, TestName = "Тестирование ввода cтороны А при значении 0")]
        [TestCase(15.5, TestName = "Тестирование ввода cтороны А при значении 15")]
        [TestCase(-15.5, ExpectedException = typeof(ArgumentException), TestName = "Тестирование ввода cтороны А при значении -15")]

        public void ATest(double _A)
        {
            var A = new Pyramid();
            A.A = _A;
        }

        /// <summary>
        /// Тестирование ввода cтороны H (не должен быть меньше 0)
        /// </summary>
        /// /// <param name="H">cтороны H Пирамиды</param>

        [Test]
        [TestCase(0, TestName = "Тестирование ввода cтороны H при значении 0")]
        [TestCase(15, TestName = "Тестирование ввода cтороны H при значении 15")]
        [TestCase(-15, ExpectedException = typeof(ArgumentException), TestName = "Тестирование ввода cтороны H при значении -15")]

        public void HTest(double _H)
        {
            var H = new Pyramid();
            H.H = _H;
        }

        /// <summary>
        /// Тестирование вывода итогового рассчета объема Пирамиды
        /// </summary>
        /// <returns>Объем пирамиды</returns>
        [Test]
        [TestCase(2, 3, Result = 4, TestName = "Тестирование итогового расчета объема пирамиды")]
        public double volumeTest(double _A, double _H)
        {
            var volumePyr = new Pyramid();
            volumePyr.A = _A;
            volumePyr.H = _H;
            return volumePyr.GetVolume();
        }
    }
}
