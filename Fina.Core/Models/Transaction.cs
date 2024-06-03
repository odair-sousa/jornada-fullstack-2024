using Fina.Core.Enums;

namespace Fina.Core.Models
{
    //Registros de transação
    public class Transaction
    {
        public long Id { get; set; }
        public string Title { get; set; } = string.Empty;
        
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime? PaidOrReciveAt { get; set; }

        public ETransactionType Type { get; set; } = ETransactionType.Withdraw;

        public long CategoryId { get; set; }
        public Category Category { get; set; }

        public string UserId { get; set; } = string.Empty;

    }
}