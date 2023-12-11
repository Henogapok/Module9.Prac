using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Prac
{
    public class Flash : Storage
    {
        /// <summary>
        /// Скорость в Мбайт/сек
        /// </summary>
        protected double Speed { get; set; }
        /// <summary>
        /// Объем в Гб
        /// </summary>
        protected double Size { get; set; }
        private double SizeMB { get; set; }

        public Flash(double Speed, double Size, string Name) : base(Name)
        {
            this.Name = Name;
            this.Speed = Speed;
            this.Size = Size;
            SizeMB = Size * 1024;
        }
        public override double CopyAllFiles()
        {
            double TimeForOneFile = 780 / Speed;
            int cnt = 0;
            while(SizeMB > 779)
            {
                SizeMB -= 780;
                cnt++;
            }
            Console.WriteLine($"Флешка заполнена, {cnt} файлов перенесено, затрачено {TimeForOneFile*cnt} секунд!");
            return TimeForOneFile * cnt;
        }

        public override double GetFreeSize()
        {
            return SizeMB/1024;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Name: {Name}\nType: Flash\nSpeed: {Speed}\n Size: {Size}\nFreeSize: {SizeMB}");
        }

        public override double GetSize()
        {
            return Size;
        }
    }
}
