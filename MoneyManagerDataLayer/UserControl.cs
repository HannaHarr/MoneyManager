using System;
using Microsoft.EntityFrameworkCore;
using MoneyManagerModel;
using System.Linq;

namespace MoneyManagerDataLayer
{
    public class UserControl : IControl<User>
    {
        private ManagerContext manager;

        public UserControl(ManagerContext context)
        {
            manager = context;
        }

        public void Create(User obj)
        {
            manager.Users
                .Add(obj);

            manager.SaveChanges();
        }

        public void Delete(User obj)
        {
            manager.Users
                .Remove(obj);

            manager.SaveChanges();
        }

        public User Get(int id)
        {
            return manager.Users
                .Where(u => u.UserId == id)
                .FirstOrDefault();
        }

        public void Update(User obj)
        {
            manager.Users
                .Update(obj);

            manager.SaveChanges();
        }
    }
}
