using FluentAssertions;
using Moq;
using UserTests.Users.Domain;

namespace UsersTests.UsersManagement.Users.Application.Find;

public class UserFinderTest
{
    private readonly Mock<IUserRepositoryTest> _userRepositoryMock;
    private readonly int _userId;
    private readonly UserTest _user;
    public UserFinderTest()
    {
        _userRepositoryMock = new Mock<IUserRepositoryTest>();
        _userId = 1;
        _user = new UserTest
        {
            Id = _userId,
            UserName = "userName",
            Email = "email",
        };
    }

    [Fact]
    public async Task FindUserTest()
    {
        // Arrange
        _userRepositoryMock.Setup(x => x.FindUser(
            It.IsAny<int>())).ReturnsAsync(_user);
        // Act
        var result = await _userRepositoryMock.Object.FindUser(_userId);
        // Assert
        result.Should().BeEquivalentTo(_user);
        
    }

    [Fact]
    public async Task NotFindUserTest()
    {
        // Arrange
        _userRepositoryMock.Setup(repo => repo.FindUser(_userId)).ReturnsAsync((UserTest)null);
        // Act
        var result = await _userRepositoryMock.Object.FindUser(_userId);
        
        //Assert
        result.Should().BeNull();
    }
    
}