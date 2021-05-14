using System;

namespace ComputerBuilder {
    
    public class DevelopmentComputerBuilder : IComputerBuilder
    {
        public string Os {get; set;}
        public string GraphicsCard {get; set;}
        public string Cpu {get; set;}
        public int Ram {get; set;}
        public string Storage {get; set;}

        public DevelopmentComputerBuilder() {
            this.Os = "Linux";
            this.GraphicsCard = "AMD";
            this.Cpu = "AMD";
            this.Ram = 64;
            this.Storage = "SSD";
        }
        
        public Computer buildComputer()
        {
            return new Computer(this.Os, this.GraphicsCard, this.Cpu, this.Ram, this.Storage);
        }

        // public string ComputerString()
        // {
        //     return $"Development Computer: Os={this.Os} GraphicsCard={this.GraphicsCard} Cpu={this.Cpu} Ram={this.Ram} Storage={this.Storage}";
        // }
    }
}