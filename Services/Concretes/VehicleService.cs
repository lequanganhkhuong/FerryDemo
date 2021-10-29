using System;
using System.Threading.Tasks;
using FerryDemo.Entities;
using FerryDemo.Services.Abstractions;

namespace FerryDemo.Services.Concretes
{
    public class VehicleService : IVehicleService
    {
        public async Task<Vehicle> CheckInVehicle(Vehicle vehicle, Employee employee)
        {
            Console.WriteLine("Enter vehicle information...");
            await ShowVehicleInformation(vehicle);

            Console.WriteLine("\n------Checking gas------");
            if (vehicle.GasPercentage <= 10) vehicle = await FillGas(vehicle, employee);

            Console.WriteLine("\n------Inspecting------");
            if (vehicle.IsCargoOpened) vehicle = await InspectVehicle(vehicle, employee);

            if (!vehicle.IsInspected) return new Vehicle();

            Console.WriteLine("\n------Loading vehicle onto ferry------");
            await LoadVehicle(vehicle);
            return vehicle;
        }

        public async Task<Vehicle> InspectVehicle(Vehicle vehicle, Employee employee)
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Inspecting vehicle...");
                vehicle.IsInspected = true;
                Console.WriteLine("Vehicle inspected.");
            });

            return vehicle;
        }

        public async Task LoadVehicle(Vehicle vehicle)
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Loading vehicle...");
                Console.WriteLine("Vehicle loaded.");
            });
        }

        public async Task<Vehicle> FillGas(Vehicle vehicle, Employee employee)
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Filling gas...");
                vehicle.GasPercentage = 100;
                Console.WriteLine("Gas filled.");
            });

            return vehicle;
        }

        public async Task ShowVehicleInformation(Vehicle vehicle)
        {
            await Task.Run(() =>
            {
                Console.WriteLine("\nVehicle's information");
                Console.WriteLine($"{nameof(vehicle.Name)}: {vehicle.Name}");
                Console.WriteLine($"{nameof(vehicle.PlateNumber)}: {vehicle.PlateNumber}");
                Console.WriteLine($"{nameof(vehicle.GasPercentage)}: {vehicle.GasPercentage}");
                Console.WriteLine($"{nameof(vehicle.IsCargoOpened)}: {vehicle.IsCargoOpened}");
                Console.WriteLine($"{nameof(vehicle.IsInspected)}: {vehicle.IsInspected}");
                Console.WriteLine($"{nameof(vehicle.Fee)}: {vehicle.Fee}");
                Console.WriteLine($"{nameof(vehicle.Type)}: {vehicle.Type}");
            });
        }

        public async Task TrackVehicle(Vehicle vehicle)
        {
            await Task.Run(() =>
            {
                Console.WriteLine("\nTracking...");
                vehicle.CurrentLocation = "Some random location";
                Console.WriteLine($"Vehicle {vehicle.Name} is at {vehicle.CurrentLocation}");
            });
        }
    }
}
