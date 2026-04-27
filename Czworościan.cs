namespace ConsoleApp5
{
    internal class Czworościan : Bryla
    {
        public Czworościan(double polePodstawy) : base(polePodstawy)
        {
        }

        public override double ObliczObjetosc()
        {
            
            double a = Math.Sqrt(4 * polePodstawy / Math.Sqrt(3));
            return Math.Pow(a, 3) / (6 * Math.Sqrt(2));
        }

        public override double ObliczPoleCalosci()
        {
            
            return 4 * polePodstawy;
        }
    }
}

