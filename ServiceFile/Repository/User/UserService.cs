using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DALfile.IRepository;
using MODELfile;
using Servicefile.IRepository.IUser;

namespace Servicefile.Repository.User
{
    public class UserService : IUserService
    {
        private readonly IUserDal _userDal;
        public UserService(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public async Task<List<UserModel>> GetUserDetail(int? userId)
        {
            return await _userDal.GetUserDetail(userId);
        }
        public async Task<int> AddUpdateUser(UserModel user)
        {
            return await _userDal.AddUpdateUser(user);
        }
        public async Task<int> DeleteUser(int userId)
        {
            return await _userDal.DeleteUser(userId);
        }
        public async Task<bool> ErrorLog(Exception ex)
        {
            return await _userDal.ErrorLog(ex);
        }

    }
}
