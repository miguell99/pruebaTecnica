using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using Moq;
using pruebaTecnica.Users.aplication;
using pruebaTecnica.Users.aplication.Handlers;
using pruebaTecnica.Users.domain;
using pruebaTecnica.Users.infraestructure.Commands;

namespace pruebaTecnica.test
{
    public class UpdateUsersShould
    {
        private readonly Mock<IUserRepository> _userRepositoryMock;
        private readonly User _user;

        public UpdateUsersShould()
        {
            _userRepositoryMock = new();
            _user = new User
            {
                Id = 1,
                Email = "test@test.com",
                UserName = "test"
            };
        }

        
        [Fact]
        public async Task UpdateSuccesfullyAnUser()
        {
            // Arrange

            var command = new UpdateUserComand(_user.Id, _user.Email, _user.UserName);

            var handler = new UpdateUserHandler(_userRepositoryMock.Object);

            _userRepositoryMock.Setup(
                x => x.UpdateUser(
                    It.IsAny<User>())
            ).ReturnsAsync(true);

            // Act

            var result = await handler.Handle(command, default);

            // Assert

            Assert.True(result);

        }

        [Fact]
        public async Task FailUpdateUser()
        {

            // Arrange

            var command = new UpdateUserComand(_user.Id, _user.Email, _user.UserName);

            var handler = new UpdateUserHandler(_userRepositoryMock.Object);

            _userRepositoryMock.Setup(
                x => x.UpdateUser(
                    It.IsAny<User>())
            ).ReturnsAsync(false);

            // Act

            var result = await handler.Handle(command, default);

            // Assert

            Assert.False(result);
        }
        
    }
}
