using FluentAssertions;
using Xunit.Abstractions;
using Moq;
using UserTests.Users.Domain;

namespace UsersTests.UsersManagement.Users.Application.Search;

public class UserSearcherTest
{
    private readonly Mock<IUserRepositoryTest> _userRepositoryMock;
    private readonly List<UserTest> _userTests;

    public UserSearcherTest()
    {
        _userRepositoryMock = new Mock<IUserRepositoryTest>();
        _userTests= new List<UserTest>()
        {
            new UserTest { Id = 1, UserName = "user1", Email = "user1@test.com" },
            new UserTest { Id = 2, UserName = "user2", Email = "user2@test.com" }
        };
    }
    [Fact]
    public async Task SearchUsersTest()
    {
        // Arrange
        _userRepositoryMock.Setup(x => x.SearchUsers()).ReturnsAsync(_userTests);
        // Act
        var result = await _userRepositoryMock.Object.SearchUsers();
        // Test
        result.Should().BeEquivalentTo(_userTests);
    }
}