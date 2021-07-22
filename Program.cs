using System;

namespace AddressBookUsingOOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacts("Ariprasath", "Sakthivel", "No.1, A street, b cross", "XYZ city", "MNO state", "606606", "9494946060", "ariprasath3@gmail.com");
        }
        public static void Contacts(string FirstName, string LastName, string Address, string City, string State, string ZipCode, string PhoneNumber, string Email)
        {
            string firstName = FirstName, lastName = LastName, address = Address, city = City, state = State, zipCode = ZipCode, phoneNumber = PhoneNumber, eMail = Email;
            Console.WriteLine(firstName + " " + lastName + "\n" + address + "\n" + city + "\n" + state + "\n" + zipCode + "\n" + PhoneNumber + "\n" + Email);
        }
    }
}
