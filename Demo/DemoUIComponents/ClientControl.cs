using DemoLib;
using DemoLib.Views;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DemoUIComponents
{
    public partial class ClientControl: UserControl, IClientView
    {
        private Color initColor_;
        private Client client_;
        public ClientControl()
        {
            InitializeComponent();
            initColor_ = this.BackColor;
        }

        private void ClientControl_MouseEnter(object sender, System.EventArgs e)
        {
            this.BackColor = Color.FromArgb(103, 186, 128);
        }

        private void ClientControl_MouseLeave(object sender, System.EventArgs e)
        {
            this.BackColor = initColor_;
        }

        private void CompanyLabel_Click(object sender, System.EventArgs e)
        {

        }

        public event ClientHandler ClientSelected;

        public void LoadClient(Client client)
        {
            CompanyLabel.Text = client.Type + " | " + client.Name;
            DirectorLabel.Text = client.Director;
            TelephoneLabel.Text = client.PhoneNumber;
            RatingLabel.Text = "Рейтинг: " + Convert.ToString(client.Rating);
            DiscountLabel.Text = client.Discount  + "%";
            client_ = client;
        }

        private void ClientControl_MouseClick(object sender, MouseEventArgs e)
        {
            ClientSelected?.Invoke(client_);
        }
    }
}
