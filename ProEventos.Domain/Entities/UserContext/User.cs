using Microsoft.AspNetCore.Identity;

namespace ProEventos.Domain.Entities.UserContext
{
    public class User : IdentityUser
    {
        public User(string whatsApp, string email, string primeiroNome, string ultimoNome)
        {
            WhatsApp = whatsApp;
            Email = email;
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;
        }

        public string WhatsApp { get; private set; }
        public string Email { get; private set; }
        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }

        public void SetEmail(string email)
        {
            Email = email;
        }
    }
}
