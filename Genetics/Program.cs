using Genetics;

public class Program
{
    public static void Main()
    {

        
        Animal human = new Biped("humain");
        Animal monkey = new Biped("singe");
        List<Animal> bipeds = [human, monkey];

        Console.WriteLine("ANIMAUX BIPEDES:");

        foreach (Biped biped in bipeds)
        {
            Console.WriteLine($"Nom: {biped.Name}");
            Console.WriteLine($"Nombre de pattes: {biped.NumberOfLegs}");
            biped.Move();
            biped.Eat();
            Console.WriteLine();
        }

        List<Quadruped> quadrupeds = new List<Quadruped>();
        Animal elephant = new Quadruped("éléphant");
        quadrupeds.Add((Quadruped)elephant);
        
        Animal turtle = new Quadruped("tortue");
        quadrupeds.Add((Quadruped)turtle);

        Animal lezard= new Quadruped("lézard");
        quadrupeds.Add((Quadruped)lezard);

       Console.WriteLine("\nANIMAUX QUADRUPEDES:");
        foreach (Quadruped quadruped in quadrupeds)
        {
            Console.WriteLine($"Nom: {quadruped.Name}");
            Console.WriteLine($"Nombre de pattes: {quadruped.NumberOfLegs}");
            quadruped.Move();
            quadruped.Eat();
            Console.WriteLine();
        }
         
    }
}