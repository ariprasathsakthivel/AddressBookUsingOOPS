using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookUsingOOPS
{
    class AddressBook
    {
        private List<Contacts> contacts;
        private Dictionary<string, List<Contacts>> addressBookCollection;
        public AddressBook()
        {
            this.contacts = new List<Contacts>();
            this.addressBookCollection = new Dictionary<string, List<Contacts>>();
        }
        public void ContactBuilder(string AddressBook, string FirstName, string LastName, string Address, string City, string State, string ZipCode, string PhoneNumber, string Email)
        {
            Contacts contact=new Contacts(FirstName, LastName, Address, City, State, ZipCode, PhoneNumber, Email);
            this.AddressBookCheck(AddressBook, contact);
        }
        public void AddressBookCheck(string AddressBook, Contacts contact)
        {
            if (this.addressBookCollection.ContainsKey(AddressBook)==true)
            {
                this.addressBookCollection[AddressBook].Add(contact);
            }
            else
            {
                this.addressBookCollection.Add(AddressBook, contacts);
            }
        }
        public void ContactEdit(string key)
        {
            foreach (Contacts element in contacts)
            {
                if (element.firstName==key)
                {
                    ContactEdit(element);
                    break;
                }
            }
        }
        public void PersonDelete(string key)
        {
            foreach (Contacts element in contacts)
            {
                if (element.firstName == key)
                {
                    contacts.Remove(element);
                    break;
                }
            }
        }
        public void ContactEdit(Contacts contact)
        {
            Console.WriteLine("Which data do you want to edit. Enter the following keys:'A'-Address;'C'-City;'S'-State;'Z'-ZipCode;'N'-PhoneNumber;'E'-Email");
            char key = Convert.ToChar(Console.ReadLine());
            switch (key)
            {
                case 'A':
                    Console.WriteLine("Enter the new Address");
                    contact.lastName = Console.ReadLine();
                    break;
                case 'C':
                    Console.WriteLine("Enter the new city");
                    contact.city = Console.ReadLine();
                    break;
                case 'S':
                    Console.WriteLine("Enter the new state");
                    contact.state = Console.ReadLine();
                    break;
                case 'Z':
                    Console.WriteLine("Enter the new zipcode");
                    contact.zipCode = Console.ReadLine();
                    break;
                case 'N':
                    Console.WriteLine("Enter the new Phone number");
                    contact.phoneNumber = Console.ReadLine();
                    break;
                case 'E':
                    Console.WriteLine("Enter the new email");
                    contact.eMail = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Please enter a ");
                    ContactEdit(contact);
                    break;
            }
        }
        public void Display(string key)
        {
            foreach (var contact in addressBookCollection[key])
            {
                contact.toString();
            }
        }
    }
}
