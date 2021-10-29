using System.Threading.Tasks;
using FerryDemo.Entities;

namespace FerryDemo.Services.Abstractions
{
    public interface IEmployeeService
    {
        /// <summary>
        /// show employee's info
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        Task ShowEmployeeInformation(Employee employee);

        /// <summary>
        /// add employee's income
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="vehicleFee"></param>
        /// <returns></returns>
        Task AddIncome(Employee employee, int vehicleFee);

        /// <summary>
        /// show employee's income
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        Task ShowEmployeeIncome(Employee employee);
    }
}
