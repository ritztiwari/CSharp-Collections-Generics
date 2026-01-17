using System;

namespace CSharp_Advance_Collections.Collections_Extras.BankTransactionFraudDetector
{
    internal class FraudMain
    {
        internal static void Execute()
        {
            FraudDetector system = new FraudDetector();

            DateTime baseTime = DateTime.Now;

            // Initial deposits
            system.AddTransaction(new Transaction(1001, TransactionType.Deposit, 10000, baseTime));

            // Multiple withdrawals within 10 minutes
            system.AddTransaction(new Transaction(1001, TransactionType.Withdrawal, 500, baseTime.AddMinutes(1)));
            system.AddTransaction(new Transaction(1001, TransactionType.Withdrawal, 600, baseTime.AddMinutes(2)));
            system.AddTransaction(new Transaction(1001, TransactionType.Withdrawal, 700, baseTime.AddMinutes(3)));
            system.AddTransaction(new Transaction(1001, TransactionType.Withdrawal, 800, baseTime.AddMinutes(9))); // triggers rule 1

            // Large withdrawal (>80% balance)
            system.AddTransaction(new Transaction(1002, TransactionType.Deposit, 5000, baseTime));
            system.AddTransaction(new Transaction(1002, TransactionType.Withdrawal, 4500, baseTime.AddMinutes(5)));

            // Zero balance edge case
            system.AddTransaction(new Transaction(1003, TransactionType.Withdrawal, 100, baseTime));

            // Same timestamp transactions
            system.AddTransaction(new Transaction(1004, TransactionType.Deposit, 2000, baseTime));
            system.AddTransaction(new Transaction(1004, TransactionType.Withdrawal, 500, baseTime));
            system.AddTransaction(new Transaction(1004, TransactionType.Withdrawal, 600, baseTime));

            system.ProcessQueue();
        }
    }
}