using System;
using System.Collections.Generic;
using System.Linq;

namespace AulaProjetoLetsCode2
{
    public class Create : User
    {
        private List<User> _user;
        public IReadOnlyList<User> Users { get => _user; }

        public Create()
        {
            CarregaDadosDoUsuario();
        }

        private void CarregaDadosDoUsuario()
        {
            _user = new List<User>();
        }
        public void AddUser()
        {
            Console.WriteLine("Qual seu nome: ");
            string name = Console.ReadLine();
            Console.WriteLine("Qual seu nome de usuario: ");
            string usuario = Console.ReadLine();
            Console.WriteLine("Qual sua senha: ");
            string senha = Console.ReadLine();

            _user.Add(new User()
            { 
                id = id++,
                name = name,
                user = usuario,
                password = senha
            });
        }
        public User ObterClientePeloUser(string user)
        {
            return Users.FirstOrDefault(usuario => usuario.user == user);
        }
    }
}