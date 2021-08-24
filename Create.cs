using System;
using System.Collections.Generic;
using System.Linq;

namespace AulaProjetoLetsCode2
{
    public class Create : User, ICreateSeller, ICreateClient
    {
        Perguntas perguntas = new Perguntas();
        private List<Seller> _seller;
        private List<Client> _client;
        public IReadOnlyList<Seller> Sellers { get => _seller; }
        public IReadOnlyList<Client> Clients { get => _client; }
        public IReadOnlyList<User> Users { get => _user; }

        public Create()
        {
            CarregaDadosDoUsuario();
            CarregaDadosDoSeller();
            CarregaDadosDoClient();
        }

        private void CarregaDadosDoUsuario()
        {
            _user = new List<User>();
        }
        private void CarregaDadosDoSeller()
        {
            _seller = new List<Seller>();
        }
        private void CarregaDadosDoClient()
        {
            _client = new List<Client>();
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
            var nomeUser = ObterClientePeloUser(resposta2[0]);
            if(nomeUser == null)
            {
                Console.WriteLine("USUÁRIO NÃO CADASTRADO. PRIMEIRO REALIZE O CADASTRO DE USUÁRIO. \n\n");
            }
            else
            {
                _seller.Add(new Seller()
                {
                    id = id++,
                    name = nomeUser.name,
                    user = nomeUser.user,
                    password = nomeUser.password
                });
                Console.WriteLine("CADASTRO CONFIRMADO. AGORA O USUÁRIO É UM VENDEDOR\n\n");
            }
        }

        public void AddClient()
        {
            var resposta2 = perguntas.Resposta2();
            var nomeUser = ObterClientePeloUser(resposta2[0]);
            if (nomeUser == null)
            {
                Console.WriteLine("USUÁRIO NÃO CADASTRADO. PRIMEIRO REALIZE O CADASTRO DE USUÁRIO. \n\n");
            }
            else
            {
                _client.Add(new Client()
                {
                    id = id++,
                    name = nomeUser.name,
                    user = nomeUser.user,
                    password = nomeUser.password
                });
                Console.WriteLine("CADASTRO CONFIRMADO. AGORA O USUÁRIO É UM CLIENTE\n\n");
            }
        }

        public User ObterClientePeloUser(string user)
        {
            return Users.FirstOrDefault(usuario => usuario.user == user);
        }
    }
}