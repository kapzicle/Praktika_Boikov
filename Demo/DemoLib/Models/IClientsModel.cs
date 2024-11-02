using System;
using System.Collections.Generic;

namespace DemoLib.Models
{
    public interface IClientsModel
    {
        /// <summary>
        ///  предоставляет информацию обо всех клиентах
        /// </summary>
        /// <returns>список с информацией о клиентах</returns>
        List<Client> GetClients();

        /// <summary>
        /// число клиентов в системе
        /// </summary>
        /// <returns>число клиентов</returns>
        int ClientCount();

        /// <summary>
        /// событие, показывающее то, что информация о партнерах обновленв
        /// </summary>
        event Action UpdatedClients;
    }
}
