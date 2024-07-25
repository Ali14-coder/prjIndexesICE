namespace prjIndexesICE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Planet pluto = new Planet("pluto0111", "Terrestiral", 8600, "Golden Brown", true);

            Console.WriteLine(pluto[0]);
            Console.WriteLine(pluto[1]);
            Console.WriteLine(pluto[2]);
            Console.WriteLine(pluto[3]);
            Console.WriteLine(pluto[4]);

            Console.WriteLine();
            Console.WriteLine("Planet Name: " + pluto["planetname"]);
            Console.WriteLine("Planet Type: " + pluto["planettype"]);
            Console.WriteLine("Planet Mass: " + pluto["planetmass"]);
            Console.WriteLine("Planet Colour: " + pluto["planetcolour"]);
            Console.WriteLine("Planet Rings: " + pluto["planetrings"]);
        }
    }
}
