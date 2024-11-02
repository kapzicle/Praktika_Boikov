using DemoLib.Models;
using DemoLib.Presenters;
using System.Windows.Forms;

namespace Demo
{
    public partial class MainForm : Form
    {
        private MemoryClientsModel model_ = new MemoryClientsModel();
        private ClientPresenter presenter_;
        public MainForm()
        {
            InitializeComponent();

            presenter_ = new ClientPresenter(model_);
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            for (int i = 0; i < model_.ClientCount(); ++i)
            {
                var control = new DemoUIComponents.ClientControl();
                control.ClientSelected += Control_ClientSelected;
                MainLayout.Controls.Add(control);
                presenter_.AddView(control);
            }

            presenter_.Model__UpdatedClients();
        }

        private void Control_ClientSelected(DemoLib.Client client)
        {
            ClientInfo clientInfo = new ClientInfo();
            clientInfo.SetClient(client);
            clientInfo.ShowDialog();
        }
    }
}
