namespace DESIGNPATTERNS.BehavioralsDesignsPatterns.Command.BAD
{
    // Receiver class
    public class Light
    {
        public void TurnOn()
        {
            System.Console.WriteLine("Light is on");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Light is off");
        }
    }
}