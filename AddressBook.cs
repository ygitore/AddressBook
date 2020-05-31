using System.Collections.Generic;
using System.Linq;

namespace AddressBook
{
    class AddressBook
    {
        private Dictionary<string, Contact> contacts = new Dictionary<string, Contact>();
        public void AddContact(Contact contact){
            if(!contacts.ContainsValue(contact)){
                contacts.Add(contact.Email, contact);
            }else{
                System.Console.WriteLine("contact exists");
            }
        }
        public Contact  GetByEmail(string email){
            IEnumerable<KeyValuePair<string, Contact>> emailAddress = contacts.Where(em => em.Value.Email == email);
            Dictionary<string, Contact> userEmail = emailAddress.ToDictionary(K => K.Key, k => k.Value);
            return userEmail.FirstOrDefault().Value;            
        }
    }
}