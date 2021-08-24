using System;
using System.Linq;
using System.Collections.Generic;


namespace AulaProjetoLetsCode2
{
    public class Client : User
    {
        public override string ToString()
        {
            return $"| Nome: {name} | User: {user} |\n\n";
        }
    }
}