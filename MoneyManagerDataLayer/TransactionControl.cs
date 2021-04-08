using System;
using MoneyManagerModel;
using System.Linq;

namespace MoneyManagerDataLayer
{
    public class TransactionControl : IControl<Transaction>
    {
        private ManagerContext manager;

        public TransactionControl(ManagerContext context)
        {
            manager = context;
        }

        public void Create(Transaction obj)
        {
            manager.Transactions
                .Add(obj);

            manager.SaveChanges();
        }

        public void Delete(Transaction obj)
        {
            manager.Transactions
                .Remove(obj);

            manager.SaveChanges();
        }

        public Transaction Get(int id)
        {
            return manager.Transactions
                .Where(t => t.TransactionId == id)
                .FirstOrDefault();
        }

        public void Update(Transaction obj)
        {
            manager.Transactions
                .Update(obj);

            manager.SaveChanges();
        }
    }
}
