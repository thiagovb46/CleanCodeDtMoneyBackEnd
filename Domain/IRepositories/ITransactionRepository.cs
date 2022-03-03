namespace Domain.IRepositories
{
    public interface ITransactionRepository
    {
        public Task<Transaction> CreatesNew(Transaction newTransaction);
        public Task <List<Transaction>> GetAll();
    }
}
