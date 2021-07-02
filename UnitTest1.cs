using NUnit.Framework;
using NameSorterTest;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace NameSorterTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arrange
            bool Expected =true;
            //Act
            bool Actual = System.String.Equals("Alvarez", "Alvarez"); 
            //Assert
            Assert.AreEqual(Expected,Actual);
            //Assert.Pass();
        }
        [Test]
        public void Test2()
        {
            string[] text = System.IO.File.ReadAllLines(@"C:\Users\USER\source\repos\NameSorter\unsorted_names_list.txt");
            //Arrange
            string Expected = "Janet Parsons";
            //Act
            string Actual = text[0];
            //Assert
            Assert.AreEqual(Expected, Actual);
            //Assert.Pass();
        }
        [Test]
        public void Test3()
        {
            string[] text = System.IO.File.ReadAllLines(@"C:\Users\USER\source\repos\NameSorter\unsorted_names_list.txt");
            string last;
            string lastName = "";
            foreach (string i in text)
            {
                string[] names = i.Split(' '); // Separating names with delimiter Space

                last = names.Last(); // Fetching lastname

                lastName += "\n" + last;  // Putting lastnames in new string Lastname Separating them with new line  
            }

            // Console.WriteLine(lastName); // Printing last names only

            string[] Sortedlastt = lastName.Split("\n"); // Creating string array of lastName

            Array.Sort(Sortedlastt); // Sorted lastName 
            //Arrange
            string Expected = "Alvarez";
            //Act
            string Actual = Sortedlastt[1];
            //Assert
            Assert.AreEqual(Expected, Actual);
            //Assert.Pass();
        }

    }
}