using Application.Data.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UsesCases.Contracts
{
    public interface IAddNewTransactionUseCase
    {
        public Task <TransactionVo> createTransaction(TransactionVo newTransaction);
        
    }
}
