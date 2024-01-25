using System.Security.Principal;

namespace BankEncapsulation;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to DSW International Bank!");
        Console.WriteLine();
        Console.WriteLine("If you have an account with us, press \'1\'.");
        Console.WriteLine("If you'd like to open an account, press \'2\'.");
        Console.WriteLine("To exit, press \'3\'.");
        char input1 = ValidateInput(UserInput(), '1', '2', '3');
        Console.WriteLine();

        if (input1 == '1')
        {
            Console.WriteLine("Unfortunately I don't know how to retrieve your account information yet!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
        else if (input1 == '2')
        {
            BankAccount account = CreateBankAccount();

            Console.WriteLine("Is there anything else we can help you with today?");
            Console.WriteLine();
            char input2 = AccountActivity(account);
            Console.WriteLine();

            while (input2 == '1' || input2 == '2' || input2 == '3')
            {
                if (input2 == '1')
                {
                    Console.WriteLine("How much would you like to deposit?");
                    double deposit = GetAmount();
                    account.Deposit(deposit);
                    Console.WriteLine();
                    Console.WriteLine($"We have deposited ${deposit} into your account.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Is there anything else we can help you with today?");
                    Console.WriteLine();
                    input2 = AccountActivity(account);
                }
                else if (input2 == '2')
                {
                    Console.WriteLine();
                    Console.WriteLine("How much would you like to withdraw?");
                    double withdrawal = GetAmount();
                    account.Withdraw(withdrawal);
                    Console.WriteLine();
                    Console.WriteLine($"We are dispensing ${withdrawal} from your account.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Is there anything else we can help you with today?");
                    Console.WriteLine();
                    input2 = AccountActivity(account);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Your current balance is: {account.GetBalance()}");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Is there anything else we can help you with today?");
                    Console.WriteLine();
                    input2 = AccountActivity(account);
                }
            }
        }
    }

    static char UserInput()
    {
        char userInput;
        while (!char.TryParse(Console.ReadLine(), out userInput))
        {
            Console.WriteLine("I'm sorry, I don't understand. Please try again: ");
        }
        return userInput;
    }

    static char ValidateInput(char entry, char a, char b)
    {
        bool isValidEntry = entry == a || entry == b;
        if (isValidEntry)
        {
            return entry;
        }
        else
        {
            char userInput;
            do
            {
                Console.WriteLine("Invalid entry. Please try again: ");
                userInput = UserInput();
                isValidEntry = userInput == a || userInput == b;
            } while (!isValidEntry);
            return userInput;
        }
    }

    static char ValidateInput(char entry, char a, char b, char c)
    {
        bool isValidEntry = entry == a || entry == b || entry == c;
        if (isValidEntry)
        {
            return entry;
        }
        else
        {
            char userInput;
            do
            {
                Console.WriteLine("Invalid entry. Please try again: ");
                userInput = UserInput();
                isValidEntry = userInput == a || userInput == b || userInput == c;
            } while (!isValidEntry);
            return userInput;
        }
    }

    static char ValidateInput(char entry, char a, char b, char c, char d)
    {
        bool isValidEntry = entry == a || entry == b || entry == c || entry == d;
        if (isValidEntry)
        {
            return entry;
        }
        else
        {
            char userInput;
            do
            {
                Console.WriteLine("Invalid entry. Please try again: ");
                userInput = UserInput();
                isValidEntry = userInput == a || userInput == b || userInput == c || userInput == d;
            } while (!isValidEntry);
            return userInput;
        }
    }

    static BankAccount CreateBankAccount()
    {
        BankAccount newAccount = new BankAccount();
        Console.WriteLine("Please enter your personal information below.");
        Console.Write("First name: ");
        newAccount.FirstName = Console.ReadLine();
        Console.Write("Last name: ");
        newAccount.LastName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Your account has been created!");
        Console.WriteLine($"Account number: {newAccount.GetAccountNumber()}");
        Console.WriteLine("Please write this down and save it in a safe place.");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue.");
        Console.ReadLine();
        Console.WriteLine();
        return newAccount;
    }

    static char AccountActivity()
    {
        Console.WriteLine("To make a deposit, press \'1\'.");
        Console.WriteLine("To make a withdrawal, press \'2\'.");
        Console.WriteLine("To view your current balance, press \'3\'.");
        Console.WriteLine("If nothing else, press \'4\' to exit.");
        char input = ValidateInput(UserInput(), '1', '2', '3', '4');
        return input;
    }

    static char AccountActivity(BankAccount a)
    {
        Console.WriteLine("To make a deposit, press \'1\'.");
        Console.WriteLine("To make a withdrawal, press \'2\'.");
        Console.WriteLine("To view your current balance, press \'3\'.");
        Console.WriteLine("If nothing else, press \'4\' to exit.");
        char input = ValidateInput(UserInput(), '1', '2', '3', '4');
        return input;
    }

    static double GetAmount()
    {
        bool isDouble = double.TryParse(Console.ReadLine(), out double amount);
        if (isDouble)
        {
            return amount;
        }
        else
        {
            do
            {
                Console.WriteLine("Invalid entry. Please try again:");
                isDouble = double.TryParse(Console.ReadLine(), out amount);
            } while (!isDouble);
            return amount;
        }
    }
}

