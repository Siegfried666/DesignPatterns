namespace DESIGNPATTERNS.BehavioralsDesignsPatterns.Strategy.BAD
{

    /*
    Problèmes => Cet exemple viole le principe OCP car si on ajoute un overlay ou un compressor aux enum existants, on est obligé de modifier
    la classe VideoStorage
    */
    public class VideoStorage
    {
        private Compressors _compressors;
        private Overlays _overlays;

        public VideoStorage(Compressors compressors, Overlays overlays = Overlays.None)
        {
            _compressors = compressors;
            _overlays = overlays;
        }

        public void SetCompressor(Compressors compressors)
        {
            _compressors = compressors;
        }

        public void SetOverlay(Overlays overlays)
        {
            _overlays = overlays;
        }

        public void Store(string fileName)
        {
            // Compression logic
            if (_compressors == Compressors.MOV)
            {
                System.Console.WriteLine("Compressing using MOV");
            }
            else if (_compressors == Compressors.MP4)
            {
                System.Console.WriteLine("Compressing using MP4");
            }
            else if (_compressors == Compressors.WEBM)
            {
                System.Console.WriteLine("Compressing using WEBM");
            }

            // Overlay logic
            if (_overlays == Overlays.BlackAndWhite)
            {
                System.Console.WriteLine("Applying BlackAndWhite overlay");
            }
            else if (_overlays == Overlays.Blur)
            {
                System.Console.WriteLine("Applying Blur overlay");
            }
            else if (_overlays == Overlays.None)
            {
                System.Console.WriteLine("Applying None overlay");
            }

            System.Console.WriteLine("Storing video to " + fileName + "." + _compressors);
        }
    }
}