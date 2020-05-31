using System.Collections.Generic;
using System.Linq;

namespace AddressBook
{
    class AddressBook
    {
        private List<Contact> contacts = new List<Contact>();
        public void AddContact(Contact contact){
            if(!contacts.Contains(contact)){
                contacts.Add(contact);
            }else{
                System.Console.WriteLine("contact exists");
            }
        }
        public Contact  GetByEmail(string email){
            IEnumerable<Contact> emailAddress = contacts.Where(em => em.Email == email);
            List<Contact> userEmail = emailAddress.ToList();
            return userEmail.FirstOrDefault();
        }
    }
}