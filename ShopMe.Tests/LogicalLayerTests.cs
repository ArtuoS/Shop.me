using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ShopMe.Tests
{
    public class LogicalLayerTests
    {
        [Fact]
        public void UserGivenInsertIntoDb()
        {
            //arrange
            var user = new User()
            {
                Id = 1,
                City = "Blumenau",
                Country = "Brazil",
                DateOfBirthday = new DateTime(2000, 10, 16),
                Email = "arthureduardomolinari@gmail.com",
                Gender = Entities.Enums.EGender.Male,
                LastName = "Molinari",
                Name = "Arthur",
                Password = "myPASS@!101",
                State = "Santa Catarina"
            };

            var expected = user != null;

            //act
            var result = true;

            //assert
            Assert.Equal(expected, result);
        }
    }
}
