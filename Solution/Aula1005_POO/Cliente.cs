namespace Aula1005_POO {
    class Cliente {

        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Cliente() {


        }
        

        public Cliente(string nome, string cpf) {

            this.Cpf = Cpf;
            this.Nome = nome;
        }

    }
}
