using System;

namespace ComputerBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            GamingComputerBuilder gamingBuilder = new GamingComputerBuilder();
            ComputerDirector gamingDirector = new ComputerDirector(gamingBuilder);

            Computer gamingComputer = gamingDirector.construct();

            Console.WriteLine(gamingComputer.Ram);

            DevelopmentComputerBuilder developmentBuilder = new DevelopmentComputerBuilder();
            ComputerDirector developmentDirector = new ComputerDirector(developmentBuilder);

            Computer devComputer = developmentDirector.construct();

            Console.WriteLine(devComputer.Ram);

            CustomComputerBuilder customBuilder = new CustomComputerBuilder("Linux", "AMD", "Intel", 128, "HDD");
            ComputerDirector customDirector = new ComputerDirector(customBuilder);

            Computer customComputer = customDirector.construct();

            Console.WriteLine(customComputer.Ram);

        }
    }
}
