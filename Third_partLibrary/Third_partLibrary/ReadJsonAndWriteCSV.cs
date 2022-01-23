using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Third_partLibrary
{
    public class ReadJsonAndWriteCSV
    {
        public static void ImplementJSONToCSV()
        {
            string importFilePath = @"E:\BridgeLAbz\Git\Third-Party_library\Third_partLibrary\Third_partLibrary\Files\export.json";
            string exportFilePath = @"E:\BridgeLAbz\Git\Third-Party_library\Third_partLibrary\Third_partLibrary\Files\Jsondata.csv";

            IList<AddressData> addressData = JsonConvert.DeserializeObject<IList<AddressData>>(File.ReadAllText(importFilePath));

            using (var writer = new StreamWriter(exportFilePath))
            using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvExport.WriteRecords(addressData);
            }
        }
    }
}
