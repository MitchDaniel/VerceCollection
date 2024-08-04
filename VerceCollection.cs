using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HW_modul_12_part_02
{
    internal class VerceCollection : IEnumerable<Verse>
    {
        List<Verse> _versesList = new List<Verse>();

        public int Count => _versesList.Count;

        public void Add(params Verse[] verses)
        {
            if (verses is null) throw new ArgumentNullException($"{nameof(verses)} is null");
            _versesList.AddRange(verses);
        }

        public void Delete(Verse verse)
        {
            if (verse is null) throw new ArgumentNullException($"{nameof(verse)} is null");
            _versesList.Remove(verse);
        }

        public Verse Find(Predicate<Verse> findPredicate)
        {
            if (findPredicate is null) throw new ArgumentNullException($"{nameof(findPredicate)} is null");
            foreach (var verse in _versesList)
            {
                if(findPredicate(verse))
                {
                    return verse;
                }
            }
            throw new Exception("Verse not found");
        }

        public void Edit(Verse oldVerse, Verse newVerse)
        {
            if(oldVerse is null) throw new ArgumentNullException($"{nameof(oldVerse)} is null");
            if(newVerse is null) throw new ArgumentNullException($"{nameof(newVerse)} is null");
            for (int i = 0; i < _versesList.Count; i++)
            {
                if (_versesList[i] == oldVerse)
                {
                    _versesList[i] = newVerse;
                    return;
                }
            }
            throw new Exception("Verse not found");
        }

        public IEnumerator<Verse> GetEnumerator()
        {
            return _versesList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
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