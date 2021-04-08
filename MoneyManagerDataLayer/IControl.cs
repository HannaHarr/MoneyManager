namespace MoneyManagerDataLayer
{
    public interface IControl<T>
    {
        void Create(T obj);

        void Update(T obj);

        void Delete(T obj);

        T Get(int id);
    }
}
