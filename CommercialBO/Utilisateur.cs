namespace CommercialBO
{
    public class Utilisateur
    {
        private string mail;
        private string password;


        public Utilisateur(string _Mail, string _Password)
        {
            mail = _Mail;
            password = _Password;
        }

        public string Mail { get => mail; set => mail = value; }
        public string Password { get => password; set => password = value; }
    }
}
