// Задача №25

Console.Write("Enter A number: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter B number: ");
int B = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < B; i++)
    {
        break;
    }
Console.Write(Math.Pow(A, B));
Console.WriteLine(" ");

// Задача №27

Console.Write("Enter Any number: ");
int AnyNum = Convert.ToInt32(Console.ReadLine());
int Sum = 0;

while (AnyNum > 0)

    {
    Sum = Sum + AnyNum % 10;
    AnyNum = AnyNum / 10 ;
    }

Console.WriteLine("Sum of digits of your number: " + Sum);

// Задача №29

static class Program
{
private static void Main(string[] args)
{
foreach(var i in Enumerable.Range(1,10).RearrangeRandomly())
Console.WriteLine(i);
Console.ReadKey();
}
}

public static class CoolExtensions
{
static readonly Random Rnd = new Random();

public static IEnumerable<TSource> RearrangeRandomly<TSource>
(this IEnumerable<TSource> seq, Random random)
{
return seq.OrderBy(n => random.NextDouble());
}
public static IEnumerable<TSource> RearrangeRandomly<TSource>
(this IEnumerable<TSource> seq)
{
return seq.RearrangeRandomly(Rnd);
}
}