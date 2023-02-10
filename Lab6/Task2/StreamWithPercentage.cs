namespace Task2
{
    public abstract class StreamDecorator : Stream
    {
        protected Stream Str;

        public StreamDecorator(Stream stream)
        {
            Str = stream;
        }

        public override bool CanRead => Str.CanRead;
        public override bool CanSeek => Str.CanSeek;
        public override bool CanWrite => Str.CanWrite;
        public override long Length => Str.Length;
        public override long Position { get => Str.Position; set => Str.Position = value; }

        public override void Flush()
        {
            Str.Flush();
        }
        public override int Read(byte[] buffer, int offset, int count)
        {
            return Str.Read(buffer, offset, count);
        }
        public override long Seek(long offset, SeekOrigin origin)
        {
            return Str.Seek(offset, origin);
        }
        public override void SetLength(long value)
        {
            Str.SetLength(value);
        }
        public override void Write(byte[] buffer, int offset, int count)
        {
            Str.Write(buffer, offset, count);
        }
    }

    public class StreamWithPercentage : StreamDecorator
    {
        public StreamWithPercentage(Stream stream) : base(stream) { }

        public int Percentage { get; private set; }
        public override int Read(byte[] buffer, int offset, int count)
        {
            int res = base.Read(buffer, offset, count);
            Percentage = (int)(Position * 100 / Length);
            return res;
        }
    }
}