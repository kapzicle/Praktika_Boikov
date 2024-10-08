using Praktika_Boikov;

namespace Testing
{
        [TestClass]
        public class TUserService
        {
            [TestMethod]
            public void TestAddAndGelAllUsers()
            {
                /// REVIEW. a.boikov. 2024/10/08. Класс UserService требует обязательно объект PasswordService
                /// в конструкторе. Планируется ли как-то настраивать данный объект извне?
                /// Если нет, тогда лучше его определить просто как отдельное поле в классе UserService,
                /// а конструктор оставить без параметров.
                PasswordService passwordService = new PasswordService();
                UserService userService = new UserService(passwordService);
                userService.AddUser("user1", "Andrey", "Smirnov");

                /// REVIEW. a.boikov. 2024/10/08. вместо var требуется указать конкрентный тип возвращаемого
                /// значения.
                var users = userService.GetAllUsers();

                Assert.AreEqual(1, users.Count);
                Assert.AreEqual("user1", users[0].Login);
                Assert.AreEqual("Andrey", users[0].FirstName);
                Assert.AreEqual("Smirnov", users[0].LastName);
            }
        }
}