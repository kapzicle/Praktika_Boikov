using System;
using System.Collections.Generic;

namespace DemoLib.Models
{
    public class MemoryClientsModel : IClientsModel
    {
        private List<Client> clients_ = new List<Client>();
        public MemoryClientsModel() 
        {
            clients_.Add(new Client
            {
                ID = 1,
                Name = "Ладога",
                Director = "А.Бойков",
                PhoneNumber = "+7-900-112-17-42",
                Type = "ЗАО",
                Discount = 10,
                Rating = 10
            });

            clients_.Add(new Client
            {
                ID = 2,
                Name = "Байкал",
                Director = "В.Терёшин",
                PhoneNumber = "+7-910-640-47-12",
                Type = "ООО",
                Discount = 20,
                Rating = 1
            });
        }

        public List<Client> GetClients()
        {
            return clients_;
        }

        public int ClientCount()
        {
            return clients_.Count;
        }

        public event Action UpdatedClients;
    }
}
