using System.Drawing;
using ComputerBuilder.Library.Abstract;

namespace ComputerBuilder.Library.Concrete
{
    internal class Bilgisayar : Cisim 
    {

        public Bilgisayar(int panelGenisligi, Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {
            Center = panelGenisligi / 2;
            HareketMesafesi = Width;
        }
    }
}
