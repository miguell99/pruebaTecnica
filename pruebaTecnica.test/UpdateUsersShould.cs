using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using Moq;
using pruebaTecnica.Users.aplication;
using pruebaTecnica.Users.domain;

namespace pruebaTecnica.test
{
    public class UpdateUsersShould
    {
        private readonly Mock<IUserRepository> _mock = new Mock<IUserRepository>();
        User UserToUpdate = new User
            {
                Id = 1, Email = "user1@cojali.com", UserName = "user1"
           };

        [Fact]
        public void UpdateSuccesfullyAnUser()
        {
            // Arrange

            _mock.Setup(x => x.UpdateUser(UserToUpdate)).ReturnsAsync(true);
            var cu = new UpdateUsersCU(_mock.Object);

            // Act

            var result = cu.Update(UserToUpdate);

            // Assert

            Assert.True(result.Result);

        }

        [Fact]
        public void FailUpdateUser()
        {
            
            

            _mock.Setup(x => x.UpdateUser(UserToUpdate)).ReturnsAsync(false);

            var cu = new UpdateUsersCU(_mock.Object);

            // Act

            var result = cu.Update(UserToUpdate);

            // Assert

            Assert.False(result.Result);
        }

        [Fact]
        public void UpdateUser_CallUpdateUserOne()
        {
            var cu = new GetUsersCU((_mock.Object));

            cu.Get();

            _mock.Verify(x => x.GetUsers(), Times.Once);
        }
    }
}
