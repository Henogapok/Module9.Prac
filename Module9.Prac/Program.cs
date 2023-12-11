using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Storage> storages = new List<Storage>();
            storages.Add(new Flash(100, 16, "Flash1"));
            storages.Add(new DVD(1, 10, "DVD1"));
            storages.Add(new DVD(2, 12, "DVD2"));
            storages.Add(new HDD(200, 2, 240, "HDD1"));

            double AllStoragesSize = 0;
            foreach (Storage s in storages)
            {
                AllStoragesSize += s.GetSize();
                s.GetInfo();
            }
            double TimeSpent = 0;
            foreach(Storage s in storages)
            {
                TimeSpent += s.CopyAllFiles();
            }
            Console.WriteLine("Общее потраченное время: {0}", TimeSpent);
            foreach (Storage s in storages)
            {
                Console.WriteLine($"Свободное место на {s.Name}: {s.GetFreeSize()}");
            }

        }
    }
}
