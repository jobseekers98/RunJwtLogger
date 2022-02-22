using MODELfile;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DALfile.IRepository
{
     public interface IUserDal
     {
        Task<List<UserModel>> GetUserDetail(int? userId);
        Task<int> AddUpdateUser(UserModel user);
        Task<int> DeleteUser(int userId);
        Task<bool> ErrorLog(Exception ex);


    }
}
