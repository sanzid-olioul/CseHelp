namespace CseHelp.Services.Interfaces
{
    public interface IUnitOfWork
    {
        public IQuoteRepository Quote { get; }
        Task<bool> SaveChanges();
    }
}
