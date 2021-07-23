using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookUsingOOPS
{
    class Contacts
    {
        public string firstName, lastName, address, city, state, zipCode, phoneNumber, eMail;

        public Contacts(string FirstName, string LastName, string Address, string City, string State, string ZipCode, string PhoneNumber, string Email)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.address = Address;
            this.city = City;
            this.state = State;
            this.zipCode = ZipCode;
            this.phoneNumber = PhoneNumber;
            this.eMail = Email;
        }
        public void toString()
        {
            Console.WriteLine(this.firstName + " " + this.lastName + "\n" + this.address + "\n" + this.city + "\n" + this.state + "\n" + this.zipCode + "\n" + this.phoneNumber + "\n" + this.eMail);
        }
    }
}
