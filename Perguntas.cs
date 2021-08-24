using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaProjetoLetsCode2
{
    public class Perguntas
    {
        public List<string> resposta;
        public List<string> resposta2;
        public List<string> Respostas()
        {
            resposta = new List<string>();
            Console.WriteLine("Qual seu nome: ");
            string name = Console.ReadLine();
            Console.WriteLine("Qual seu nome de usuario: ");
            string usuario = Console.ReadLine();
            Console.WriteLine("Qual sua senha: ");
            string senha = Console.ReadLine();

            resposta.Add(name);
            resposta.Add(usuario);
            resposta.Add(senha);

            return resposta;
        }

        public List<string> Resposta2()
        {
            resposta2 = new List<string>();

            Console.WriteLine("Digite seu user name: ");
            string user = Console.ReadLine();
            Console.WriteLine("Digite sua senha: ");
            string password = Console.ReadLine();

            resposta2.Add(user);
            resposta2.Add(password);

            return resposta2;
        }
    }
}
