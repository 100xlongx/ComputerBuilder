

namespace ComputerBuilder
{
    public class Computer {
        public string Os;
        public string GraphicsCard;
        public string Cpu;

        public int Ram;

        public string Storage;

        public Computer(string os, string graphics, string cpu, int ram, string storage) {
            this.Os = os;
            this.GraphicsCard = graphics;
            this.Cpu = cpu;
            this.Ram = ram;
            this.Storage = storage;
        }

        public string ComputerString(CustomComputerBuilder builder){
            return builder.ComputerString();
        }
        public string ComputerString(DevelopmentComputerBuilder builder){
            return builder.ComputerString();
        }
        public string ComputerString(GamingComputerBuilder builder){
            return builder.ComputerString();
        }

    }
}

