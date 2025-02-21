namespace DESIGNPATTERNS.BehavioralsDesignsPatterns.Command.GOOD
{

    public class DimCommand : ICommand
    {
        private Light _light;

        public DimCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Dim();
        }
    }
}