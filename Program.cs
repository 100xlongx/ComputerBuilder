using System;

namespace ComputerBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            GamingComputerBuilder gamingBuilder = new GamingComputerBuilder();
            DevelopmentComputerBuilder developmentBuilder = new DevelopmentComputerBuilder();
            CustomComputerBuilder customBuilder = new CustomComputerBuilder("Linux", "AMD", "Intel", 128, "HDD");

            BuildConsoleWriteLines("Gaming", gamingBuilder);
            BuildConsoleWriteLines("Developer", developmentBuilder);
            BuildConsoleWriteLines("Custom", customBuilder);
        }

        static void BuildConsoleWriteLines(string computerType, IComputerBuilder builder){
            ComputerDirector director = new ComputerDirector(builder);
            Computer computer = director.construct();

            Console.WriteLine($"{computerType}: Os={builder.Os} Graphics Card={builder.GraphicsCard} Cpu={builder.Cpu} Ram={builder.Ram} Storage={builder.Storage}");
        }
    }
}
