using System;

namespace DemoLib.Views
{
    public delegate void ClientHandler(Client client);
    public interface IClientView
    {
        void LoadClient(Client client);

        event ClientHandler ClientSelected;
    }
}
