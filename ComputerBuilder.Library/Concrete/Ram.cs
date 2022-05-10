using System;
using System.Drawing;
using ComputerBuilder.Library.Abstract;

namespace ComputerBuilder.Library.Concrete
{
    internal class Ram : Cisim
    {
        private static readonly Random Random = new Random();

        public Ram(Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {
            HareketMesafesi = (int)(Height * .1);
            Left = Random.Next(HareketAlaniBoyutlari.Width - Width + 1);
        }
    }
}
