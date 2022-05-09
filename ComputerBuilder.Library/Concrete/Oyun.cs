using System;
using System.Drawing;
using System.Windows.Forms;
using ComputerBuilder.Library.Enum;
using ComputerBuilder.Library.Interface;

namespace ComputerBuilder.Library.Concrete
{
    public class Oyun : IOyun
    {

        #region Alanlar

        private readonly Timer _gecenSureTimer = new Timer { Interval = 1000 };
        private TimeSpan _gecenSure;
        private readonly Panel _bilgisayarPanel;

        #endregion

        #region Olaylar

        public event EventHandler GecenSureDegisti;

        #endregion

        #region Özellikler
        public bool DevamEdiyorMu { get; private set; }
        public TimeSpan GecenSure 
        {
            get => _gecenSure; 
            private set
            {
                _gecenSure = value;

                GecenSureDegisti?.Invoke(this, EventArgs.Empty);
            }
        }

        #endregion

        #region Metotlar

        TimeSpan IOyun.GecenSure => throw new NotImplementedException();

        public Oyun(Panel bilgisayarPanel)
        {
            _bilgisayarPanel = bilgisayarPanel;
            _gecenSureTimer.Tick += GecenSureTimer_Tick;
        }

        private void GecenSureTimer_Tick(object sender, EventArgs e)
        {
            GecenSure += TimeSpan.FromSeconds(1);
        }

        public void Baslat()
        {
            if (DevamEdiyorMu) return;
            DevamEdiyorMu = true;
            _gecenSureTimer.Start();

            BilgisayarOlustur();
        }

        private void BilgisayarOlustur()
        {
            var bilgisayar = new Bilgisayar(_bilgisayarPanel.Width)
            {
                Image = Image.FromFile(@"Görseller\Bilgisayar.png")
            };
            _bilgisayarPanel.Controls.Add(bilgisayar);
        }

        private void Bitir()
        {
            if (!DevamEdiyorMu) return;
            DevamEdiyorMu = false;
            _gecenSureTimer.Stop();    
        }
        public void BilgisayariHareketEttir(Yon yon)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
