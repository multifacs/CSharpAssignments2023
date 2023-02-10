namespace Task3
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

    public class StreamWithPassword : StreamDecorator
    {
        public StreamWithPassword(Stream stream, string password) : base(stream)
        {
            this.Password = password;
        }

        private string Password { get; set; }
        private string EnteredPassword = "";

        public void EnterPassword(string password)
        {
            EnteredPassword = password;
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            if (EnteredPassword != Password) { return -2; }
            EnteredPassword = "";
            return base.Read(buffer, offset, count);
        }
    }
}
