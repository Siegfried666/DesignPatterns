/* Begavioral Design Patterns
Les Design Patterns Bahaviorial concernent l'interaction entre les objets
Permet de résoudre des problèmes de communication, de responsabilité et d'algorithmique
Separation of concern: séparations entre les objets et les classes
*/

/* 

        Memento Design Pattern => Permet de faire un snapshot

*/

using DESIGNPATTERNS.BehavioralsDesignsPatterns.Memento;

var editor = new Editor();
var history = new History(editor);
history.Backup();
editor.Title = "Test";
history.Backup();
editor.Content = "Hello there, my name is Freddy";
history.Backup();
editor.Title = "The live of a dev: my mementos";

Console.WriteLine("Title: " + editor.Title);
Console.WriteLine("Content: " + editor.Content);

history.Undo();

Console.WriteLine("Title: " + editor.Title);
Console.WriteLine("Content: " + editor.Content);

history.ShowHistory();

history.Undo();
Console.WriteLine("Title: " + editor.Title);
Console.WriteLine("Content: " + editor.Content);
history.Undo();
Console.WriteLine("Title: " + editor.Title);
Console.WriteLine("Content: " + editor.Content);