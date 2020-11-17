﻿namespace AddressBookWithLINQ
{
    using System;
    using System.Data;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book with LINQ Assignment");
            Console.WriteLine("============================================");
            AddressBook objAddressBook = new AddressBook();
            objAddressBook.CreateAddressBookTable();
            object[] fieldsToInsert =
            {
                new object[] {null, "Mark", "Zukerburg", "Street 90 California", "California", "California", "454545", "mar@gg", "451212121"},
                new object[] {null, "Swati", "Pathak", "Street 90 California", "California", "California", "454545", "mar@gg", "451212121" }
            };
            DataTable objTable1 = objAddressBook.InsertValues(fieldsToInsert);
            AddressBook.ShowTable(objTable1);
            object[] fieldsToEdit =
            {
                new object[] {null, "Mark", "Zukerburg", "LAne 45", "California", "California", "784512", "mar@gg", "451212121"},
                new object[] {null, "Swati", "Pathak", "Street 87", "California", "California", "454545", "mar@gg", "451212121" }
            };
            DataTable objTable2 = objAddressBook.EditExitingContacts(fieldsToEdit);
            AddressBook.ShowTable(objTable2);
        }
    }
}
