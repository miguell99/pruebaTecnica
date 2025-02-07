using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pruebaTecnica.Users.aplication;
using Moq;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Security;
using pruebaTecnica.Users.aplication.Handlers;
using pruebaTecnica.Users.domain;
using pruebaTecnica.Users.infraestructure.Commands;

namespace pruebaTecnica.test
{
    
    public class AddUsersShould
    {
        private readonly Mock<IUserRepository> _userRepositoryMock;
        private readonly User _user;

        public AddUsersShould()
        {
            _userRepositoryMock = new();
            _user = new User
            {
                Email = "test@test.com",
                UserName = "test"
            };
        }
       
        [Fact]
        public async Task AddUsers()
        {
            
            //Arrange
            var command = new AddUserCommand("email@test.com", "emailtest");
            
            var handler = new AddUserHandler(_userRepositoryMock.Object);

            _userRepositoryMock.Setup(x => x.AddUser(
                It.IsAny<User>())).ReturnsAsync(true);
            //Act

            var result = await handler.Handle(command, default);

            
            //Assert

            Assert.True(result);

        }
        
    }
}
