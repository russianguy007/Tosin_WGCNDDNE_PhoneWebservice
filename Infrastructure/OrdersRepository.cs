using Tosin_WGCNDDNE_WebServices.Domain;

namespace Tosin_WGCNDDNE_WebServices.Infrastructure
{
    public class OrdersRepository : RepositoryBase
    {
        public OrdersRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public int Insert(Order order)
        {
            if (order == null)
                throw new ArgumentNullException(nameof(order));

            var id = int.id;

            this.ExecSql($"INSERT INTO Order (id, phone_id, buyer, date) VALUES ('{id}',{order.Phoneid},'{order.Buyer}','{order.Date}')");

            return id;
        }

        public Order[] GetAll() => this.GetData<Order, OrdersMappingService>("SELECT * FROM Orders");

        public Order[] GetAllWithFilter(int phoneid) => this.GetData<Order, OrdersMappingService>($"SELECT * FROM Orders WHERE phoneid={phoneid}");
    }
}
