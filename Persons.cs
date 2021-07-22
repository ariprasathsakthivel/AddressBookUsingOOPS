using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookUsingOOPS
{
    class Persons
    {
        private List<Contacts> contacts = new List<Contacts>();
        public void ContactsBuilder(string FirstName, string LastName, string Address, string City, string State, string ZipCode, string PhoneNumber, string Email)
        {
            Contacts contact=new Contacts(FirstName, LastName, Address, City, State, ZipCode, PhoneNumber, Email);
            contacts.Add(contact);
        }
        public void ContactEdit(string key)
        {
            foreach (Contacts element in contacts)
            {
                if (element.firstName==key)
                {
                    ContactEdit(element);
                    element.toString();
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
    }
}
