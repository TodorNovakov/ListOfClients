using ClientsList.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClientsList
{
    public class ClientViewModel:ViewModelBase
    {
        private string name;
        private string city;
        private string note;
        private DateTime contractDate;
        private string imagePath;
        private string contractPath;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public string City
        {
            get { return this.city; }
            set
            {
                if (this.city != value)
                {
                    this.city = value;
                    OnPropertyChanged("City");
                }
            }
        }

        public string Note
        {
            get { return this.note; }
            set
            {
                if (this.note != value)
                {
                    this.note = value;
                    OnPropertyChanged("Note");
                }
            }
        }

        public string Date
        {
            get { return this.ContractDate.ToString("d"); }
        }
        public DateTime ContractDate
        {
            get { return this.contractDate; }
            set 
            {
                if (this.contractDate != value)
                {
                    this.contractDate = value;
                    OnPropertyChanged("ContractDate");
                
                }
            }
        }

        public string ImagePath
        {
            get { return this.imagePath;}
            set 
            {
                if (this.imagePath != value)
                {
                    this.imagePath = value;
                    OnPropertyChanged("ImagePath");
                }

            }
        }

        public string ContractPath
        {
            get { return this.contractPath; }
            set
            {
                if (this.contractPath != value)
                {
                    this.contractPath = value;
                    OnPropertyChanged("ContractPath");
                }
            }
        }
        public static Expression<Func<XElement, ClientViewModel>> FromXElement
        {
            get
            {
                return element =>
                    new ClientViewModel()
                    {
                        Name = element.Element("name").Value,
                        City = element.Element("city").Value,
                        Note = element.Element("note").Value,
                        ImagePath=element.Element("imagePath").Value,
                        ContractPath=element.Element("contractPath").Value,
                        ContractDate=DateTime.Parse(element.Element("contractDate").Value),
                    };
            }

        }
    }
}
