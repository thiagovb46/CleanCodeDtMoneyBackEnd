using Application.Data.ValueObjects;
using Application.UsesCases.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace fiancesapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly IAddNewTransactionUseCase _addNewTransactionUseCase;
        private readonly IGetAllTransactionsUseCase _getAllTransactionsUseCase;

        public TransactionsController(IAddNewTransactionUseCase addNewTransactionUseCase, IGetAllTransactionsUseCase getAllTransactionsUseCase)
        {
            _addNewTransactionUseCase = addNewTransactionUseCase;
            _getAllTransactionsUseCase = getAllTransactionsUseCase;

        }        

        [HttpPost]
        public async Task<IActionResult> createsNewTransaction(TransactionVo newTransaction)
        {
            try
            {
                var result = await _addNewTransactionUseCase.createTransaction(newTransaction);
                return StatusCode(201, result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTransaction()
        {
            try
            {
                var result = await _getAllTransactionsUseCase.GetAll();
                return StatusCode(200, result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
