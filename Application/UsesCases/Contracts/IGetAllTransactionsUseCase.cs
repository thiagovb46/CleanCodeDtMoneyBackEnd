using Application.Data.ValueObjects;

namespace Application.UsesCases.Contracts
{
    public interface IGetAllTransactionsUseCase
    {
        public Task<List<TransactionVo>> GetAll();
    }
}
