using prj_LTTQ_BTL.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_LTTQ_BTL.Services
{
    internal class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public void CreateUser(Guid id, string username, string password, string roleName)
        {
            _userRepository.CreateUser(id, username, password, roleName);
        }

        public DataRow GetUserById(Guid id)
        {
            return _userRepository.GetUserById(id);
        }
        public DataTable GetAllUsersJoin(int page, int pageSize)
        {
            return _userRepository.GetAllUserJoin(page, pageSize);
        }
        public DataTable GetAllUsers(int page, int pageSize)
        {
            return _userRepository.GetAllUsers(page, pageSize);
        }

        public void UpdateUser(Guid id, string username, string password, string roleName)
        {
            _userRepository.UpdateUser(id, username, password, roleName);
        }

        public void DeleteUser(Guid id)
        {
            _userRepository.DeleteUser(id);
        }

        public DataRow GetUserByUsername(string username)
        {
            return _userRepository.GetUserByUsername(username);
        }
        public DataTable SearchUsers(string keywword)
        {
            return _userRepository.SearchUsers(keywword);
        }
    }
}
