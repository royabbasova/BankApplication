using System;

string password = "1234";
decimal balance = 1000;

const decimal usd = 1.7m;

repeat: 

Console.Write("Enter your password: ");

string enter_pass = Console.ReadLine();

if (enter_pass.Equals(password))
{
repeatOperation:

    Console.Clear();
    Console.Write("Show balance: 1 \n" +
                      "Cashing out: 2 \n" +
                      "Adding: 3 \n" +
                      "Exit: 4 \n" +
                      "Select the operation number: ");

    string select = Console.ReadLine();

    if (select == "1")
    {
        Console.Clear();
        Console.Write($"Your Balance is: {balance} \n");

        Console.Write("Do you want to continue? Yes or Not: ");

        string cashSelect = Console.ReadLine();

        if (cashSelect == "yes")
        {
            goto repeatOperation;
        }
        else if (cashSelect == "not")
        {
            Console.WriteLine("Goodbye");

            Environment.Exit(0);
        }
    }

    else if (select == "2")
    {
        Console.Clear();
        repeatCash:

        Console.Write($"Your balance: {balance} \n" +
                       "Cashing money: ");
        decimal cashMoney = Convert.ToDecimal(Console.ReadLine());

        repeatCurrency:
        Console.WriteLine("Select currency: \n" +
                          "AZN: 1 \n" +
                          "USD: 2");

        string currency = Console.ReadLine();

        decimal currencyAmount = 0;

        if (currency.Equals("1"))
        {
            currencyAmount = cashMoney;
        }
        else if (currency.Equals("2"))
        {
            currencyAmount = cashMoney * usd;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Select the correct currency!");
            Console.ReadLine();

            goto repeatCurrency;
        }

        if (currencyAmount > balance)
        {
            Console.Clear();
            Console.WriteLine("Yetersiz bakiye!");

            Console.Write("Do you want to continue? Yes or Not: ");

            string cashSelect = Console.ReadLine();

            if (cashSelect == "yes")
            {
                goto repeatCash;
            }
            else if (cashSelect == "not")
            {
                Console.WriteLine("Goodbye");

                Environment.Exit(0);
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Operation completed successfully! \n" +
                             $"Your new balance is: {balance - currencyAmount}");

            Console.Write("Do you want to continue? Yes or Not: ");

            string cashSelect = Console.ReadLine();

            if (cashSelect == "yes")
            {
                goto repeatOperation;
            }
            else if (cashSelect == "not")
            {
                Console.WriteLine("Goodbye");

                Environment.Exit(0);
            }
        }
    }

    else if (select == "3")
    {
        Console.Clear();
        Console.Write("Add money: ");
        decimal addMoney = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine($"Your new balance is: {balance + addMoney}");

        Console.Write("Do you want to continue? Yes or Not: ");

        string cashSelect = Console.ReadLine();

        if (cashSelect == "yes")
        {
            goto repeatOperation;
        }
        else if (cashSelect == "not")
        {
            Console.WriteLine("Goodbye");

            Environment.Exit(0);
        }
    }

    else if (select == "4")
    {
        Console.Clear();
        Console.WriteLine("Goodbye");
        Console.ReadLine();

        Environment.Exit(0);
    }
    
    else
    {
        Console.Clear();
        Console.Write("Select the correct operation number!");
        Console.ReadLine();

        goto repeatOperation;
        
    }
}
else
{
    Console.Clear();
    Console.WriteLine("Password is incorrect");
    goto repeat;
}

Console.ReadLine();


