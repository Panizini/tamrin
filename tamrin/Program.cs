
while(true)
{ 
Console.WriteLine("write a number");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("write the second number");

int b = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = a; i < b; i++)
{
    sum = sum + i;
        }

Console.WriteLine(sum);
}
