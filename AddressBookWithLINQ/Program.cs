namespace AddressBookWithLINQ
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book with LINQ Assignment");
            Console.WriteLine("============================================");
            AddressBook objAddressBook = new AddressBook();
            objAddressBook.ShowTable(objAddressBook.CreateAddressBookTable());
        }
    }
}
