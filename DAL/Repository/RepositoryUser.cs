using System;
using System.Collections.Generic;
using System.Text;
using DAL.Data;
using DAL.Interface;
using DAL.Models;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class RepositoryUser : IRepository<user>
    {
        ApplicationDbContext _dbContext;

        public RepositoryUser(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<user> Create(user _object)
        {
            var obj = await _dbContext.users.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }

        public void Delete(user _object)
        {
            _dbContext.Remove(_object);
            _dbContext.SaveChanges();
        }

        public IEnumerable<user> GetAll()
        {
            try
            {
                return _dbContext.users.Where(x => x.user_isdeleted == 0).ToList();
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public user GetById(int Id)
        {
            return _dbContext.users.Where(x => x.user_isdeleted == 0 && x.user_id == Id).FirstOrDefault();
        }

        public void Update(user _object)
        {
            _dbContext.users.Update(_object);
            _dbContext.SaveChanges();
        }
    }
}
