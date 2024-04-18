namespace BankAccount;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public class BankAccount()
{
    private int accountNumber;
    private int accountHolderID;
    private int balance;
    private bool isActive;
    private int openedDate;

    public int AccountNumber { get; set; }
    public int AccountHolderID { get; set; }
    public int Balance { get; set; }
    public bool IsActive { get; set; }
    public int OpenDate { get; set; }

    public static void Deposit() { }
    public static void Withdraw() { }

}
