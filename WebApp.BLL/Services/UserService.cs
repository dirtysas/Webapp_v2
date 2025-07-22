using WebApp.DAL.Entities;
using WebApp.BLL.Services;
using WebApp.DAL.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) => _userRepository = userRepository;

        public async Task<List<User>> GetAllUsersAsync() => await _userRepository.GetAllAsync();
        public async Task<User> GetUserByIdAsync(int id) => await _userRepository.GetByIdAsync(id);
        public async Task CreateUserAsync(User user) => await _userRepository.AddAsync(user);
        public async Task UpdateUserAsync(User user) => await _userRepository.UpdateAsync(user);
        public async Task DeleteUserAsync(int id) => await _userRepository.DeleteAsync(id);
    }
}