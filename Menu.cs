using System;

namespace AulaProjetoLetsCode2
{
    public class Menu
    {
        Create users = new Create();
        CreateClient client = new CreateClient();

        public string GeneralMenu()
        {

            Console.WriteLine("Bem vindo ao sistema de Marketplace");
            Console.WriteLine("Digite o número da opção desejada");
            Console.WriteLine("1 - Cadastrar novo Usuário");
            Console.WriteLine("2 - Cadastrar novo Vendedor");
            Console.WriteLine("3 - Cadastrar novo Cliente");
            Console.WriteLine("4 - Listar Usuário");
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
                     Console.WriteLine("222");
                    break;
                case 3:
                    client.AddClient();
                    break;
                case 4:
                    foreach (var usuario in users.Users)
                    {
                        Console.WriteLine(usuario);
                    }
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