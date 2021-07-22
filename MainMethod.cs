using System;

namespace AddressBookUsingOOPS
{
    class MainMethod
    {
        public static void Main(String[] args)
        {
            Persons person1 = new Persons();
            Persons person2=new Persons();
            person1.ContactsBuilder("Ariprasath", "Sakthivel", "No.1, A street, b cross", "XYZ city", "MNO state", "606606", "9494946060", "ariprasath3@gmail.com");
            person2.ContactsBuilder("Rahul", "Krishna", "No.2,AK street, 3rd Cross", "XXY city", "MMN state", "660666", "9194979295", "rahulkrisna@gmail.com");
            person2.ContactEdit("Rahul");
            person1.PersonDelete("Ariprasath");
        }
    }
}
