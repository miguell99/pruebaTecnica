using FluentAssertions;
using Moq;
using UserTests.Users.Domain;

namespace UsersTests.UsersManagement.Users.Application.Update;

public class UserUpdaterTest
{
    private readonly Mock<IUserRepositoryTest> _userRepositoryMock;

    public UserUpdaterTest()
    {
        _userRepositoryMock = new Mock<IUserRepositoryTest>();
    }
    [Fact]
    public async Task UpdateUser()
    {
        // Arrange
        _userRepositoryMock.Setup(x => x.UpdateUser(It.IsAny<UserTest>())).ReturnsAsync(true);
        // Act
        var result = await _userRepositoryMock.Object
            .UpdateUser(new UserTest { Id = 1, UserName = "user1", Email = "user1@test.com"});
        // Assert
        result.Should().BeTrue();
    }
}