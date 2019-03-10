namespace Shop.Web.Data.Repositories
{
    using Entities;
    using System.Linq;
    using System.Threading.Tasks;

    public  interface IOrderRepository : IGenericRepository<Order>

    {
        Task<IQueryable<Order>> GetOrdersAsync(string userName);
    }
}
