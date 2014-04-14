using ClientsList.Commands;
using ClientsList.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ClientsList
{
    public class ClientsViewModel:ViewModelBase
    {
        private ObservableCollection<ClientViewModel> clients;
        private ICommand addNewCommand;
        private ClientViewModel newClientViewModel;
        public string PathXML { get; set; }

        public IEnumerable<ClientViewModel> Clients
        {
            get
            {
                if (this.clients == null)
                {
                    this.Clients = DataPersister.GetClientsFromXml(PathXML);
                }
                return clients;
            }
            set
            {
                if (this.clients == null)
                {
                    this.clients = new ObservableCollection<ClientViewModel>();
                }
                this.clients.Clear();
                foreach (var item in value)
                {
                    this.clients.Add(item);
                }
            }
        }
        public ClientsViewModel()
        {
            this.PathXML = "..\\..\\clients.xml";
            this.Clients = DataPersister.GetClientsFromXml(this.PathXML);     
        }

        public ClientViewModel NewClient
        {
            get
            {
                return this.newClientViewModel;
            }
            set
            {
                this.newClientViewModel = value;
                this.OnPropertyChanged("NewClient");
            }
        }

        public ICommand AddNew
        {
            get
            {
                if (this.addNewCommand == null)
                {
                    this.addNewCommand = new RelayCommand(this.HandleAddNewCommand);
                }
                return this.addNewCommand;
            }
        }

        private void HandleAddNewCommand(object obj)
        {
         
                DataPersister.AddClient(this.PathXML, this.NewClient);
                this.Clients = DataPersister.GetClientsFromXml(this.PathXML);
                this.NewClient = new ClientViewModel();
           
        }

        
    }
}
