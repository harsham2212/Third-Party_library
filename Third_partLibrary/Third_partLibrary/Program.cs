using System;

namespace Third_partLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Third-Party Library");
            CSVHandler.ImplementCSVHandling();
            ReadCSV_And_WriteJSON.Implement_CSVToJSON();
            ReadJsonAndWriteCSV.ImplementJSONToCSV();
            Console.ReadKey();
        }
    }
}
