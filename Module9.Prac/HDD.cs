using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Prac
{
    internal class HDD : Storage
    {
        /// <summary>
        /// Speed - скорость в Мбайт/сек
        /// </summary>
        protected double Speed { get; set; }
        /// <summary>
        /// Количество разделов
        /// </summary>
        protected int CountOfPartitions { get; set; }
        /// <summary>
        /// Размер одного раздела
        /// </summary>
        protected double OnePartSize { get; set; }
        protected double Size { get; set; }
        private double SizeMB { get; set; }

        public HDD(double Speed, int CountOfPartitions, double OnePartSize, string Name) : base(Name)
        {
            this.Name = Name;
            this.Speed = Speed;
            this.CountOfPartitions = CountOfPartitions;
            this.OnePartSize = OnePartSize;
            Size = OnePartSize * CountOfPartitions;
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
            Console.WriteLine($"Name: {Name}\nType: HDD\nSpeed: {Speed}\nPartititions: {CountOfPartitions} partitions with {OnePartSize} per one\n" +
                $"Size: {Size}\nFreeSize: {SizeMB}");
        }

        public override double GetSize()
        {
            return Size;
        }
    }
}
