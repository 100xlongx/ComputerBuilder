namespace ComputerBuilder {
    public interface IComputerBuilder {

        string Os {get; set;}
        string GraphicsCard {get; set;}
        string Cpu {get; set;}
        int Ram {get; set;}
        string Storage {get; set;}
        
        Computer buildComputer();
    }
}