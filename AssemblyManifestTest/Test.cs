using System.Buffers;

namespace AssemblyManifestTest
{
    class Test
    {
        public void DoSomething()
        {
            byte[] test = ArrayPool<byte>.Shared.Rent(10);
        }
    }
}
