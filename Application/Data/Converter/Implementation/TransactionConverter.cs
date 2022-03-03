using Application.Data.ValueObjects;
using Domain;

namespace Application.Data.Converter
{
    public class TransactionConverter : IParser<TransactionVo, Transaction>, IParser<Transaction, TransactionVo>
    {
        public Transaction Parse(TransactionVo originObject)
        {
            return new Transaction()
            {
                Title = originObject.Title,
                Type = originObject.Type,
                Category = originObject.Category,
                Ammount = originObject.Ammount,
                createdAt = DateTime.Now
            };
        }     

        public TransactionVo Parse(Transaction originObject)
        {
            return new TransactionVo()
            {
                Title = originObject.Title,
                Type = originObject.Type,
                Category = originObject.Category,
                Ammount = originObject.Ammount,
                createdAt = originObject.createdAt
            };
        }

        public List<TransactionVo> Parse(List<Transaction> originObject)
        {
            if (originObject == null)
                return null;
            return originObject.Select(item => Parse(item)).ToList();
        }

        public List<Transaction> Parse(List<TransactionVo> originObject)
        {
            if (originObject == null)
                return null;
            return originObject.Select(item => Parse(item)).ToList();
        }
    }
}
