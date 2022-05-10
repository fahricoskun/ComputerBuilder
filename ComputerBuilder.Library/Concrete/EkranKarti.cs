using System;
using System.Drawing;
using ComputerBuilder.Library.Abstract;

namespace ComputerBuilder.Library.Concrete
{
    internal class EkranKarti : Cisim
    {
        private static readonly Random Random = new Random();
        public EkranKarti(Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {
            Left = Random.Next(HareketAlaniBoyutlari.Width - Width + 1);
        }
    }
}
