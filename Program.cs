using Microsoft.VisualBasic;

namespace CSharp_HW_modul_12_part_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VerceCollection verses = new VerceCollection();
            //verses.Add(new Verse("He Wishes for the Cloths of Heaven", 
            //                    "William Butler Yeats", 
            //                    2002,
            //                    "Had I the heaven's embroidered cloths, Enwrought with golden and silver light, The blue and the dim and the dark cloths Of night and light and the half-light, I would spread the cloths under your feet: But I, being poor, have only my dreams; I have spread my dreams under your feet; Tread softly because you tread on my dreams.",
            //                    "Love"),
            //           new Verse("Pinnocio", "Disney", 1940, 
            //           "I've got no strings To hold me down To make me fret, or make me frown I had strings But now I'm free There are no strings on me", "Fredom"));
            //VerceCollectionManager.Save(verses, @"C:\Users\Brill\Desktop\Source.txt");
            VerceCollectionManager.Load(out VerceCollection temp, @"C:\Users\Brill\Desktop\Source.txt");
            var result = VerceReport.Create(temp, x => x.Theme == "Fredom");
            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }


        }
    }
}

//Задание 1:
//Создайте приложение для работы с коллекцией стихов. Необходимо хранить такую информацию:
// Название стиха
// ФИО автора
// Год написания
// Текст стиха
// Тема стиха
//Приложение должно позволять:
// Добавлять стихи
// Удалять стихи
// Изменять информацию о стихах
// Искать стих по разным характеристикам
// Сохранять коллекцию стихов в файл
// Загружать коллекцию стихов из файла

//Задание 2:
//Добавьте к приложению из первого задания возможность генерировать отчёты.
//Отчёт может быть отображён на экран или сохранён в файл. Создайте такие отчёты:
// По названию стиха
// По ФИО автора
// По теме стиха
// По слову в тексте стиха
// По году написания стиха
// По длине стиха
