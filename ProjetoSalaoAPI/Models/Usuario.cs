using System.ComponentModel.DataAnnotations;

namespace ProjetoSalaoAPI.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuar { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public Usuario()
        {
        }

        public Usuario(int idUsuar, string login, string senha)
        {
            IdUsuar = idUsuar;
            Login = login;
            Senha = senha;
        }

    }
}
