using System.Collections.Generic;
using System.Threading.Tasks;

namespace BALfile.IRepository.User
{
     public interface IUserBAL
     {
        Task<List<User>> GetUser();
        Task<User> GetUser(int? userId);
        Task<int> AddUser(User user);
        Task<int> DeleteUser(int? userId);
        Task UpdateUser(User user);
    }
}
