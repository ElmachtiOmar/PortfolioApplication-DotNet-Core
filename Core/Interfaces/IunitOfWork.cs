namespace Core.Interfaces
{
    public interface IunitOfWork<T> where T : class
    {
        IGenericRepository<T> Entity { get; }

        void Save();
    }
}
