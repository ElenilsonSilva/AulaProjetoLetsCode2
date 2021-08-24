using System;
using System.Collections.Generic;
using System.Linq;

namespace AulaProjetoLetsCode2
{
    public class Create : User, ICreateSeller
    {
        private List<Seller> _seller;
        public IReadOnlyList<Seller> Sellers { get => _seller; }
        Perguntas perguntas = new Perguntas();
        public IReadOnlyList<User> Users { get => _user; }

        public Create()
        {
            CarregaDadosDoUsuario();
            CarregaDadosDoSeller();
        }

        private void CarregaDadosDoUsuario()
        {
            _user = new List<User>();
        }
        private void CarregaDadosDoSeller()
        {
            _seller = new List<Seller>();
        }
        public void AddUser()
        {
            var resposta = perguntas.Respostas();
            _user.Add(new User()
            { 
                id = id++,
                name = resposta[0],
                user = resposta[1],
                password = resposta[2]
            });
            Console.WriteLine("CADASTRO REALIZADO COM SUCESSO! ! !\n");
        }
        public void AddSeller()
        {
            var resposta2 = perguntas.Resposta2();
            var a = ObterClientePeloUser(resposta2[0]);
            if(a == null)
            {
                Console.WriteLine("USUÁRIO NÃO CADASTRADO. PRIMEIRO REALIZE O CADASTRO DE USUÁRIO. \n\n");
            }
            else
            {
                _seller.Add(new Seller()
                {
                    id = id++,
                    name = a.name,
                    user = a.user,
                    password = a.password
                });
                Console.WriteLine("CADASTRO CONFIRMADO. AGORA O USUÁRIO É UM VENDEDOR\n\n");
            }
        }
        public User ObterClientePeloUser(string user)
        {
            return Users.FirstOrDefault(usuario => usuario.user == user);
        }
    }
}