namespace BackPack
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BackpackAlg alg = new BackpackAlg();
            alg.InitializeMatrix();
            alg.Compute();
            alg.Print();
        }
    }
}