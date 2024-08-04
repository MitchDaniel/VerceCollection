using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HW_modul_12_part_02
{
    static internal class VerceReport
    {
        public static VerceCollection Create(VerceCollection verseCollection ,Predicate<Verse> findPredicate)
        {
            if (findPredicate is null) throw new ArgumentNullException();
            if(verseCollection is null) throw new ArgumentNullException();
            VerceCollection temp = new VerceCollection();
            foreach (var verse in verseCollection)
            {
                if(findPredicate(verse))
                {
                    temp.Add(verse);
                }
            }
            if (temp.Count == 0) throw new Exception("Verce not found");
            return temp;
        }
    }
}
