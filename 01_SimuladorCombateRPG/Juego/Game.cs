using System.Text;

namespace _01_SimuladorCombateRPG.Juego
{
    static internal class Game
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            string name = "Simulador de Combate RPG\n";
            Console.WriteLine(name);
            Character? mainCharacter = null;
            while (mainCharacter == null)
            {
                mainCharacter = ChooseCharacter();
            }
            Console.WriteLine("Tu personaje es: " + mainCharacter.name);
            Character boss = new Character("Orco Salvaje", new Statistics(140, 60, 0));
            Shop tienda = new Shop();
            tienda.ShowShopItems();
        }

        static Character? ChooseCharacter()
        {
            Console.WriteLine("Listado de personajes\n");
            Console.WriteLine("1) Guerrero (120hp - 80en)");
            Console.WriteLine("2) Mago (85hp - 120en)");
            Console.WriteLine("3) Arquero (100hp - 95en)\n");

            Console.Write("Escoge tu personaje: ");
            string? opt = Console.ReadLine();
            switch (opt)
            {
                case "1":
                    return new Character("Guerrero", new Statistics(120,80));
                case "2":
                    return new Character("Mago", new Statistics(85, 120));
                case "3":
                    return new Character("Arquero", new Statistics(100, 95));
                default:
                    Console.WriteLine("El personaje es incorrecto\n");
                    return null;
            }
        }
    }
}                     