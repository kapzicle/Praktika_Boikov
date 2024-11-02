using DemoLib;
using System.Windows.Forms;

namespace Demo
{
    public partial class ClientInfo : Form
    {
        public ClientInfo()
        {
            InitializeComponent();
        }

        public void SetClient(Client client)
        {
            CompanyNameTextBox.Text = client.Name;
        }
    }
}
