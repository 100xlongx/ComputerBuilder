using System;

namespace ComputerBuilder {
    public class CustomComputerBuilder : IComputerBuilder
    {
        public string Os {get; set;}
        public string GraphicsCard {get; set;}
        public string Cpu {get; set;}
        public int Ram {get; set;}
        public string Storage {get; set;}

        public CustomComputerBuilder(string os, string graphics, string cpu, int ram, string storage) {
            this.Os = os;
            this.GraphicsCard = graphics;
            this.Cpu = cpu;
            this.Ram = ram;
            this.Storage = storage;
        }
        
        public Computer buildComputer()
        {
            return new Computer(this.Os, this.GraphicsCard, this.Cpu, this.Ram, this.Storage);
        }
    }
}