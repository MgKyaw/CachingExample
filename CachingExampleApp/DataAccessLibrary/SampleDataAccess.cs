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

    public async Task<List<EmployeeModel>> GetEmployeesAsync()
    {
        var employees = new List<EmployeeModel>();

        employees.Add(new() { FirstName = "Tim", LastName = "Corey" });
        employees.Add(new() { FirstName = "Sue", LastName = "Storm" });
        employees.Add(new() { FirstName = "Jane", LastName = "Jones" });

        await Task.Delay(3000);

        return employees;
    }
}
