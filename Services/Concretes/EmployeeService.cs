using System;
using System.Threading.Tasks;
using FerryDemo.Entities;
using FerryDemo.Services.Abstractions;

namespace FerryDemo.Services.Concretes
{
    public class EmployeeService : IEmployeeService
    {
        public async Task ShowEmployeeInformation(Employee employee)
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"{nameof(employee.Id)} {employee.Id}");
                Console.WriteLine($"{nameof(employee.Name)} {employee.Name}");
                Console.WriteLine($"{nameof(employee.Income)} {employee.Income}");
            });
        }

        public async Task AddIncome(Employee employee, int vehicleFee)
        {
            await Task.Run(() =>
            {
                employee.Income += employee.Income + vehicleFee * 10.0 / 100;
            });
        }

        public async Task ShowEmployeeIncome(Employee employee)
        {
            await Task.Run(() =>
            {
                Console.WriteLine("\nEmployee " + employee.Name + "'s income: " + employee.Income);
            });
        }
    }
}
