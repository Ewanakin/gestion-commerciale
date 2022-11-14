namespace CommercialBO
{
    public class Utilisateur
    {
        private string username;
        private string password;


        public Utilisateur(string _Username, string _Password)
        {
            username = _Username;
            password = _Password;
        }

        public string Username1 { get => username; set => username = value; }
        public string Password1 { get => password; set => password = value; }
    }
}
