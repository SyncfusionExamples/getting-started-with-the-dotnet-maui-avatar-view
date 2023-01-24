
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiProject
{
    class ListViewModel
    {
        public List<ContactInfo> NameList { get; set; }

        public ListViewModel()
        {
            NameList = new List<ContactInfo>
            {
               new ContactInfo() { Name="Kathryn Fuller"},
               new ContactInfo() { Name="Tamer Fuller" },
               new ContactInfo() { Name="Martin Nancy" },
               new ContactInfo() { Name="Davolio Leverling" },
               new ContactInfo() { Name="Nancy Fuller" },
               new ContactInfo() { Name="Fuller Margaret" }
            };
        }
    }
}
