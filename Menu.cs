using System;

namespace AulaProjetoLetsCode2
{
    public class Menu
    {
        Create users = new Create();

        public string GeneralMenu()
        {

            Console.WriteLine("Bem vindo ao sistema de Marketplace");
            Console.WriteLine("Digite o número da opção desejada");
            Console.WriteLine("1 - Cadastrar novo Usuário");
            Console.WriteLine("2 - Cadastrar novo Vendedor");
            Console.WriteLine("3 - Cadastrar novo Cliente");
            Console.WriteLine("4 - Listar Usuário");
            Console.WriteLine("5 - Listar Vendedor");
            Console.WriteLine("6 - Listar Clientes");
            Console.WriteLine("7 - Sair");
            Console.Write("Opção: ");           
            return Console.ReadLine();

        }
        public void Option(int _option)
        {
            switch (_option)
            {
                case 1:
                    users.AddUser();
                    GeneralMenuOption();
                    break;
                case 2:
                    users.AddSeller();
                    GeneralMenuOption();
                    break;
                case 3:
                    users.AddClient();
                    GeneralMenuOption();
                    break;
                case 4:
                    Console.WriteLine("   LISTA DE USUÁRIOS CADASTRADOS  \n");
                    foreach (var usuario in users.Users)
                    {
                        Console.WriteLine(usuario);
                    }
                    GeneralMenuOption();
                    break;
                case 5:
                    Console.WriteLine("   LISTA DE VENDEDORES CADASTRADOS  \n");
                    foreach (var usuario in users.Sellers)
                    {
                        Console.WriteLine(usuario);
                    }
                    GeneralMenuOption();
                    break;
                case 6:
                    Console.WriteLine("   LISTA DE CLIENTES CADASTRADOS  \n");
                    foreach (var usuario in users.Clients)
                    {
                        Console.WriteLine(usuario);
                    }
                    GeneralMenuOption();
                    break;
                case 7:
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    GeneralMenuOption();
                    break;
            }
        }

        public void GeneralMenuOption()
        {
            string _option = GeneralMenu();
            int _optionInt;
            bool _optionToInt = Int32.TryParse(_option, out _optionInt);
            if(_optionToInt)
                Option(_optionInt);
            else
            {
                Option(0);
            }
        }
    }
}