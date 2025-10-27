namespace src.Core.Interfaces
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
    }
}