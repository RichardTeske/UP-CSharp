using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1005_POO {
    class Program {
        static void Main(string[] args) {

            Cliente c = new Cliente();
            Cliente c2 = new Cliente("Jucicreia","123456");

            c.Nome = "Godofredo";
            string nomeCliente = c.Nome;

            c.Cpf = "'1234567890";
            string cpfCliente = c.Cpf;

            Console.WriteLine(c.Nome);
            Console.WriteLine(c.Cpf);

            Console.ReadKey();
        }
    }
}
