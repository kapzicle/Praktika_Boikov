namespace Praktika_Boikov
{
    public class UserService
    {
        private List<User> users = new List<User>();
        private PasswordService passwordService;

        public UserService(PasswordService passwordService)
        {
            this.passwordService = passwordService;
        }

        public void AddUser(string login, string firstName, string lastName)
        {
            string password = passwordService.GeneratePassword();
            User user = new User(login, password, firstName, lastName);
            users.Add(user);
        }

        public void DeleteUser(string login)
        {
            var user = users.FirstOrDefault(u => u.Login == login);
            if (user != null)
            {
                users.Remove(user);
            }
        }

        public User GetUserByLogin(string login)
        {
            return users.FirstOrDefault(u => u.Login == login);
        }

        public List<User> GetAllUsers()
        {
            return users;
        }
    }
}
