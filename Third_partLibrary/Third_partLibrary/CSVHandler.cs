using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Third_partLibrary
{
    public class CSVHandler
    {
        public static void ImplementCSVHandling()
        {
            string importfilepath = @"E:\BridgeLAbz\Git\Third-Party_library\Third_partLibrary\Third_partLibrary\Files\address.csv";
            string exportfilepath = @"E:\BridgeLAbz\Git\Third-Party_library\Third_partLibrary\Third_partLibrary\Files\export.csv";

            using (var reader = new StreamReader(importfilepath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read data successfully from address csv");
                foreach (AddressData addressdata in records)
                {
                    Console.WriteLine("\nfirstname: " + addressdata.firstname + "\nlastname: " + addressdata.lastname + "\naddress: " + addressdata.address + "\ncity: " + addressdata.city + "\nstate: " + addressdata.state + "\ncode: " + addressdata.code);
                }
                Console.WriteLine("Now reading from csv file and write to csv file");

                using (var writer = new StreamWriter(exportfilepath))
                using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(records);
                }
            }
        }
    }

}
