using Domain;
using Domain.IRepositories;
using Infrascruture.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrascruture.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly DataContext _context;

        public TransactionRepository(DataContext context)
        {
            _context = context;

        }
        public async Task<Transaction> CreatesNew(Transaction newTransaction)
        {
            try 
            {
                await _context.AddAsync(newTransaction);
                _context.SaveChanges();
                return newTransaction;
            } 
            catch (Exception e)
            {
                throw e;
            }
            
        }

        public async Task<List<Transaction>> GetAll()
        {
            var transactions = await _context.Transactions.ToListAsync();
            return transactions;
        }
    }
}
