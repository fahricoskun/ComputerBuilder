using System;
using System.Drawing;
using ComputerBuilder.Library.Abstract;

namespace ComputerBuilder.Library.Concrete
{
    internal class Ram : Cisim
    {
        public Ram(Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {
            var random = new Random();
            Left = random.Next(HareketAlaniBoyutlari.Width - Width + 1);
        }
    }
}
