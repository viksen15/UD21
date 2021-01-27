using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tarea2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.Tests
{
    [TestClass()]
    public class GeometriaTests
    {
        [TestMethod()]
        public void areacuadradoTest()
        {
            Geometria g = new Geometria();
            int result = g.areacuadrado(4);
            Assert.AreEqual(16, result);
        }

        [TestMethod()]
        public void areaCirculoTest()
        {
            Geometria g = new Geometria();
            double result = g.areaCirculo(4);
            Assert.AreEqual(50.2656, result);
        }

        [TestMethod()]
        public void areatrianguloTest()
        {
            Geometria g = new Geometria();
            int result = g.areatriangulo(5, 4);
            Assert.AreEqual(10, result);
        }

        [TestMethod()]
        public void arearectanguloTest()
        {
            Geometria g = new Geometria();
            int result = g.arearectangulo(4, 3);
            Assert.AreEqual(12, result);
        }

        [TestMethod()]
        public void areapentagonoTest()
        {
            Geometria g = new Geometria();
            int result = g.areapentagono(4, 3);
            Assert.AreEqual(6,result);
        }

        [TestMethod()]
        public void arearomboTest()
        {
            Geometria g = new Geometria();
            int result = g.arearombo(2, 3);
            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void arearomboideTest()
        {
            Geometria g = new Geometria();
            int result = g.arearomboide(5, 3);
            Assert.AreEqual(15, result);
        }

        [TestMethod()]
        public void areatrapecioTest()
        {
            Geometria g = new Geometria();
            int result = g.areatrapecio(5, 3, 6);
            Assert.AreEqual(24, result);
        }

        [DataTestMethod]
        [DataRow(1, "cuadrado")]
        [DataRow(2, "Circulo")]
        [DataRow(3, "Triangulo")]
        [DataRow(4, "Rectangulo")]
        [DataRow(5, "Pentagono")]
        [DataRow(6, "Rombo")]
        [DataRow(7, "Romboide")]
        [DataRow(8, "Trapecio")]
        [DataRow(9, "Default")]
        public void figuraTest(int a, string b)
        {
            Geometria g = new Geometria();
            g.figura(a);
        }

    }
}