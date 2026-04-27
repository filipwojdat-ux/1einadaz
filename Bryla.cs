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
