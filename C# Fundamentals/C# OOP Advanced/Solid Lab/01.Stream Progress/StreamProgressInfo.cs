namespace _01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private IPlayable file;

        // If we want to stream a music file, we can't
        public StreamProgressInfo(IPlayable file)
        {
            this.file = file;
        }

        public int CalculateCurrentPercent()
        {
            return (this.file.BytesSent * 100) / this.file.Length;
        }
    }
}