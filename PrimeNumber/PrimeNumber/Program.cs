// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("Please enter your number: ");
string num = Console.ReadLine();

int x = Convert.ToInt32(num); //convert string to integer first
int divider = 0;              // to see how many dividers a number have


for (int i = 1; i <= x; i++)
{
    int b = x % i;
    if (b == 0) {
        divider++;
    }
}


if (divider == 2)
{
    Console.WriteLine("It's a prime number");
}
else
{
    Console.WriteLine("It's not a prime number");
}





//Console.WriteLine(x.GetType());
//Console.WriteLine(x + x);

