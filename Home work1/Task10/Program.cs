List<int> ints = new List<int>();

var random = new Random();

for (int i = 0; i < random.Next(1, 20); i++)
{
    ints.Add(random.Next(1,10));
}
foreach (var item in ints)
{
    System.Console.WriteLine(item);
}