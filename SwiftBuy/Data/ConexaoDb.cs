using Npgsql;

namespace SwiftBuy.Data {
    public class ConexaoDb : IDisposable{
        public NpgsqlConnection connection {  get ; set ; }

        public ConexaoDb(){
            connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=swiftbuy;User Id=postgres;Password=Mikio123");
            connection.Open();
        }

        public void Dispose() {
            connection.Dispose();
        }
    }
}
