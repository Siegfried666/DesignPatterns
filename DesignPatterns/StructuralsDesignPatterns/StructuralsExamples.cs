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

        public void BASEPattern()
        {
            var description = "";
            Helpers.SetTitle(nameof(BASEPattern), Statut.Title, description);

            Helpers.SetTitle(Statut.Bad.ToString(), Statut.Bad, "");

            Helpers.SetTitle(Statut.Good.ToString(), Statut.Good, "");
        }
    }
}