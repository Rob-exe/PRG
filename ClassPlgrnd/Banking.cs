using System.Collections;

namespace ClassPlayground
{
	class BankAccount
	{
		int accountNumber;
		string holderName;
		string currency;
		int balance;
		Random rng = new Random();
		public BankAccount(string holderName, string currency){
			this.accountNumber = rng.Next(100000000,1000000000);
			this.holderName = holderName;
			this.currency = currency;
			this.balance = 0;
		}
		public void Deposit(int amount){
			balance = balance + amount;
		}
		public int Withdraw(int amount){
			if (balance < amount)
			{
				Console.WriteLine("Unable to withdraw, low balance.")
				return 0;
			} else {
				balance -= amount;
				return amount;
			}
		}
		public static void Transfer(int amount, BankAccount accountNumberFrom, BankAccount accountNumberTo) {
			int amountWithdrawn = accountNumberFrom.Withdraw(amount);
			if (amountWithdrawn == amount)
			{
				accountNumberTo.Deposit(amount);
			} else {
				Console.WriteLine("Deposit unsuccessful");
			}
		}
	}
}