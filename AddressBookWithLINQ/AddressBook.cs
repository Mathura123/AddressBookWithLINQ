﻿namespace AddressBookWithLINQ
{
    using System;
    using System.Data;

    class AddressBook
    {
        DataSet addressBookSet;
        DataTable addressBookTable;
        public AddressBook()
        {
            addressBookSet = new DataSet();
        }
        public DataTable CreateAddressBookTable()
        {
            addressBookTable = new DataTable();
            addressBookSet.Tables.Add(addressBookTable);
            DataColumn[] columns =
            {
                new DataColumn("Id",typeof(int)),
                new DataColumn("FirstName",typeof(string)),
                new DataColumn("LastName",typeof(string)),
                new DataColumn("Address",typeof(string)),
                new DataColumn("City",typeof(string)),
                new DataColumn("State",typeof(string)),
                new DataColumn("Zip",typeof(string)),
                new DataColumn("Email",typeof(string)),
                new DataColumn("PhoneNo",typeof(string)),
            };
            addressBookTable.Columns.AddRange(columns);
            addressBookTable.PrimaryKey = new[] { columns[0]};
            return addressBookTable;
        }
        public void ShowTable(DataTable table)
        {
            foreach(DataColumn column in table.Columns)
            {
                Console.Write("{0,-14}".PadRight(8,'|').PadLeft(9,' '), column); 
            }
            Console.WriteLine();
            foreach(DataRow row in table.Rows)
            {
                foreach(DataColumn column in table.Columns)
                {
                    Console.Write("{0,-14}".PadRight(8, '|').PadLeft(9, ' '), row[column]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
