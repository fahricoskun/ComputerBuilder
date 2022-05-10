using System;
using System.Windows.Forms;
using ComputerBuilder.Library.Concrete;
using ComputerBuilder.Library.Enum;

namespace ComputerBuilder
{
    public partial class AnaForm : Form
    {
        private readonly Oyun _oyun;
        public AnaForm()
        {
            InitializeComponent();

            _oyun = new Oyun(bilgisayarPanel,oyunAlaniPanel);
            _oyun.GecenSureDegisti += Oyun_GecenSureDegisti;
        }


        private void Oyun_GecenSureDegisti(object sender, EventArgs e)
        {
            sureLabel.Text = _oyun.GecenSure.ToString(@"m\:ss");
        }


        private void AnaForm_KeyDown_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    _oyun.Baslat();
                    break;
                case Keys.Right:
                    _oyun.BilgisayariHareketEttir(Yon.Saga);
                    break;
                case Keys.Left:
                    _oyun.BilgisayariHareketEttir(Yon.Sola);
                    break;
            }
        }
    }
}
