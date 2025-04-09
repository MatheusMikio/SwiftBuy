namespace SwiftBuy.Models {
    public class Usuario {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public string cpf  { get; set; }
        public List<Produto> carrinho = new();

        public Usuario(string name, string email, string password, string phone, string cpf){
            this.name = name;
            this.email = email;
            this.password = password;
            this.phone = phone;
            this.cpf = cpf;
        }
    }
}
