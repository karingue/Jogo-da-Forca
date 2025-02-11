using System;

namespace LDM_Config
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine("The sum of a and b is: " + c);
       }

        static void Teste(string[] args){
            Console.WriteLine("Testes novos");
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine("The sum of a and b is: " + c);



            public class Device
            {
                public string Name { get; set; }
                public string Type { get; set; }
                public string SerialNumber { get; set; }

                public Device(string name, string type, string serialNumber)
                {
                    Name = name;
                    Type = type;
                    SerialNumber = serialNumber;
                }

                public void DisplayInfo()
                {
                    Console.WriteLine($"Name: {Name}, Type: {Type}, Serial Number: {SerialNumber}");
                }
            }

            // Example usage
            Device device = new Device("Printer", "Peripheral", "12345");
            device.DisplayInfo();

            Device anotherDevice = new Device("Scanner", "Peripheral", "67890");
            anotherDevice.DisplayInfo();

            Device thirdDevice = new Device("Monitor", "Peripheral", "54321");
            thirdDevice.DisplayInfo();

            Device fourthDevice = new Device("Keyboard", "Peripheral", "98765");
            fourthDevice.DisplayInfo();
            Device fifthDevice = new Device("Mouse", "Peripheral", "13579");
            fifthDevice.DisplayInfo();
        }

    }
}