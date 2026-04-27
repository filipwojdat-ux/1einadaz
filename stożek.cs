namespace ConsoleApp5
{
    internal class stożek : Bryla
    {
        //Stwórz klasę abstrakcyjną Bryla dla ostrosłupów.  Stwórz dwie klasy potomne, stożek i  czworościan. Stwórz listę brył zawierającą 2 stożki i 3 czworościany. 

        private double r;
        public stożek(double polePodstawy, double r) : base(polePodstawy)
        {
            this.r = r;
        }
        public override double ObliczObjetosc()
        {
            return (1.0 / 3.0) * polePodstawy * r;
        }
        public override double ObliczPoleCalosci()
        {
            return polePodstawy + Math.PI * r * Math.Sqrt(r * r + polePodstawy);
        }
       
        
    }
}
