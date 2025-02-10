using Moq;
using UserTests.Users.Domain;
using FluentAssertions;
namespace UsersTests.UsersManagement.Users.Application.Create;

public class UserCreatorTest
{
    private readonly Mock<IUserRepositoryTest> _userRepositoryMock;
    private readonly UserTest _user;

    public UserCreatorTest()
    {
        _userRepositoryMock = new Mock<IUserRepositoryTest>();
        _user = new UserTest
        {
            Email = "test@test.com",
            UserName = "test"
        };
    }
    [Fact]
    public async Task CreateUserTest()
    {
        // Arrange
        _userRepositoryMock.Setup(x => x.CreateUser(
            It.IsAny<UserTest>())).ReturnsAsync(true);
        // Act
        var result = await _userRepositoryMock.Object.CreateUser(_user);
        // Assert 
        result.Should().BeTrue();
    }
}