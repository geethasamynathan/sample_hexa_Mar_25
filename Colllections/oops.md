# 1. Example for class and object
```cs
 internal class Employee
 {

     int _employeeId = 101;
     string _empName = "Raja";
     string _designation = "Team Lead";
     decimal _salary = 67332.67M;

   public  void DisplayEmployeeDetails()
     {
         Console.WriteLine($"Id = {_employeeId} \nName ={_empName}\nDesignation={_designation}" +
             $"\nSalary={_salary}");
     }
 }
 ```
## Program.cs
```cs
 internal class Program
 {
     static void Main(string[] args)
     {
         Employee employee;
         employee= new Employee();
         //(Or)
         Employee employee2= new Employee();
         employee.DisplayEmployeeDetails();
         Console.ReadLine();
     }
 }
 ```

 # Exmaple :2
Employee.cs
```cs

 internal class Employee
{

    int _employeeId;
    string _empName;
    string _designation;
    decimal _salary;

    public void GetEmployeeDetials()
    {
        Console.WriteLine("Enter the Employee Id,Name,Designation,Salary");
        _employeeId=Convert.ToInt32(Console.ReadLine());
        _empName=Console.ReadLine();
        _designation=Console.ReadLine();
        _salary=Convert.ToDecimal(Console.ReadLine());
    }

  public  void DisplayEmployeeDetails()
    {
        Console.WriteLine($"Id = {_employeeId} \nName ={_empName}\nDesignation={_designation}" +
            $"\nSalary={_salary}");
    }
}
```

Program.cs
```cs
 static void Main(string[] args)
 {
     Employee employee;
     employee= new Employee();
     employee.GetEmployeeDetials();
    

     Employee employee2 = new Employee();
    
     employee2.GetEmployeeDetials();
     Console.WriteLine("\n\n ");
     employee.DisplayEmployeeDetails();
     Console.WriteLine("\n\n ");

     employee2.DisplayEmployeeDetails();
     Console.ReadLine();
 }
```