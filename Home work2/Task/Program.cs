var employees = new List<Employee>()
{
    new Employee()
    {
        Id = 1,
        FirstName = "Alijon",
        LastName = "Zabirov",
        Age = 24,
        PhoneNumber = "881667007",
        Salary = 4000
    },
    new Employee()
    {
        Id = 2,
        FirstName = "Nurullo",
        LastName = "Sulaymonov",
        Age = 30,
        PhoneNumber = "908765432",
        Salary = 8000
    },
    new Employee()
    {
        Id = 3,
        FirstName = "Shodmon",
        LastName = "Inoyatzoda",
        Age = 26,
        PhoneNumber = "987009988",
        Salary = 7800
    },
};

//Section 3
var newList1 = new List<Employee>{
    new Employee {
        Id = 4,
        FirstName = "Mustafo",
        LastName = "Barotov",
        Age = 16,
        PhoneNumber = "918757367",
        Salary = 10000
    },
     new Employee{
        Id = 5,
        FirstName = "Yusuf",
        LastName = "Mirzoev",
        Age = 15,
        PhoneNumber = "90990983",
        Salary = 3000
    },
};
employees.AddRange(newList1);
foreach (var item in employees)
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.Age);
    System.Console.WriteLine(item.Salary);
    System.Console.WriteLine("-------------------------");
}
System.Console.WriteLine("***************************");


//Section 4
List<Employee> sortedList = employees.OrderBy(e => e.Salary).ToList();
foreach (var item in sortedList)
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.Age);
    System.Console.WriteLine(item.Salary);
    System.Console.WriteLine("--------------------------------");

}
System.Console.WriteLine("***************************");


//Section 5
employees.RemoveAll(e => e.Age < 25);
foreach (var item in employees)
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.Age);
    System.Console.WriteLine(item.Salary);
    System.Console.WriteLine("--------------------------------");

}
System.Console.WriteLine("***************************");

//Section 6

var findSalary = employees.FindAll(e => e.Salary >= 5000);

foreach (var item in findSalary)
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.Age);
    System.Console.WriteLine(item.Salary);
    System.Console.WriteLine("--------------------------------");

}
System.Console.WriteLine("***************************");

//Section 7

var removeId = employees.FirstOrDefault(e => e.Id == 3);
employees.Remove(removeId);
foreach (var item in employees)
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.Age);
    System.Console.WriteLine(item.Salary);
    System.Console.WriteLine("--------------------------------");

}
System.Console.WriteLine("***************************");

//Section 8

var jura = employees.Exists(e => e.FirstName == "Jura");

if (jura ==true)
{
    System.Console.WriteLine(jura);
}
else if(jura == false)
{
    System.Console.WriteLine("Jura not found!");
}
foreach (var item in employees)
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.Age);
    System.Console.WriteLine(item.Salary);
    System.Console.WriteLine("--------------------------------");

}
System.Console.WriteLine("***************************");

//Section 9

var emplo = new List<Employee>{ 
    new Employee {
        Id = 4,
        FirstName = "Yusuf",
        LastName = "Mirzoev",
        Age = 15,
        PhoneNumber = "99999999",
        Salary = 1001
    },
     new Employee{
        Id = 5,
        FirstName = "Davron",
        LastName = "Ziyoev",
        Age = 16,
        PhoneNumber = "88166777",
        Salary = 1000
    },
       new Employee {
        Id = 6,
        FirstName = "Mustafo",
        LastName = "Barotov",
        Age = 16,
        PhoneNumber = "918757367",
        Salary = 10000
    },
};
employees.InsertRange(0,emplo);
foreach (var item in employees)
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.Age);
    System.Console.WriteLine(item.Salary);
    System.Console.WriteLine("-------------------------");
}
System.Console.WriteLine("***************************");

//Section 10
List<Employee> orlist = employees.OrderByDescending(e => e.Salary).ToList();
foreach (var item in orlist)
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.Age);
    System.Console.WriteLine(item.Salary);
    System.Console.WriteLine("--------------------------------");

}
System.Console.WriteLine("***************************");






public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string PhoneNumber { get; set; }
    public decimal Salary { get; set; }

    public Employee(){}
    public Employee(string name, string surname)
    {
        FirstName = name;
        LastName = surname;
    }

    public int GetBirthYear()
    {
        return 2024 - Age;
    }
}