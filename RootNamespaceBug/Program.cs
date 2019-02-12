using CSharpNamespace;
using VBNamespace;

namespace RootNamespaceBug
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var vb = new VBClass();
            var cs = new CSharpClass();
        }
    }
}