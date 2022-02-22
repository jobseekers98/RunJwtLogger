using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BALfile.IRepository.User
{
    public class UserBAL : IUserBAL
    {
        public Task<int> AddUser(User user)
        {
            throw new NotImplementedException();
        }
        public Task<int> DeleteUser(int? userId)
        {
            throw new NotImplementedException();
        }
        public Task<List<User>> GetUser()
        {
            throw new NotImplementedException();
        }
        public Task<User> GetUser(int? userId)
        {
            throw new NotImplementedException();
        }
        public Task UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
