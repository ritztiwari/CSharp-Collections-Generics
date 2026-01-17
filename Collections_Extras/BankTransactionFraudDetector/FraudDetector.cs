using System;

namespace CSharp_Advance_Collections.Collections_Extras.BankTransactionFraudDetector
{
    public class FraudDetector
    {
        private Dictionary<long, List<Transaction>> ledger
            = new Dictionary<long, List<Transaction>>();

        private Queue<Transaction> processingQueue
            = new Queue<Transaction>();

        private Dictionary<long, decimal> balances
            = new Dictionary<long, decimal>();

        // Add a transaction to system (both structures)
        public void AddTransaction(Transaction t)
        {
            processingQueue.Enqueue(t);

            if (!ledger.ContainsKey(t.AccountNo))
                ledger[t.AccountNo] = new List<Transaction>();

            ledger[t.AccountNo].Add(t);

            // Update balance immediately (important edge case)
            if (!balances.ContainsKey(t.AccountNo))
                balances[t.AccountNo] = 0;

            if (t.Type == TransactionType.Deposit)
                balances[t.AccountNo] += t.Amount;
            else
                balances[t.AccountNo] -= t.Amount;
        }

        private bool TooManyWithdrawals(long acc, DateTime currentTime)
        {
            if (!ledger.ContainsKey(acc)) return false;

            var recentWithdrawals =
                ledger[acc]
                .Where(t => t.Type == TransactionType.Withdrawal &&
                            (currentTime - t.Time).TotalMinutes <= 10) // includes exact boundary
                .ToList();

            return recentWithdrawals.Count > 3;
        }

        private bool LargeWithdrawal(long acc, decimal amount)
        {
            decimal balance = balances.ContainsKey(acc) ? balances[acc] : 0;

            // Edge case: zero balance withdrawal
            if (balance <= 0) return true;

            return amount > 0.8m * balance;
        }

        public void ProcessQueue()
        {
            Console.WriteLine("\n--- Suspicious Transaction Report ---");

            HashSet<long> flaggedAccounts = new HashSet<long>();

            while (processingQueue.Count > 0)
            {
                Transaction t = processingQueue.Dequeue();

                if (t.Type == TransactionType.Withdrawal)
                {
                    bool rule1 = TooManyWithdrawals(t.AccountNo, t.Time);
                    bool rule2 = LargeWithdrawal(t.AccountNo, t.Amount);

                    if (rule1 || rule2)
                    {
                        flaggedAccounts.Add(t.AccountNo);

                        Console.WriteLine(
                            $"Account: {t.AccountNo} | " +
                            $"Amount: {t.Amount} | Time: {t.Time:HH:mm:ss} | " +
                            $"Reason: {(rule1 ? "Too many withdrawals" : "Large withdrawal")}"
                        );
                    }
                }
            }

            Console.WriteLine("\nFlagged Accounts:");
            foreach (var acc in flaggedAccounts)
                Console.WriteLine($"Account {acc}");
        }
    }
}

