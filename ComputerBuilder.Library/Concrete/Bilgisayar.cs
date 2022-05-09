using System.Windows.Forms;
using ComputerBuilder.Library.Abstract;

namespace ComputerBuilder.Library.Concrete
{
    internal class Bilgisayar : Cisim 
    {

        public Bilgisayar(int panelGenisligi)
        {
            Left = (panelGenisligi - Width) / 2;
        }
    }
}
