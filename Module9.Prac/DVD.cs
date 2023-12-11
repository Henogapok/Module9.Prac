using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Prac
{
    public class DVD : Storage
    {   
        /// <summary>
        /// DVDType - One = 1; Double = 2
        /// </summary>
        protected int Type { get; set; }
        /// <summary>
        /// Speed - Скорость в Мбайт/сек
        /// </summary>
        protected double Speed { get; set; }
        protected double Size { get; set; }
        private double SizeMB { get; set; }

        public DVD(int Type, double Speed, string Name) : base(Name)
        {
            this.Name = Name;
            this.Speed = Speed;
            this.Type = Type;
            if (Type == (int) DVDType.One) Size = 4.7;
            else Size = 9;
            SizeMB = Size * 1024;
        }


        public override double CopyAllFiles()
        {
            double TimeForOneFile = 780 / Speed;
            int cnt = 0;
            while (SizeMB > 779)
            {
                SizeMB -= 780;
                cnt++;
            }
            Console.WriteLine($"Флешка заполнена, {cnt} файлов перенесено, затрачено {TimeForOneFile * cnt} секунд!");
            return TimeForOneFile * cnt;
        }

        public override double GetFreeSize()
        {
            return SizeMB;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Name: {Name}\nType: DVD\nSpeed: {Speed}\n Size: {Size}\nFreeSize: {SizeMB}");
        }

        public override double GetSize()
        {
            return Size;
        }
    }
}
