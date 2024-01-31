List<int> ints = new List<int>(){1,2,3,4,5};

List<int> ints2 = new List<int>(){1,2,3,4,5};

foreach (var item in ints)
{
    foreach (var item1 in ints2)
    {
        if(item == item1)
        {
            System.Console.WriteLine(true);
            return;
        }   
        else
        {
            System.Console.WriteLine(false);
        }

    }

}