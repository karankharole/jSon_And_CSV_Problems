namespace jSon_And_CSV_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string cSVPath = @"D:\jSon_And_CSV_Problem\ContactjSon.json";

            PersonInput input = new PersonInput();
            Console.WriteLine("\nEnter your First Name : ");
            input.fName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name : ");
            input.lName = Console.ReadLine();
            Console.WriteLine("Enter your Address : ");
            input.address = Console.ReadLine();
            Console.WriteLine("Enter your City Name : ");
            input.city = Console.ReadLine();
            Console.WriteLine("Enter your State Name : ");
            input.state = Console.ReadLine();
            Console.WriteLine("Enter your Zip Code : ");
            input.zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Phone Number : ");
            input.phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Email Address: ");
            input.email = Console.ReadLine();

            

            CSVOperations.WriteRecordsInCSVFile(cSVPath, input);
            Console.WriteLine("\n\nRecords present in CSV file are : \n");
            CSVOperations.ReadRecordsInCSVFile(cSVPath);
            Console.ReadLine();
        }
    }
}