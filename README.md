namespace ConsoleApp5
{

    abstract class Bryla
    {
        protected double polePodstawy;

    
    public Bryla(double polePodstawy)
        {
            this.polePodstawy = polePodstawy;
        }
        public abstract double ObliczObjetosc();
        public abstract double ObliczPoleCalosci();
        public  double ObliczPolePodstawy()
        {
            return polePodstawy;
        }

        


    } }
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
using ConsoleApp5;

internal class Program
{
    private static void Main(string[] args)
    {
        //Stwórz klasę abstrakcyjną Bryla dla ostrosłupów.  Stwórz dwie klasy potomne, stożek i  czworościan. Stwórz listę brył zawierającą 2 stożki i 3 czworościany. 
        List<Bryla> bryly =
        [
            new stożek(5, 10),
            new stożek(3, 7),
            new Czworościan(4),
            new Czworościan(6),
            new Czworościan(8),
            ];
    }
}




            

