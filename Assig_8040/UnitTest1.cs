using NUnit.Framework;

using Assig2;

namespace Assig_8040
{

    [TestFixture]
    public class Tests
    {
        
        [Test]
            public void Tri_1()
            {

            int sidea= 0;
            int sideb= 1;
            int sidec = 22;


            string expected = "Not form triangle";
            string actual = Trianglesolver.Analyze(sidea, sideb, sidec);
            Assert.AreEqual(expected, actual);
            }

        [Test]
        public void Tri_2()
        {

            int sidea = 22;
            int sideb = 1;
            int sidec = 3;


            string expected = "Scalene triangle";
            string actual = Trianglesolver.Analyze(sidea, sideb, sidec);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Tri_3()
        {

            int sidea = 12;
            int sideb = 12;
            int sidec = 8;


            string expected = "Not form triangle";
            string actual = Trianglesolver.Analyze(sidea, sideb, sidec);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Tri_4()
        {

            int sidea = 4;
            int sideb = 4;
            int sidec = 3;


            string expected = "Isosceles triangle";
            string actual = Trianglesolver.Analyze(sidea, sideb, sidec);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Tri_5()
        {

            int sidea = 3;
            int sideb = 3;
            int sidec = 3;


            string expected = "Equilateral triangle";
            string actual = Trianglesolver.Analyze(sidea, sideb, sidec);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Tri_6()
        {

            int sidea = 9;
            int sideb = 12;
            int sidec = -6;


            string expected = "Not form triangle";
            string actual = Trianglesolver.Analyze(sidea, sideb, sidec);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Tri_7()
        {

            int sidea = -9;
            int sideb = 12;
            int sidec = 22;
            //fgfg

            string expected = "Not form triangle";
            string actual = Trianglesolver.Analyze(sidea, sideb, sidec);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Tri_8()
        {

            int sidea = 6;
            int sideb = -12;
            int sidec = 22;


            string expected = "Not form triangle";
            string actual = Trianglesolver.Analyze(sidea, sideb, sidec);
            Assert.AreEqual(expected, actual);
        }


    }

    }
//}