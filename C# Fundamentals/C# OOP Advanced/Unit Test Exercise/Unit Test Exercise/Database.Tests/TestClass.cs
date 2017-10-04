using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using NUnit.Framework;
using _01_Unit_Test;

namespace Tests
{
    [TestFixture]
    public class TestClass
    {


        [Test]
        public void DatabaseConstructorTest()
        {
            //Arrange
            var testList = new List<Person>();
            for (int i = 0; i < 17; i++)
            {
                testList.Add(new Person(i, $"{i}Musito"));
            }

            Assert.Throws<InvalidOperationException>(() => new Database(testList.ToArray()), "Invalid params count");
        }

        [Test]
        public void InvalidAddTest()
        {
            //Arrange
            Database db = new Database(new Person[0]);
            for (int i = 0; i < 16; i++)
            {
                db.Add(new Person(i, $"{i}Pesho"));
            }

            //Assert
            Assert.Throws<InvalidOperationException>(() => db.Add(new Person(33, "Hasan")), "cant Add more elements");
        }

        [Test]
        public void InvalidRemoveTest()
        {
            //Arrange
            Database db = new Database(new Person[0]);

            //Assert
            Assert.Throws<InvalidOperationException>(() => db.Remove(), "Cant remove element from empty database");
        }

        [Test]
        public void AddValidation()
        {
            //Arrange
            Database db = new Database(new Person(1, "Musito"));
            var elementToAdd = new Person(2, "BratMu");
            //Act
            db.Add(elementToAdd);

            //Assert
            Assert.AreEqual(elementToAdd, db.Fetch().Last(), "Add element method failed");
        }

        [Test]
        public void RemoveValidation()
        {
            //Arrange
            Database db = new Database(new Person(1, "Musito"), new Person(2, "BratMu"));

            //Act
            db.Remove();

            Type dbType = db.GetType();
            var memberInfo = dbType.GetField("storage", BindingFlags.Instance | BindingFlags.NonPublic);
            if (memberInfo != null)
            {
                var database = (Person[]) memberInfo.GetValue(db);

                //Assert
                Assert.AreEqual(1, database.Length, "Remove method failed");
            }
        }

        [Test]
        public void SameNameTwice()
        {
            //Arrange
            Database db = new Database(new Person(1, "Musito"));

            //Assert
            Assert.Throws<InvalidOperationException>(() => db.Add(new Person(2, "Musito")), "Added same name twice");
        }

        [Test]
        public void SameIdTwice()
        {
            //Arrange
            Database db = new Database(new Person(1, "Musito"));

            //Assert
            Assert.Throws<InvalidOperationException>(() => db.Add(new Person(1, "BratMu")), "Added same id twice");
        }

        [Test]
        public void LookForNegativeId()
        {
            //Arrange
            Database db = new Database(new Person[0]);

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => db.FindById(-1),
                "Looked for person with negative name");
        }

        [Test]
        public void LookForNullName()
        {
            //Arrange
            Database db = new Database(new Person[0]);

            //Assert
            Assert.Throws<ArgumentNullException>(() => db.FindByUsername(null), "Looked for person with null name");
        }
    }
}