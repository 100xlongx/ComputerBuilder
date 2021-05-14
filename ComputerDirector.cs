namespace ComputerBuilder {
    public class ComputerDirector {
        private IComputerBuilder _builder;

        public ComputerDirector(IComputerBuilder builder) {
            this._builder = builder;
        }
    }
}