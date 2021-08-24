using System;

namespace AulaProjetoLetsCode2
{
    public class Seller : User
    {
        public override string ToString()
        {
            return $"| Nome: {name} | User: {user} |\n\n";
        }
    }
}