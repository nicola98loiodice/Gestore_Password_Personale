using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Utente
    {
        // Proprietà auto-implementate (sostituiscono i campi + getter/setter)
        public string Username { get; set; }
        public string Password { get; set; }

        public Utente(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
