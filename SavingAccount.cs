public class SavingAccount : BankAccount {

    public SavingAccount() : base()  // base is like a inheritance 
    {
        Balance = 200;
    }

    public SavingAccount(decimal amount) : base(amount) {

    }
}