namespace CseHelp.Services.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        public IQuoteRepository Quote { get; }
        Task<bool> SaveChanges();
    }
}
