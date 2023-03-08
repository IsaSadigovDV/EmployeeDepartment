﻿
using TaskEmployee.Models;

Employee employee1 = new Employee("Isa", "Sadigov", 3000);


Console.WriteLine("Your name is: " + employee1.Name);
Console.WriteLine("Your surname is: " + employee1.Surname);
Console.WriteLine("Your salary is: " +employee1.Salary);


Department department = new Department();


bool status = true;

Console.WriteLine("Please choose one of theese two steps");
Console.WriteLine("1: Add Employee");
Console.WriteLine("2: Show Employee");
Console.WriteLine("3: Exit program");

string choose = Console.ReadLine();

if(choose == "1")
{
    
    if(department.EmployeeCount > department.EmployeeLimit)
    {
        Console.WriteLine("Employee limit is full!");
        
    }
    else
    {
        department.AddEmployee();
    }
    
}
else if(choose== "2")
{
    department.ShowEmployee();
}
else if(choose== "3")
{
    Console.WriteLine("Good bye. Program is exiting");
}
else
{
    Console.WriteLine("Please select step number correctly");
}


