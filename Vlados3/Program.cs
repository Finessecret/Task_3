using System;

namespace Vlados3
{
    class Program
    {
        static void Main(string[] args)
        {
            Musical_assembly assembly = new Musical_assembly(); // создал музыкальное собрание и добавил композиции

            Musical_composition jazz1 = new Musical_composition(60, Genre.Jazz);
            Musical_composition jazz2 = new Musical_composition(120, Genre.Jazz);
            Musical_composition jazz3 = new Musical_composition(90, Genre.Jazz);
            Musical_composition jazz4 = new Musical_composition(150, Genre.Jazz);

            assembly.Add_composition(jazz1);
            assembly.Add_composition(jazz2);
            assembly.Add_composition(jazz3);
            assembly.Add_composition(jazz4);

            Musical_composition rock1 = new Musical_composition(60, Genre.Rock);
            Musical_composition rock2 = new Musical_composition(120, Genre.Rock);
            Musical_composition rock3 = new Musical_composition(90, Genre.Rock);
            Musical_composition rock4 = new Musical_composition(150, Genre.Rock);

            assembly.Add_composition(rock1);
            assembly.Add_composition(rock2);
            assembly.Add_composition(rock3);
            assembly.Add_composition(rock4);

            Musical_composition pop1 = new Musical_composition(60, Genre.Pop);
            Musical_composition pop2 = new Musical_composition(120, Genre.Pop);
            Musical_composition pop3 = new Musical_composition(90, Genre.Pop);
            Musical_composition pop4 = new Musical_composition(150, Genre.Pop);

            assembly.Add_composition(pop1);
            assembly.Add_composition(pop2);
            assembly.Add_composition(pop3);
            assembly.Add_composition(pop4);

            Console.WriteLine("Вывод жанра композиций с длиной в пределах 70-100:");
            foreach (Musical_composition composition in assembly.assembly_sort_by_time(70, 100))
            {
                Console.WriteLine(composition.get_length());
                Console.WriteLine(composition.get_genre());
            }

            Console.WriteLine("Вывод жанра каждой композиции собрания:");
            foreach (Musical_composition composition in assembly.get_sorted_assembly())
            {                 
                Console.WriteLine(composition.get_genre());
            }
        }
    }
}
