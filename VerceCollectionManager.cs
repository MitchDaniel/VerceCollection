using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HW_modul_12_part_02
{
    internal static class VerceCollectionManager
    {
        public static void Save(VerceCollection verseCellection, string fileParth)
        {
            if(verseCellection is null) throw new ArgumentNullException();
            if(fileParth is null) throw new ArgumentNullException();
            if(!File.Exists(fileParth)) throw new FileNotFoundException();
            using (StreamWriter writer = new StreamWriter(fileParth))
            {
                foreach (var verse in verseCellection)
                {
                    writer.WriteLine(verse.Name);
                    writer.WriteLine(verse.AuthorName);
                    writer.WriteLine(verse.Year);
                    writer.WriteLine(verse.TextVerse);
                    writer.WriteLine(verse.Theme);
                }
            }
        }

        public static void Load(out VerceCollection verseCellection, string fileParth)
        {
            if (fileParth is null) throw new ArgumentNullException();
            if (!File.Exists(fileParth)) throw new FileNotFoundException();
            verseCellection = new VerceCollection();
            using (StreamReader reader = new StreamReader(fileParth))
            {
                while (!reader.EndOfStream)
                {
                    string tempName = reader.ReadLine();
                    string tempAuthorName = reader.ReadLine();
                    int tempYearName = Convert.ToInt32(reader.ReadLine());
                    string tempTextVerse = reader.ReadLine();
                    string tempTheme = reader.ReadLine();
                    verseCellection.Add(new Verse(tempName, tempAuthorName, tempYearName, tempTextVerse, tempTheme));
                }
            }
        }
    }
}
