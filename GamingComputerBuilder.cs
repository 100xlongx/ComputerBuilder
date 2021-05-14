using System;

namespace ComputerBuilder {
    public class GamingComputerBuilder : IComputerBuilder
    {
        public string Os {get; set;}
        public string GraphicsCard {get; set;}
        public string Cpu {get; set;}
        public int Ram {get; set;}
        public string Storage {get; set;}

        public GamingComputerBuilder() {
            this.Os = "Windows";
            this.GraphicsCard = "Nvidia";
            this.Cpu = "Intel";
            this.Ram = 120;
            this.Storage = "NVME";
        }
        
        public Computer buildComputer()
        {
            return new Computer(this.Os, this.GraphicsCard, this.Cpu, this.Ram, this.Storage);
        }

        public string ComputerString()
        {
            return $"Gaming Computer: Os={this.Os} GraphicsCard={this.GraphicsCard} Cpu={this.Cpu} Ram={this.Ram} Storage={this.Storage}";
        }
    }
}