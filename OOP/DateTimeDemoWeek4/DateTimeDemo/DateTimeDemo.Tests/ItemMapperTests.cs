using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateTimeDemo.Models;
using NUnit.Framework;

namespace DateTimeDemo.Tests
{
    [TestFixture]
    public class ItemMapperTests
    {

        [Test]
        public void ShouldConvertItemToCSV()
        {
            //Arrange
            Item item = new Item()
            {
                Id = 1,
                Name = "Bob",
                Cost = 1.5m,
                Description = "It's bob you guys"
            };
            string expected = "1::Bob::It's bob you guys::1.50";
            //Act
            string actual = ItemMapper.ToStringCsv(item);
            //Assert
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void ShouldconvertFromStringToItem()
        {
            Item expected = new Item()
            {
                Id = 1,
                Name = "Bob",
                Cost = 1.5m,
                Description = "It's bob you guys"
            };
            string input = "1::Bob::It's bob you guys::1.50";
            //Act
            Item actual = ItemMapper.ToObject(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
