using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using pruebaTecnica.Users.aplication;
using pruebaTecnica.Users.domain;

namespace pruebaTecnica.test
{
    public class GetUsersShould
    {
        private readonly Mock<IUserRepository> _mock = new Mock<IUserRepository>();
        List<User> _users = new List<User>
        {
            new User { Id = 1, UserName = "user1", Email = "user1@cojali.com" },
            new User { Id = 2, UserName = "user2", Email = "user2@cojali.com" }
        };
        [Fact]
        public void GetUsers()
        {

            // Arrange
            
            _mock.Setup(repo => repo.GetUsers()).ReturnsAsync(_users);

            var sut = new GetUsersCU(_mock.Object);

            // Act

            var result = sut.Get();

            // Assert

            Assert.NotNull(result.Result);
            Assert.Equal(2, result.Result.Count());
            Assert.Contains(result.Result, user => user.UserName == "user1");
            Assert.Contains(result.Result, user => user.UserName == "user2");

        }

        [Fact]
        public void NotGetUsersWithEmptyDB()
        {

            // Arrange
            
            _mock.Setup(repo => repo.GetUsers()).ReturnsAsync(new List<User>());
            var cu = new GetUsersCU(_mock.Object);

            // Act 
            var result = cu.Get();

            // Assert
            Assert.NotNull(result.Result);
            Assert.Empty(result.Result);

        }

        [Fact]
        public void GetUsers_CallGetUsersOne()
        {
            
            var cu = new GetUsersCU((_mock.Object));

            cu.Get();

            _mock.Verify(x => x.GetUsers(), Times.Once);
        }
    }
}
