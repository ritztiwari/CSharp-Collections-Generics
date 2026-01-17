using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_Advance_Collections.Collections_Extras.BankTransactionFraudDetector
{
    public enum TransactionType
    {
        Deposit,
        Withdrawal
    }

    public class Transaction
    {
        public long AccountNo { get; set; }
        public TransactionType Type { get; set; }
        public decimal Amount { get; set; }
        public DateTime Time { get; set; }

        public Transaction(long acc, TransactionType type, decimal amt, DateTime time)
        {
            AccountNo = acc;
            Type = type;
            Amount = amt;
            Time = time;
        }
    }
}
