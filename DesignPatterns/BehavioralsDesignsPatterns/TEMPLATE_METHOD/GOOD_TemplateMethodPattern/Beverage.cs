namespace DesignPatterns.BehavioralsDesignsPatterns.TEMPLATE_METHOD.GOOD_TemplateMethodPattern
{
    public abstract class Beverage
    {
        public void Prepare()
        {
            BoilWater();
            PourIntoCup();
            Brew();
        }

        public void BoilWater()
        {
            System.Console.WriteLine("Boiling water");
        }

        private void PourIntoCup()
        {
            System.Console.WriteLine("Pouring boiled water into cup");
        }

        protected abstract void Brew();

        protected virtual void AddCondiments() { }
    }
}