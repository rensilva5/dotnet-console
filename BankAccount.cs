// publix is like a export
// class contyaind this to do by itself
public class BankAccount {

    public string AccountNumber {get; set;}

    public decimal Balance {get; set;} = 0;

    public BankAccount() {
        AccountNumber = "";
        Balance = 100;

        
    }

    public BankAccount(decimal newBalance) { //Argurments ( newBalance for instance)
        AccountNumber = "";    // These are constructors
        Balance = newBalance;
    }

    // this is a new...
    public void MakeDeposit(decimal amount) {
        if (amount <= 0) {
            //return;
            throw new Exception("wow");
        }
        Balance += amount;
    }
    public decimal MakeDepositGetBalance(decimal amount) {
        MakeDeposit(amount);
        return Balance;
    }


}