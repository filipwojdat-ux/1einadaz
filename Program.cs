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




            