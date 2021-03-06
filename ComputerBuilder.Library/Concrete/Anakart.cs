using System;
using System.Drawing;
using ComputerBuilder.Library.Abstract;

namespace ComputerBuilder.Library.Concrete
{
    internal class Anakart : Cisim
    {
        private static readonly Random Random = new Random();
        public Anakart(Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {
            Left = Random.Next(HareketAlaniBoyutlari.Width - Width + 1);
        }
    }
}
