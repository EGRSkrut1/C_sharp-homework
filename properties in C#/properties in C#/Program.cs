public class Bank_account
{
    private string account_number;
    private double balance;
    public string Account_number { get { return account_number; } private set { account_number = value; } }
    public string Owner { get; set; }
    public double Balance { get { return balance; } }
    public Bank_account(string Account_number, string owner, double Initial_balance = 0)
    {
        account_number = Account_number;
        Owner = owner;
        balance = Initial_balance;
    }
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount}. New balance: {balance}");
        }
        else Console.WriteLine("Invalid deposit amount.");
    }
    public void Withdraw(double amount)
    {
        if (amount > 0 && balance >= amount)
        {
            balance -= amount;
            Console.WriteLine($"Withdrew {amount}. New balance: {balance}");
        }
        else Console.WriteLine("Insufficient funds or invalid withdrawal amount.");
    }
    public void Display_account_info() { Console.WriteLine($"Account Number: {Account_number}\n Owner: {Owner}\n Balance: {Balance}"); }
}
public class Program
{
    public static void Main()
    {
        Bank_account account = new Bank_account("1", "a", 1);
        account.Display_account_info();
        account.Deposit(500);
        account.Withdraw(200);
        account.Display_account_info();
    }
}