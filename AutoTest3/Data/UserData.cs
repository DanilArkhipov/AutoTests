namespace AutoTest3.Data
{
    public class UserData
    {
        public UserData(string email, string password)
        {
            Email = email;
            Password = password;
        }
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
