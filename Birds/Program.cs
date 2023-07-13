using Birds.Birds;

public class Program
{
    public static void Main(string[] args)
    {
        var  glassBird = new GlassBird();
        glassBird.makeFly();


        var parrot = new Parrot();
        parrot.makeFly();

        var e = new Eagle();
        e.makeFly();

    }
}







