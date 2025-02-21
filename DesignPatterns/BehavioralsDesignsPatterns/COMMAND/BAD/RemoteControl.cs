namespace DESIGNPATTERNS.BehavioralsDesignsPatterns.Command.BAD
{
    // Receiver class
    public class RemoteControl
    {
        private Light _light;

        public RemoteControl(Light light)
        {
            _light = light;
        }

        //BAD: Problème car si on ajoute une fonctionnalité, on doit modifier la logique ici (fort coupling entre les objets) viole le principe d'OCP
        public void PressButton(bool turnOn)
        {
            if (turnOn)
                _light.TurnOn();
            else
                _light.TurnOff();
        }
    }

    //Exemple d'un ajout d'une fonctionnalité qui va modifier l'objet existant et ajouter de la compléxité et du coupling
    // public void DimLight()
    //     {
    //         _light.DimLight();
    //     }
    }