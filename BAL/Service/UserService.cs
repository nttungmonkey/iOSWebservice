using System;
using System.Collections.Generic;
using DAL.Interface;
using DAL.Models;
using System.Linq;
using System.Threading.Tasks;

namespace BAL.Service
{
    public class UserService
    {
        private readonly IRepository<user> _user;

        public UserService(IRepository<user> user)
        {
            _user = user;
        }

        //Get User Details By Person Id  
        public IEnumerable<user> GetPersonByUserId(int UserId)
        {
            return _user.GetAll().Where(x => x.user_id == UserId).ToList();
        }

        //GET All User Details   
        public IEnumerable<user> GetAllUsers()
        {
            try
            {
                return _user.GetAll().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Get User by  UserName  
        public user GetUserByUserName(string UserName)
        {
            return _user.GetAll().Where(x => x.user_username == UserName).FirstOrDefault();
        }

        //Add User  
        public async Task<user> AddUser(user user)
        {
            return await _user.Create(user);
        }
        //Delete User   
        public bool DeleteUser(int UserId)
        {

            try
            {
                var DataList = _user.GetAll().Where(x => x.user_id == UserId).ToList();
                foreach (var item in DataList)
                {
                    _user.Delete(item);
                }
                return true;
            }
            catch (Exception)
            {
                return true;
            }

        }

        //Update User Details  
        public bool UpdateUser(user user)
        {
            try
            {
                var DataList = _user.GetAll().Where(x => x.user_isdeleted != 0).ToList();
                foreach (var item in DataList)
                {
                    _user.Update(item);
                }
                return true;
            }
            catch (Exception)
            {
                return true;
            }
        }
    }
}
