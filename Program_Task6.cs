Console.Write("Enter a number: ");
string number = Console.ReadLine();
int number1 = Int32.Parse(number);

if(number1 % 2 == 0)
{
    Console.WriteLine("The number is even");    
}
else
{
    Console.WriteLine("The number is odd");    
}