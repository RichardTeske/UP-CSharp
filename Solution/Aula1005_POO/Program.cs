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
            Cliente c3 = new Cliente("Jubileu", "111111111");

            c.Nome = "Godofredo";
            string nomeCliente = c.Nome;

            c.Cpf = "1234567890";
            string cpfCliente = c.Cpf;

            c3.DataNasc = new DateTime(1998, 01, 02);

            Console.WriteLine(c.Nome);
            Console.WriteLine(c.Cpf);

            Console.WriteLine(c3.Nome+ "Nasceu em: "+c3.DataNasc);

            Console.ReadKey();
            

        }
    }
}
