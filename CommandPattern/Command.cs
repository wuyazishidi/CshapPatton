namespace CommandPattern {
    abstract class Command {
        protected Receiver receiver;
        public Command(Receiver receiver) {
            this.receiver = receiver;
        }
        abstract public void Execute();
    }
    class ConcreteCommand : Command {
        public ConcreteCommand(Receiver receiver):base(receiver) {}
        public override void Execute() {
            receiver.Action();
        }
    }
}
