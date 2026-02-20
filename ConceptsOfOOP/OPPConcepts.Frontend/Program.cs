//create frontend for date app with the class we already created
using ConceptsOfOPP.Backend;

/*
try
{
    var date1 = new Date();
    var date2 = new Date(2028, 2, 29);
    var date3 = new Date(2012, 11, 30);

    Console.WriteLine(date1);
    Console.WriteLine(date2);
    Console.WriteLine(date3);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
*/

try
{
    var employees = new List<Employee>();
    decimal payroll = 0;
    var employee1 = new SalaryEmployee(1010, "Maria", "Perez", true, new Date(1990, 5, 15), new Date(2020, 1, 1), 2500000);
    employees.Add(employee1);
    var employee2 = new SalaryEmployee(2020, "Joaquin", "Gonzalez", true, new Date(1970, 4, 12), new Date(2015, 11, 16), 10395876);
    employees.Add(employee2);
    var employee3 = new HourlyEmployee(3030, "Ána", "Lopez", true, new Date(1995, 8, 20), new Date(2022, 6, 1), 18000, 95);
    employees.Add(employee3);
    var employee4 = new HourlyEmployee(4040, "Kevin", "Rúa", true, new Date(1998, 5, 25), new Date(2021, 6, 1), 10000, 112);
    employees.Add(employee4);

    foreach (var employee in employees)
    {
        Console.WriteLine(new string('-', 47));
        Console.WriteLine(employee);
        payroll += employee.GetValueToPay();
    }
    Console.WriteLine(new string('=', 47));
    Console.WriteLine($"Payroll: {payroll,20:C2}");
} 
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
