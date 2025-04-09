namespace SwiftBuy.Models {
    public class Usuario {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string telefone { get; set; }
        public string cpf  { get; set; }
        public List<Produto> carrinho = new();

        public Usuario(string name, string email, string password, string phone, string cpf){
            this.nome = name;
            this.email = email;
            this.senha = password;
            this.telefone = phone;
            this.cpf = cpf;
        }

    }
}
