using WebApp.DAL.Entities;
using WebApp.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApp.DAL.Context;


namespace WebApp.DAL.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;

        public OrderRepository(AppDbContext context) => _context = context;

        public async Task<List<Order>> GetAllAsync() => await _context.Orders.Include(o => o.User).ToListAsync();
        public async Task<Order> GetByIdAsync(int id) => await _context.Orders.Include(o => o.User).FirstOrDefaultAsync(o => o.Id == id);
        public async Task AddAsync(Order order) { await _context.Orders.AddAsync(order); await _context.SaveChangesAsync(); }
        public async Task UpdateAsync(Order order) { _context.Orders.Update(order); await _context.SaveChangesAsync(); }
        public async Task DeleteAsync(int id) { var order = await _context.Orders.FindAsync(id); _context.Orders.Remove(order); await _context.SaveChangesAsync(); }
    }
}