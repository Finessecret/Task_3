using System;
using System.Collections.Generic;
using System.Text;

namespace Vlados3
{
    class Musical_assembly
    {
        List<Musical_composition> assembly = new List<Musical_composition>(); // класс музыкальное собрание в виде списка музыкальных композиций
        public List<Musical_composition> get_assembly() // метод возращающий собрание
        {
            return assembly;
        }
        public void Add_composition(Musical_composition composition) // метода добавления
        {
            assembly.Add(composition);
        }
        public void Remove_composition(Musical_composition composition) // метод удаления
        {
            assembly.Remove(composition);
        }
        public List<Musical_composition> get_sorted_assembly() // сортировка собрания по жанрам
        {
            List<Musical_composition> sorted_assambly = new List<Musical_composition>();

            List<Musical_composition> rock = new List<Musical_composition>();
            List<Musical_composition> jazz = new List<Musical_composition>();
            List<Musical_composition> pop = new List<Musical_composition>();

            foreach (Musical_composition composition in assembly)
            {
                if (composition.get_genre() == Genre.Rock)
                {
                    rock.Add(composition);
                }
                if (composition.get_genre() == Genre.Jazz)
                {
                    jazz.Add(composition);

                }
                if (composition.get_genre() == Genre.Pop)
                {
                    pop.Add(composition);
                }
            }
            sorted_assambly.AddRange(rock);
            sorted_assambly.AddRange(jazz);
            sorted_assambly.AddRange(pop);
            return sorted_assambly;
        }
        public int get_assembly_length() // вовзращение длины композиции в собрании
        {
            int length = 0;
            foreach (Musical_composition composition in assembly)
            {
                length += composition.get_length();
            }
            return length;
        }
        public List<Musical_composition> assembly_sort_by_time(int min_time, int max_time) // выборка мелодий собрания по длине композиции
        {
            List<Musical_composition> compositions = new List<Musical_composition>();
            foreach (Musical_composition composition in assembly)
            {
                if ((composition.get_length() > min_time) && (composition.get_length() < max_time))
                {
                    compositions.Add(composition);
                }
            }
            return compositions;
        }
    }
}
