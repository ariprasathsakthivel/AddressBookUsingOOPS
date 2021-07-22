using System;

namespace AddressBookUsingOOPS
{
    class MainMethod
    {
        public static void Main(String[] args)
        {
            Contacts person1 = new Contacts("Ariprasath", "Sakthivel", "No.1, A street, b cross", "XYZ city", "MNO state", "606606", "9494946060", "ariprasath3@gmail.com");
            Contacts person2 = new Contacts("Rahul", "Krishna", "No.2,AK street, 3rd Cross", "XXY city", "MMN state", "660666", "9194979295", "rahulkrisna@gmail.com");
            person1.toString();
            person2.toString();
        }
    }
}
