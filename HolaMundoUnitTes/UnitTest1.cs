using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;

namespace HolaMundoUnitTes
{
    //red
    //Escribir una prueba que falle
    //green
    //lo minimo para que la prueba funcione
    //blue
    //puede funcionar mejor el codigo? se puede refactorizar?
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Debe_calculadoraSumar_Retornar_9()

        {
            //arrange
            Calculadora calculadora = new Calculadora();
            int esperado = 9;
            //act
            int actual = calculadora.Sumar(6, 3);

            //Assert
            Assert.AreEqual(esperado, actual);
        }



        [TestMethod]
        public void Debe_calculadoraRestar_RetornarSustraendoMenorMinuendo()

        {    //arrange
            Calculadora calculadora = new Calculadora();
            string esperado = "operacion invalida";
            //act
            try
            {
                int actual = calculadora.Restar(10, 20);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                ex.GetType();
                Assert.AreEqual(esperado, ex.Message);
            }
        }

        [TestMethod]
        public void Debe_calculadoraMultiplicarDosNumeros()

        {    //arrange
            Calculadora calculadora = new Calculadora();
            string esperado = "operacion invalida";
            //act
            try
            {
                int actual = calculadora.Restar(10, 20);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                ex.GetType();
                Assert.AreEqual(esperado, ex.Message);
            }
        }




        [TestMethod]
        public void Debe_calculadoraDividirDosNumeros()

        {    //arrange
            Calculadora calculadora = new Calculadora();
            String esperado = "No puede dividir entre cero";
            //act
            try
            {
                int actual = calculadora.Dividir(10, -1);
               
            }
            catch (Exception ex)
            {
                ex.GetType();
                Assert.AreEqual(esperado, ex.Message);
            }

              //Assert

        }


    }
}
