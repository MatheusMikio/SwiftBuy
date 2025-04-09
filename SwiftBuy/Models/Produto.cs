namespace SwiftBuy.Models {
    public class Produto{
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }
        public string categoria {  get; set; }

        public Produto(int id, string name, string descricao, decimal price, string categoria) {
            this.id = id;
            this.nome = name;
            this.descricao = descricao;
            this.preco = price;
            this.categoria = categoria;
        }
    }
}
