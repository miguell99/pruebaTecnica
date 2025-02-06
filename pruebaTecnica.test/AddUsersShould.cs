using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pruebaTecnica.Users.aplication;
using Moq;
using pruebaTecnica.Users.domain;

namespace pruebaTecnica.test
{
    
    public class AddUsersShould
    {
        private readonly Mock<IUserRepository> _mock = new Mock<IUserRepository> ();
        private readonly User _user = new User();
        [Fact]
        public void AddUsers()
        {
            //Arrange
            User _user = new User();
            var _mock = new  Mock<IUserRepository>();
            _mock.Setup(x => x.AddUser(_user)).ReturnsAsync(true);
            var cu = new AddUsersCU(_mock.Object);
            //Act

            var result =  cu.Add(_user);

            //Assert

            Assert.True(result.Result);

        }

        [Fact]
        public void AddUsers_CallAddUsersOne()
        {
           
            var _mock = new Mock<IUserRepository>();
            var cu = new AddUsersCU((_mock.Object));

            cu.Add(_user);

            _mock.Verify(x => x.AddUser(_user), Times.Once);
        
    }
    }
}
