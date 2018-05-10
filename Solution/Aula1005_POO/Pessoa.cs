namespace Aula1005_POO {
    abstract class Pessoa {

        public string Nome { get; set; }
        public string Cpf { get; set; }


        public Pessoa() {


        }

        public Pessoa(string nome, string cpf) {

            this.Cpf = Cpf;
            this.Nome = nome;
        }

    }
}
