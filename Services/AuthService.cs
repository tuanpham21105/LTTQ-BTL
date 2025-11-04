using prj_LTTQ_BTL.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_LTTQ_BTL.Services
{
    internal class AuthService
    {
        private UserRepository _userRepository;
        public AuthService()
        {
            _userRepository = new UserRepository();
        }
        public DataTable AuthenticateUser(string username, string password)
        {
            try
            {
                DataTable user = _userRepository.GetUserByUsernameAndPassword(username, password);
                if (user != null)
                {
                    return user;
                }
                return null;
            }
            catch(Exception ex)
            {
                throw new Exception($"Lỗi đăng nhập:{ex.Message}");
            }
        }
    }
}
