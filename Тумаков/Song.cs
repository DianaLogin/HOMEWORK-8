using System;

namespace Тумаков
{
    internal class Song
    {
        public string name; //название песни
        public string author; //автор песни
        public Song prev; //связь с предыдущей песней в списке

        //метод для заполнения поля name
        public void FillName(string value)
        {
            name = value;
        }

        //метод для заполнения поля author
        public void FillAuthor(string value)
        {
            author = value;
        }

        //метод для заполнения поля prev
        public void FillPrev(Song value)
        {
            prev = value;
        }

        /// <summary>
        /// Mетод для печати названия песни и ее исполнителя
        /// </summary>
        /// <param name="name"></param>
        /// <param name="author"></param>
        public string Title()
        {
            return "Песня" + name + "написана автором" + author;
        }

        /// <summary>
        /// Mетод, который сравнивает между собой два объекта:
        /// </summary>
        /// <param name="enother_song"></param>
        /// <returns></returns>
        public bool Equals(Song another_song)
        {
            return another_song.name == name && another_song.author == author;
        }

        //=================== Конструкторы для Домашнего задания 9.1 ====================

        /// <summary>
        /// Конструктор по умолчанию (без параметров), чтоб можно было создать объект класса
        /// </summary>
        public Song() { }

        /// <summary>
        /// Конструктор класса Песня с инициализацией предыдущей песни = null
        /// </summary>
        /// <param name="name"></param>
        /// <param name="author"></param>
        public Song(string name, string author)
        {
            this.name = name;
            this.author = author;

            prev = null;
        }

        /// <summary>
        /// Конструктор класса Песня
        /// </summary>
        /// <param name="name"></param>
        /// <param name="author"></param>
        /// <param name="prev"></param>
        public Song (string name, string author, Song prev)
        {
            this.name = name;
            this.author = author;
            this.prev = prev;
        }

        

    }
}
