namespace SwiftBuy.Models {
    public class Produto{
        public int id { get; set; }
        public string name { get; set; }
        public string descricao { get; set; }
        public decimal  price { get; set; }
        public string categoria {  get; set; }

        public Produto(int id, string name, string descricao, decimal price, string categoria) {
            this.id = id;
            this.name = name;
            this.descricao = descricao;
            this.price = price;
            this.categoria = categoria;
        }
    }
}
