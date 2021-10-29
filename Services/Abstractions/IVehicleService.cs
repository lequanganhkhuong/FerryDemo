using System.Threading.Tasks;
using FerryDemo.Entities;

namespace FerryDemo.Services.Abstractions
{
    public interface IVehicleService
    {
        /// <summary>
        /// check in vehicle, get its information
        /// </summary>
        /// <param name="vehicle"></param>
        /// <param name="employee"></param>
        /// <returns></returns>
        Task<Vehicle> CheckInVehicle(Vehicle vehicle, Employee employee);

        /// <summary>
        /// inspect vehicle
        /// </summary>
        /// <param name="vehicle"></param>
        /// <param name="employee"></param>
        /// <returns></returns>
        Task<Vehicle> InspectVehicle(Vehicle vehicle, Employee employee);

        /// <summary>
        /// load vehicle on to ferry
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        Task LoadVehicle(Vehicle vehicle);

        /// <summary>
        /// fill gas
        /// </summary>
        /// <param name="vehicle"></param>
        /// <param name="employee"></param>
        /// <returns></returns>
        Task<Vehicle> FillGas(Vehicle vehicle, Employee employee);

        /// <summary>
        /// show vehicle info
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        Task ShowVehicleInformation(Vehicle vehicle);

        /// <summary>
        /// track the vehicle
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        Task TrackVehicle(Vehicle vehicle);
    }
}
