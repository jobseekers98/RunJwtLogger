using MODELfile;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Servicefile.IRepository.IUser
{
    public interface IUserService
    {
        Task<List<UserModel>> GetUserDetail(int? userId);
        Task<int> AddUpdateUser(UserModel user);
        Task<int> DeleteUser(int userId);
        Task<bool> ErrorLog(Exception ex);
    }
}
