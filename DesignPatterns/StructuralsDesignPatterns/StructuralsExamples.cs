using DesignPatterns.StructuralsDesignPatterns.ADAPTER.BAD;
using DesignPatterns.StructuralsDesignPatterns.BRIDGE.BAD;
using DesignPatterns.StructuralsDesignPatterns.BRIDGE.GOOD;
using DesignPatterns.Utils;

namespace DesignPatterns.StructuralsDesignPatterns
{
    /// <summary>
    /// Structural Design Patterns
    /// Les Design Patterns Structural se concentrent sur la composition des classes et objets pour former des structures plus complexes tout en maintenant une
    /// flexibilité et une meilleurs maintenance de ses composants
    /// </summary>
    public class StructuralsExamples
    {

        public void CompositePattern()
        {
            var description = "Permet de traiter les objets de façon individuelle à partir d'arborescences (ex: des boites qui contiennent d'autres boites et des produits différents)";
            Helpers.SetTitle(nameof(CompositePattern), Statut.Title, description);

            Helpers.SetTitle(Statut.Bad.ToString(), Statut.Bad, "Cette solution n'est pas bonne car il faut caster en permanence chaque objet et verifier de quel type il est, et si on en rajoute un autre, on est obligé de modifier le code ce qui viole l'OCP");

            var packageBAD = new COMPOSITE.BAD.Box();

            var box1BAD = new COMPOSITE.BAD.Box();
            box1BAD.Add(new COMPOSITE.BAD.Microphone());

            var box2BAD = new COMPOSITE.BAD.Box();

            var box3BAD = new COMPOSITE.BAD.Box();
            box3BAD.Add(new COMPOSITE.BAD.Mouse());

            var box4BAD = new COMPOSITE.BAD.Box();
            box4BAD.Add(new COMPOSITE.BAD.Keyboard());

            packageBAD.Add(box1BAD);
            packageBAD.Add(box2BAD);
            packageBAD.Add(box3BAD);
            packageBAD.Add(box4BAD);

            Console.WriteLine("Total price of package = " + packageBAD.CalculateTotalPrice()); //Total price of package = 87,99;

            Helpers.SetTitle(Statut.Good.ToString(), Statut.Good, "On créé une hierarchie d'ojets avec une interface commune IItem et ça permet d'implémenter le polymorphisme");
            var package = new COMPOSITE.GOOD.Box();

            var box1 = new COMPOSITE.GOOD.Box();
            box1.Add(new COMPOSITE.GOOD.Microphone());

            var box2 = new COMPOSITE.GOOD.Box();

            var box3 = new COMPOSITE.GOOD.Box();
            box3.Add(new COMPOSITE.GOOD.Mouse());

            var box4 = new COMPOSITE.GOOD.Box();
            box4.Add(new COMPOSITE.GOOD.Keyboard());

            package.Add(box1);
            package.Add(box2);
            package.Add(box3);
            package.Add(box4);

            Console.WriteLine("Total price of package = " + package.GetPrice()); //Total price of package = 87,99
        }

        public void AdapterPattern()
        {
            var description = "Fournir un wrapper pour adapter/traduire des interfaces qui sont incompatibles entre elles pour les faire travailler ensemble (ex: Upload d'une vidéo et changer sa couleur)";
            Helpers.SetTitle(nameof(BASEPattern), Statut.Title, description);

            Helpers.SetTitle(Statut.Bad.ToString(), Statut.Bad, "Si on décide d'ajouter une classe qui appartient à une autre librairie de couleurs qui ne contient pas l'interface IColor alors  que les autres si... comment fait-on ?");

            var videoEditorBAD = new ADAPTER.BAD.VideoEditor(new Video());
            videoEditorBAD.ApplyColor(new BackAndWhiteColor());

            // videoEditorBAD.ApplyColor(new Rainbow());// Error !

            Helpers.SetTitle(Statut.Good.ToString(), Statut.Good, "La solution est d'implémenter un wrapper qui va permettre de traduire l'interface de la nouvelle classe de couleur pour lui permettre de s'adapter à notre code");

            var videoEditor = new ADAPTER.GOOD.VideoEditor(new ADAPTER.GOOD.Video());
            videoEditor.ApplyColor(new ADAPTER.GOOD.BackAndWhiteColor());
            videoEditor.ApplyColor(new ADAPTER.GOOD.RainbowColor(new ADAPTER.GOOD.Rainbow()));// OK !
        }

        public void BridgePattern()
        {
            var description = "Permet de séparer des grandes classes en plusieurs sous-classes pouvant être développées indépendamment les unes des autres";
            Helpers.SetTitle(nameof(BridgePattern), Statut.Title, description);

            Helpers.SetTitle(Statut.Bad.ToString(), Statut.Bad, "Par exemple on a des télécommandes pour controler la radio. Chaque marque est différente (Sony, Samsung,  LG). une commande contient 3 types de fonctionnalités => SamsungRemote, AdvancedRemote, MegaSamsungRepote etc. idem pour les autres. \n Si on veut créer une nouvelle classe, mettons 'RadioTVRemote, on va devoir ajouter les 3 formes RadioTVLG, RadioTVSony, RadioTVSamsung...\nCette solution n'est pas maintenable !");

            var lgRemoteBAD = new BRIDGE.BAD.LGRemote();
            lgRemoteBAD.TurnOn();
            lgRemoteBAD.TurnOff();

            var lgRadioAndTvRemoteBAD = new BRIDGE.BAD.LGRradioAndTVRemote();
            lgRadioAndTvRemoteBAD.ControlTV();
            lgRadioAndTvRemoteBAD.TurnOn();
            lgRadioAndTvRemoteBAD.VolumeUp();

            Helpers.SetTitle(Statut.Good.ToString(), Statut.Good, "On sépare les hierarchies de classe en 2, d'un côté le RemoteControl séparé de l'autre côté des marques LG, Sony etc.\n On peut injecter indépendamment du Sony, du LG etc sans avoir a recréer d'autres classes");

            var lgRemoteControl = new BRIDGE.GOOD.RemoteControl(new BRIDGE.GOOD.LGRadio());
            lgRemoteControl.TurnOn();
            lgRemoteControl.TurnOff();

            var advancedSonyControl = new BRIDGE.GOOD.AdvancedRemote(new BRIDGE.GOOD.SonyRadio());
            advancedSonyControl.TurnOn();
            advancedSonyControl.TurnOff();
            advancedSonyControl.SetChannel(2);

        }

        public void BASEPattern()
        {
            var description = "";
            Helpers.SetTitle(nameof(BASEPattern), Statut.Title, description);

            Helpers.SetTitle(Statut.Bad.ToString(), Statut.Bad, "");

            Helpers.SetTitle(Statut.Good.ToString(), Statut.Good, "");
        }
    }
}