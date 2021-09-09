using System;
using Week7.EquazioneGrado2.Core;
using Xunit;

namespace Week7.EquazioneGrado2.Test
{
    public class EquazioneTest
    {
        [Fact]
        public void Test1()
        {
            //Arrange: predisposizione del test
            Equation equazione = new Equation();

            //Act: chiamata alla funzionalità da testare
            double[] risultato1 = equazione.RisolviEquazioneDiSecondoGrado(1, -3, 2);
            double[] risultato2 = equazione.RisolviEquazioneDiSecondoGrado(1, -5, 6);
            double[] risultato3 = equazione.RisolviEquazioneDiSecondoGrado(1, 2, 1);
            double[] risultato4 = equazione.RisolviEquazioneDiSecondoGrado(1, -3, 10);

            //Assert: verifica del risultato 1
            Assert.True(risultato1.Length == 2);
            Assert.Equal(1, risultato1[0]); //Oppure Assert.True(risultato[0] == 1);
            Assert.Equal(2, risultato1[1]);

            //Assert: verifica del risultato 2
            Assert.True(risultato2.Length == 2);
            Assert.Equal(2, risultato2[0]); 
            Assert.Equal(3, risultato2[1]);

            //Assert: verifica del risultato 3
            Assert.True(risultato3.Length == 1);
            Assert.Equal(-1, risultato3[0]);


            //Assert: verifica del risultato 4            
            Assert.Null(risultato4);
            

        }
    }
}
