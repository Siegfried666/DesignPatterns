/*
    Permet de respecter l'OCP => Si on souhaite créer un nouveau compressor, on n'a pas à modifier la classe VideoStorage, juste à créer une nouvelle interface
    et à l'implémenter dans un objet concret
*/

namespace DESIGNPATTERNS.BehavioralsDesignsPatterns.Strategy.GOOD
{
    public class VideoStorage
    {
        private ICompressor _compressor;
        private IOverlay _overlay;

        public VideoStorage(ICompressor compressor, IOverlay overlay)
        {
            _compressor = compressor;
            _overlay = overlay;
        }

        public void SetCompressor(ICompressor compressor)
        {
            _compressor = compressor;
        }

        public void SetOverlay(IOverlay overlay)
        {
            _overlay = overlay;
        }

        public void Store(string fileName)
        {
            _compressor.Compress();
            _overlay.Apply();

            System.Console.WriteLine("Storing video to " + fileName + "." + _compressor);
        }
    }
}