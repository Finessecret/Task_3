using System;
using System.Collections.Generic;
using System.Text;


namespace Vlados3
{
    enum Genre // перечисление жанров
    {
        Rock,
        Jazz,
        Pop,
    }
    class Musical_composition // музыкальная композиция
    {
        private int length; // длина музыкальной композиции
        private Genre genre;

        public Musical_composition(int length, Genre genre) // сам конструктор собственно
        {
            this.length = length;
            this.genre = genre;
        }

        public int get_length() // метод возвращения длины композиции
        {
            return length;
        }

        public Genre get_genre() // метод возвращения жанра композиции
        {
            return genre;
        }

    }
}
