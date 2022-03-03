using Application.Data.Converter;
using Application.Data.ValueObjects;
using Application.UsesCases.Contracts;
using Domain.IRepositories;

namespace Application.UsesCases
{
    public class GetAllTransactionsUseCase : IGetAllTransactionsUseCase
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly TransactionConverter _transactionConverter;

        public GetAllTransactionsUseCase(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
            _transactionConverter = new TransactionConverter();
        }
        public async Task<List<TransactionVo>> GetAll()
        {
            var listOfAllTransactions = await _transactionRepository.GetAll();
            return _transactionConverter.Parse(listOfAllTransactions);
        }
    }
}
