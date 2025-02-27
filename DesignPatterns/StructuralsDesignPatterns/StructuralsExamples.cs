using DesignPatterns.StructuralsDesignPatterns.ADAPTER.BAD;
using DesignPatterns.StructuralsDesignPatterns.PROXY.BAD.Package;
using DesignPatterns.StructuralsDesignPatterns.PROXY.GOOD;
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
            Helpers.SetTitle(nameof(AdapterPattern), Statut.Title, description);

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

        public void ProxyPattern()
        {
            var description = "Permet l'accès d'un objet à un autre objet en controlant son accès (ex: liste de vidéo Youtube d'une API, et affiche la liste)";
            Helpers.SetTitle(nameof(ProxyPattern), Statut.Title, description);

            Helpers.SetTitle(Statut.Bad.ToString(), Statut.Bad, "Dans cette structure de classe, si on appelle une nouvelle fois une vidéo Youtube, toutes les vidéos vont de nouveau être téléchargées, ce qui implique un cout de téléchargement important !");
            var videoListBAD = new PROXY.BAD.VideoList();
            string[] videoIds = { "1234", "abcde", "javascr123" };

            foreach (var videoId in videoIds)
            {
                videoListBAD.Add(new YoutubeVideo(videoId));
            }

            // Downloading video with id 1234 from Youtube API
            // Downloading video with id abcde from Youtube API
            // Downloading video with id javascr123 from Youtube API
            // Rendering video abcde            
            videoListBAD.Watch("abcde");

            Helpers.SetTitle(Statut.Good.ToString(), Statut.Good, "Afin de contourner ce problème, il faut faire en sorte que les vidéos, une fois téléchargées, ne le soient plus ensuite, c'est ce qu'on appelle le 'lazy loading', d'ou l'utilisation d'un objet intermédiaire, le proxy.");

            var videoListGOOD = new PROXY.GOOD.VideoList();

            foreach (var videoId in videoIds)
            {
                videoListGOOD.Add(new YoutubeVideoProxy(videoId));
            }

            // Downloading video with id abcde from Youtube API
            // Rendering video abcde
            videoListGOOD.Watch("abcde");
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