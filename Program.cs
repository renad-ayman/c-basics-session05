using System;

//Qustion 1
double[] prices = { 25.5, 40.0, 33.75 };
Console.WriteLine("Prices of item 2: " + prices[1]);

//Question 2
int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
Console.WriteLine("Number of copies on shelf 2, row 1: " + shelfCopies[1, 0]);

//Question 3
static void PrintWelcomeMessage()
{
    Console.WriteLine("Welcome to the Library!");
}
PrintWelcomeMessage();

//Question 4
static void PrintBookTitle(string title)
{
    Console.WriteLine("Book Title: " + title);
}
PrintBookTitle("Clean Code");

//Question 5
// Answer: The value of pages will not change after calling the AddBonusPages method because the method takes an integer parameter, which is a value type in C#. When you pass a value type to a method, a copy of the value is made, and any changes made to that copy do not affect the original variable. Therefore, the original pages variable remains unchanged after the method call.
static void AddBonusPages(int pages)
{
    int bonusPages = pages + 50;
}
int pages = 400;
AddBonusPages(pages);
Console.WriteLine("Total pages after bonus: " + (pages));

//Question 6
//Answer: The value of prices[0] will change after calling the ApplyDiscount method because the method takes an array parameter, which is a reference type in C#. When you pass a reference type to a method, you are passing a reference to the original object, not a copy. Therefore, any changes made to the array within the method will affect the original array.
static void ApplyDiscount(double[] prices)
{
    prices[0] = prices[0] - 5;
}
double[] Prices = { 25.5, 40.0 };
ApplyDiscount(Prices);
Console.WriteLine("Price after discount: " + Prices[0]);

//Question 7
//Answer: The value of pages will change after calling the AddBonusPagesByRef method because the method takes an integer parameter by reference using the ref keyword. When you pass a parameter by reference, you are passing a reference to the original variable, allowing the method to modify its value directly. Therefore, any changes made to the pages parameter within the method will affect the original variable.
static void AddBonusPagesByRef(ref int pages)
{
    pages = pages + 50;
}

int Pages = 400;

AddBonusPagesByRef(ref Pages);

Console.WriteLine(Pages);

//Question 8
//Answer: ref allows the method to replace the original array with a completely new array. The new array contains 3 elements.
static void ReplaceArray(ref double[] prices)
{
    prices = new double[] { 10, 12.5, 15 };
}

double[] price = { 25.5, 40.0, 33.75 };

ReplaceArray(ref prices);

Console.WriteLine(prices.Length);

//Question 9
static bool TryGetPrice(string title, out double price)
{
    if (title == "Clean Code")
    {
        price = 25.5;
        return true;
    }
    else
    {
        price = 0;
        return false;
    }
}

if (TryGetPrice("Clean Code", out double Price))
{
    Console.WriteLine(Price);
}

//Question 10
static void PrintBookInfo(string title, int pages = 300)
{
    Console.WriteLine("Title: " + title);
    Console.WriteLine("Pages: " + pages);
}

PrintBookInfo("Clean Code");

PrintBookInfo("The Pragmatic Programmer", 400);

//Question 11
PrintBookInfo(pages: 450, title: "Clean Code");

//Question 12
static void PrintAllTitles(params string[] titles)
{
    foreach (string title in titles)
    {
        Console.WriteLine(title);
    }
}

PrintAllTitles("Clean Code", "The Pragmatic Programmer", "Refactoring");