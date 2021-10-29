using FerryDemo.Constants;
using FerryDemo.Entities;
using FerryDemo.Services.Abstractions;
using FerryDemo.Services.Concretes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FerryDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee
            {
                Id = 1,
                Name = "ABC",
                Income = 0
            };

            var vehicle = new Vehicle
            {
                Id = 1,
                Name = "Car 1",
                IsInspected = false,
                GasPercentage = 5,
                IsCargoOpened = true,
                PlateNumber = "A212",
                FerryId = 1,
                Type = "Car",
                Fee = VehicleFee.Car
            };

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((services) =>
                {
                    services.AddTransient<IEmployeeService, EmployeeService>();
                    services.AddTransient<IVehicleService, VehicleService>();
                    services.AddTransient<SomeClass>();
                })
                .Build();

            host.Services.GetRequiredService<SomeClass>().RunApp(employee, vehicle).GetAwaiter().GetResult();
            
            //ActivatorUtilities.CreateInstance<SomeClass>(host.Services)
            //    .RunApp(employee, vehicle).GetAwaiter().GetResult();
        }
    }
}
