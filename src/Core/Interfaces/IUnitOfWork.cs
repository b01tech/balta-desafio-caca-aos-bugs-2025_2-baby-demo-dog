namespace BugStore.Core.Interfaces
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
    }
}