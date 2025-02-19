/* 

        Memento Design Pattern => Permet de faire un snapshot

*/

// Problème: Dans un editeur (Title: string, PrevTitles: List<string>, Content: string, PrevContents: List<string>) on stock les anciennes valeurs 
// dans une liste pour chaque champs concerné. Mais comment savoir, si undo (CTRL + Z) à quel liste le undo s'applique en dernier ?
//Solution: On créé une classe EditorState d'ou on stock les états de chaque champs (Title, Content) depuis une liste de EditorState (List<EditorState>)
// #### Attention #### Ici si on fait ça on viole le principe SOLID
// => Single Responsability Principle car Editor se retrouve avec plusieurs responsabilités:
// - Gestion des états
// - Features de l'éditeur
// => On doit donc créer un objet qui gère séparémment les états indépendamment de l'Editeur: Classe History (States: List, Editor: Editor | Backup(); UNdo();)


namespace DESIGNPATTERNS.BehavioralsDesignsPatterns.Memento
{
    public class Editor
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public EditorState CreateState()
        {
            return new EditorState(Title, Content);
        }

        public void Restore(EditorState state)
        {
            Title = state.GetTile();
            Content = state.GetContent();
        }
    }
}