namespace DESIGNPATTERNS.BehavioralsDesignsPatterns.Command.GOOD
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

        public void Dim()
        {
            System.Console.WriteLine("Light is dim");
        }
    }
}