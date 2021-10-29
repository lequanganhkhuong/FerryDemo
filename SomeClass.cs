using System.Threading.Tasks;
using FerryDemo.Entities;
using FerryDemo.Services.Abstractions;

namespace FerryDemo
{
    public class SomeClass
    {
        private readonly IVehicleService _vehicleService;
        private readonly IEmployeeService _employeeService;

        public SomeClass(IVehicleService vehicleService, IEmployeeService employeeService)
        {
            _vehicleService = vehicleService;
            _employeeService = employeeService;
        }

        public async Task RunApp(Employee employee, Vehicle vehicle)
        {
            var loadedVehicle = await _vehicleService.CheckInVehicle(vehicle, employee);
            if (loadedVehicle.Id != 0) await _vehicleService.ShowVehicleInformation(loadedVehicle);
            await _vehicleService.TrackVehicle(vehicle);
            await _employeeService.AddIncome(employee, loadedVehicle.Fee);
            await _employeeService.ShowEmployeeIncome(employee);
        }
    }
}
