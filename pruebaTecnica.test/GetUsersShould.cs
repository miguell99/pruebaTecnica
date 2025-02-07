using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using pruebaTecnica.Users.aplication;
using pruebaTecnica.Users.aplication.DTO;
using pruebaTecnica.Users.aplication.Handlers;
using pruebaTecnica.Users.domain;
using pruebaTecnica.Users.infraestructure.Queries;

namespace pruebaTecnica.test
{
    public class GetUsersShould
    {
        private readonly Mock<IUserRepository> _userRepositoryMock;
        private readonly List<UserDTO> _users;

        public GetUsersShould()
        {
            _userRepositoryMock = new();
            _users = new List<UserDTO>
            {
                new UserDTO { Id = 1, UserName = "user1", Email = "user1@test.com" },
                new UserDTO { Id = 2, UserName = "user2", Email = "user2@test.com" }
            };

        }
        [Fact]
        public async Task GetUsers()
        {

            // Arrange

            var command = new GetAllUsersQuery();

            var handler = new GetUsersHandler(_userRepositoryMock.Object);

            _userRepositoryMock.Setup(x => x.GetUsers()).ReturnsAsync(_users);

            // Act

            var result = await handler.Handle(command, default);

            // Assert

            Assert.NotNull(result);
            Assert.Equal(2, result.Count());
            Assert.Contains(result, user => user.UserName == "user1");
            Assert.Contains(result, user => user.UserName == "user2");

        }
        
        [Fact]
        public async Task NotGetUsersWithEmptyDB()
        {

            // Arrange

            var command = new GetAllUsersQuery();

            var handler = new GetUsersHandler(_userRepositoryMock.Object);

            _userRepositoryMock.Setup(x => x.GetUsers()).ReturnsAsync(new List<UserDTO>());

            // Act

            var result = await handler.Handle(command, default);

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);

        }

    }
}

