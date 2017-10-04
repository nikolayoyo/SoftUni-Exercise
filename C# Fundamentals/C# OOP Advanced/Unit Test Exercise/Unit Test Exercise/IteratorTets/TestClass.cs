using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Iterator;

namespace IteratorTets
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void CheckForNext()
        {
            //Arrange
            ListIterator tester = new ListIterator(new List<string>() {"A", "B", "C"});
            var fildInfo = typeof(ListIterator).GetField("index", BindingFlags.Instance | BindingFlags.NonPublic);
            fildInfo.SetValue(tester, 2);


            //Assert
            Assert.AreEqual(false, tester.HasNext(), "Found element out of the index");
        }

        [Test]
        public void MoveToNext()
        {
            //Arrange
            ListIterator tester = new ListIterator(new List<string>() { "A", "B", "C" });
            var fildInfo = typeof(ListIterator).GetField("index", BindingFlags.Instance | BindingFlags.NonPublic);
            fildInfo.SetValue(tester, 2);

            //Assert
            Assert.AreEqual(false, tester.Move(), "Found element out of the index");
        }

        [Test]
        public void ConstructorTest()
        {
            //Assert
            Assert.Throws<ArgumentNullException>(()=> new ListIterator(null), "Created an instance with null parameter int the constr");
        }
    }
}
