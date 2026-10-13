using System.Text;
using Bogus;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("Hello, World!");

Console.Write("\n>>> Введіть кількість імен: ");
int count = int.Parse(Console.ReadLine()!);

string[] myArray = new string[count];

for (int i = 0; i < count; i++)
{
    Faker myFaker = new Faker("uk");
    myArray[i] = myFaker.Name.FullName() + "\ttel:" + myFaker.Phone.PhoneNumber();
}

Console.WriteLine("\n>>> Масив імен до сортування:");
foreach (string name in myArray)
{
    Console.WriteLine(name);
}

for (int i = 0; i < count - 1; i++)
{
    for (int j = i + 1; j < count; j++)
    {
        if (string.Compare(myArray[i], myArray[j], StringComparison.CurrentCulture) > 0)
        {
            string temp = myArray[i];
            myArray[i] = myArray[j];
            myArray[j] = temp;
        }
    }
}

Console.WriteLine("\n>>> Масив імен після сортування:");
foreach (string item in myArray)
{
    Console.WriteLine(item);
}

Console.WriteLine();