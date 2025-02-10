using Dapper;
using MySqlConnector;
using UserTests.Users.Domain;

namespace UserTests.Users.Infrastructure
{
    public class UserRepositoryTest : IUserRepositoryTest
    {

        const string connectionString = "server=localhost;port=3306;database=userdb;uid=root;password=password9";




        public async Task<IEnumerable<UserTest>> SearchUsers()
        {
            using var connection = new MySqlConnection(connectionString);
            {
                var sql = "SELECT * FROM user";
                return await connection.QueryAsync<UserTest>(sql, new { });
            }

        }

        public async Task<bool> CreateUser(UserTest user)
        {
            using var connection = new MySqlConnection(connectionString);
            {
                var sql = "INSERT INTO user (email, username) VALUES (@Email, @UserName)";
                var result = await connection.ExecuteAsync(sql, new { user.Email, user.UserName });
                return result > 0;
            }



        }

        public async Task<bool> UpdateUser(UserTest user)
        {
            using var connection = new MySqlConnection(connectionString);
            {
                var sql = "UPDATE user SET email=@Email, username = @UserName WHERE id = @Id";
                var result = await connection.ExecuteAsync(sql, new { user.Email, user.UserName, user.Id });
                return result > 0;
            }
        }

        public async Task<UserTest> FindUser(int id)
        {
            using var connection = new MySqlConnection(connectionString);
            {
                var sql = "SELECT email, username FROM user WHERE id = @Id";
                var result = await connection.QueryFirstAsync<UserTest>(sql, new { Id = id });
                return result;
            }
        }
    }
}
