using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Connection;

namespace Amoozesh_vs_desktop
{
    internal class Entities : IContactsEntities
    {
        
        public bool Delete(string id)
        {
            using(ContactsEntities entities = new ContactsEntities())
            {
                tblContact contact = entities.tblContacts.Find(int.Parse(id));
                entities.tblContacts.Remove(contact);
                entities.SaveChanges();
            }
            return true;
        }

        public tblContact GetContact(string id)
        {
            using (ContactsEntities entities = new ContactsEntities())
            {
                return entities.tblContacts.Find(id);
            }
            
        }

        public bool Insert(string name, string family, string phone, string address)
        {
            using (ContactsEntities entities = new ContactsEntities())
            {
                entities.tblContacts.Add(new tblContact { Name = name, Family = family, Phone = phone, Address = address });
                entities.SaveChanges();
            }

            return true;
        }

        public List<tblContact> Search(string txtSearch)
        {
            using (ContactsEntities entities = new ContactsEntities())
            {
                return entities.tblContacts.Where(n => n.Name.Contains(txtSearch) || n.Family.Contains(txtSearch)).Select(n => n).ToList();

            }
        }
        public List<tblContact> SelectAll()
        {
            using (ContactsEntities entities = new ContactsEntities())
            {
                return entities.tblContacts.Select(n => n).ToList();
            }
        }

        public bool Update(string ID, string name, string family, string phone, string address)
        {
            using (var entities = new ContactsEntities())
            {
                tblContact contact = entities.tblContacts.Find(int.Parse(ID));
                contact.Name = name;
                contact.Family = family;
                contact.Phone = phone;
                contact.Address = address;
                entities.SaveChanges();
            }
            return true;
        }
    }
}
