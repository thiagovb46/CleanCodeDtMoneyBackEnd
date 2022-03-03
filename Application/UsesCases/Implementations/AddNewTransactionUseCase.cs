using Application.Data.Converter;
using Application.Data.ValueObjects;
using Application.UsesCases.Contracts;
using Domain.IRepositories;

namespace Application.UsesCases
{
    public class AddNewTransactionUseCase : IAddNewTransactionUseCase
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly TransactionConverter _transactionConverter;

        public AddNewTransactionUseCase(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
            _transactionConverter = new TransactionConverter();
        }
        public  async Task<TransactionVo> createTransaction(TransactionVo newTransaction)
        {
            var  transaction = _transactionConverter.Parse(newTransaction);
            var createdTransaction = await _transactionRepository.CreatesNew(transaction);
            return _transactionConverter.Parse(createdTransaction);
        }
    }
}

