namespace DataAccessLibrary;

public class SampleDataAccess
{
    public List<EmployeeModel> GetEmployees()
    {
        var employees = new List<EmployeeModel>();

        employees.Add(new() { FirstName = "Tim", LastName = "Corey" });
        employees.Add(new() { FirstName = "Sue", LastName = "Storm" });
        employees.Add(new() { FirstName = "Jane", LastName = "Jones" });

        Thread.Sleep(3000);

        return employees;
    }
}
