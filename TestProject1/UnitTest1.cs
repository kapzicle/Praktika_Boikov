using Praktika_Boikov;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            UserService userService;
            PasswordService passwordService;
            passwordService = new PasswordService();
            userService = new UserService(passwordService);
            userService.AddUser("user1", "Andrey", "Smirnov");
            var users = userService.GetAllUsers();

            Assert.AreEqual(1, users.Count);
            Assert.AreEqual("user1", users[0].Login);
            Assert.AreEqual("Andrey", users[0].FirstName);
            Assert.AreEqual("Smirnov", users[0].LastName);
        }
    }
}