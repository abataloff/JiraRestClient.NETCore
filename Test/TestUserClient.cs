using Micromata.Jira.Domain;
using Xunit;

namespace Micromata.Jira.Test
{
    public class TestUserClient : BaseTest
    {

        [Fact]
        public void testGetLoggedInUser()
        {
            var userclient = restClient.UserClient;
            var task = userclient.GetLoggedInUser();
            var user = task.GetAwaiter().GetResult() as User;
            Assert.NotNull(user);
        }

        [Fact]
        public void TestGetUserByUsername()
        {
            var userclient = restClient.UserClient;
            var task = userclient.GetUserByUsername(username);
            var user = task.GetAwaiter().GetResult() as User;
            Assert.NotNull(user);
        }
    }
}