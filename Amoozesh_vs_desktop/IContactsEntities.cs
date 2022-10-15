using System.Collections.Generic;

namespace Amoozesh_vs_desktop
{
    internal interface IContactsEntities
    {
        bool Update(string ID, string name, string family, string phone, string address);
        List<tblContact> SelectAll();
        List<tblContact> Search(string txtSearch);
        bool Insert(string name, string family, string phone, string address);
        tblContact GetContact(string ID);
        bool Delete(string ID);
    }
}