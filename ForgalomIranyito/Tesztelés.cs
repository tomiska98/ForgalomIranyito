using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgalomIranyito.Tests
{
    class Tesztelés
    {
        [TestFixture]
        public class ForgalomIranyito
        {
            JaratKezelo j;

            [SetUp]
            public void Setup()
            {
                j = new JaratKezelo();
            }

            [Test]
            public void UjJarat()
            {
                j.UjJarat("1", "Budapest", "Dubai", new DateTime(2019 , 3 , 5, 13 , 12 , 00)); 
                
            }
            [Test]
            public void Keses()
            {

                j.UjJarat("1", "Budapest", "Dubai", new DateTime(2019, 4, 5, 13, 12, 00));
                j.Keses("1",(123));
                Assert.Throws<ArgumentException>(=>()){

                }
            }
            [Test]
            public void MikorIndual()
            {
                j.UjJarat("1", "Budapest", "Dubai", new DateTime(2019, 4, 5, 13, 12, 00));
            }
            
            [Test]
            public void JaratokRepuloterrol()
            {
                List<string> ujJarat = new List<string>;

                j.UjJarat("1", "Budapest", "Dubai", new DateTime(2019, 3, 5, 13, 12, 00));
                Assert.AreEqual();
            }
        }
    }
}
