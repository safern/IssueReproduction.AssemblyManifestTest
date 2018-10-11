using System.Buffers;

namespace AssemblyManifestTest
{
    public class Test
    {
        public void DoSomething()
        {
            byte[] test = ArrayPool<byte>.Shared.Rent(10);
        }
    }
}
