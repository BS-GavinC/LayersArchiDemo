using LayersArchiDemo_DAL.Context;
using LayersArchiDemo_DAL.Entities;
using LayersArchiDemo_DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersArchiDemo_DAL.Repository
{
    public class UserRepository : IUserRepository
    {
        public User Create(User user)
        {
            user.Id = FakeDB.Users.Max(x => x.Id);

            FakeDB.Users.Add(user);

            return user;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            return FakeDB.Users;
        }

        public User? GetByEmail(string email)
        {
            return FakeDB.Users.SingleOrDefault(x => x.Email == email);
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
