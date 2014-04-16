using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClientsList
{
    public class DataPersister
    {
        public static ObservableCollection<ClientViewModel> GetClientsFromXml(string xmlPath)
        {
            XDocument doc = XDocument.Load(xmlPath);
            var root = doc.Root;
            var phones = root.Elements("client")
                .AsQueryable()
                .Select(ClientViewModel.FromXElement);
            return new ObservableCollection<ClientViewModel>(phones);
        }

        internal static void AddClient(string documentPath, ClientViewModel client)
        {
            var root = XDocument.Load(documentPath).Root;
            root.Add(new XElement("client",
                new XElement("name", client.Name),
                new XElement("city", client.City),
                new XElement("note", client.Note),
                new XElement("imagePath", client.ImagePath),
                new XElement("contractPath",client.ContractPath),
                new XElement("contractDate",client.ContractDate)));
            root.Document.Save(documentPath);
        }

        internal static void DeleteClient(string documenthPath, ClientViewModel client)
        {
            var doc = XDocument.Load(documenthPath);
            doc.Descendants().Where(c => c.Name == client.Name).Remove();
        }

    }
}
