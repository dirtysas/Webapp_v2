using WebApp.DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.DAL.Repositories
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetAllAsync();
        Task<Order> GetByIdAsync(int id);
        Task AddAsync(Order order);
        Task UpdateAsync(Order order);
        Task DeleteAsync(int id);
    }
}