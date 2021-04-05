using System;
using MoneyManagerModel;
using System.Linq;

namespace MoneyManagerDataLayer
{
    public class CategoryControl : IControl<Category>
    {
        private ManagerContext manager;

        public CategoryControl(ManagerContext context)
        {
            manager = context;
        }

        public void Create(Category obj)
        {
            manager.Categories
                .Add(obj);

            manager.SaveChanges();
        }

        public void Delete(Category obj)
        {
            manager.Categories
                .Remove(obj);

            manager.SaveChanges();
        }

        public Category Get(int id)
        {
            return manager.Categories
                .Where(c => c.CategoryId == id)
                .FirstOrDefault();
        }

        public void Update(Category obj)
        {
            manager.Categories
                .Update(obj);

            manager.SaveChanges();
        }
    }
}
