using Microsoft.Extensions.Caching.Memory;

namespace DataAccessLibrary;

public class SampleDataAccess
{
    private readonly IMemoryCache _memoryCache;

    public SampleDataAccess(IMemoryCache memoryCache)
    {
        _memoryCache = memoryCache;
    }

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

    public async Task<List<EmployeeModel>> GetEmployeesCache()
    {
        List<EmployeeModel> employees;

        employees = _memoryCache.Get<List<EmployeeModel>>("employees");

        if (employees is null)
        {
            employees = new();

            employees.Add(new() { FirstName = "Tim", LastName = "Corey" });
            employees.Add(new() { FirstName = "Sue", LastName = "Storm" });
            employees.Add(new() { FirstName = "Jane", LastName = "Jones" });

            await Task.Delay(3000);

            _memoryCache.Set("employees", employees, TimeSpan.FromMinutes(1));
        }

        return employees;
    }
}
