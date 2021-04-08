using System;
using MoneyManagerModel;
using System.Linq;

namespace MoneyManagerDataLayer
{
    public class AssetControl : IControl<Asset>
    {
        private ManagerContext manager;

        public AssetControl(ManagerContext context)
        {
            manager = context;
        }

        public void Create(Asset obj)
        {
            manager.Assets
                .Add(obj);

            manager.SaveChanges();
        }

        public void Delete(Asset obj)
        {
            manager.Assets
                .Remove(obj);

            manager.SaveChanges();
        }

        public Asset Get(int id)
        {
            return manager.Assets
                .Where(a => a.AssetId == id)
                .FirstOrDefault();
        }

        public void Update(Asset obj)
        {
            manager.Assets
                .Update(obj);

            manager.SaveChanges();
        }
    }
}
