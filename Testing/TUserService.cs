using Praktika_Boikov;

namespace Testing
{
        [TestClass]
        public class TUserService
        {
            [TestMethod]
            public void TestAddAndGelAllUsers()
            {
                /// REVIEW. a.boikov. 2024/10/08. ����� UserService ������� ����������� ������ PasswordService
                /// � ������������. ����������� �� ���-�� ����������� ������ ������ �����?
                /// ���� ���, ����� ����� ��� ���������� ������ ��� ��������� ���� � ������ UserService,
                /// � ����������� �������� ��� ����������.
                PasswordService passwordService = new PasswordService();
                UserService userService = new UserService(passwordService);
                userService.AddUser("user1", "Andrey", "Smirnov");

                /// REVIEW. a.boikov. 2024/10/08. ������ var ��������� ������� ����������� ��� �������������
                /// ��������.
                var users = userService.GetAllUsers();

                Assert.AreEqual(1, users.Count);
                Assert.AreEqual("user1", users[0].Login);
                Assert.AreEqual("Andrey", users[0].FirstName);
                Assert.AreEqual("Smirnov", users[0].LastName);
            }
        }
}