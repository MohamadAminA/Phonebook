using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SQL_Connection
{
    internal interface IContactsRepository
    {
        DataTable SelectAll();
        bool Insert(string name, string family, string phone, string address);
        bool Update(string ID, string name, string family, string phone, string address);
        bool Delete(string ID);
        DataTable GetContact(string ID);
        DataTable Search(string txtSearch);
    }
}
