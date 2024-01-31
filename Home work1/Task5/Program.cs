List<string> strings = new List<string>(){"Mustafo","Barotov","Salom","Alec"};
var str = strings.GetRange(0,2);
foreach (var item in str)
{
    System.Console.WriteLine(item);
}