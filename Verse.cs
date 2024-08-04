using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HW_modul_12_part_02
{
    internal class Verse
    {
        public Verse(string name, string authorName, int year, string textVerce, string theme)
        {
            Name = name; 
            AuthorName = authorName;
            Year = year;
            TextVerse = textVerce;
            Theme = theme;
        }
        public string Name { get; set; }

        public string AuthorName {  get; set; }

        public int Year { get; set; }

        public string TextVerse { get; set; }

        public string Theme { get; set; }
    }
}
//Создайте приложение для работы с коллекцией стихов. Необходимо хранить такую информацию:
// Название стиха
// ФИО автора
// Год написания
// Текст стиха
// Тема стиха