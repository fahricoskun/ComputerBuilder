using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ComputerBuilder.Library.Enum;
using ComputerBuilder.Library.Interface;

namespace ComputerBuilder.Library.Concrete
{
    public class Oyun : IOyun
    {

        #region Alanlar

        private readonly Timer _gecenSureTimer = new Timer { Interval = 1000 };
        private readonly Timer _ramOlusturmaTimer = new Timer { Interval = 2000 };
        private TimeSpan _gecenSure;
        private readonly Panel _bilgisayarPanel;
        private Bilgisayar _bilgisayar;
        private readonly Panel _oyunAlaniPanel;
        private readonly List<Ram> _ramler = new List<Ram>();

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

        public Oyun(Panel bilgisayarPanel, Panel oyunAlaniPanel)
        {
            _bilgisayarPanel = bilgisayarPanel;
            _oyunAlaniPanel = oyunAlaniPanel;
            
            _gecenSureTimer.Tick += GecenSureTimer_Tick;
            _ramOlusturmaTimer.Tick += RamOlusturmaTimer_Tick;
        }

        private void GecenSureTimer_Tick(object sender, EventArgs e)
        {
            GecenSure += TimeSpan.FromSeconds(1);
        }

        private void RamOlusturmaTimer_Tick(object sender, EventArgs e)
        {
            RamOlustur();
        }

        public void Baslat()
        {
            if (DevamEdiyorMu) return;
            DevamEdiyorMu = true;
            _gecenSureTimer.Start();

            ZamanlayicilariBaslat();
            BilgisayarOlustur();
            RamOlustur();
        }

        private void RamOlustur()
        {
            var ram = new Ram(_oyunAlaniPanel.Size);

            _oyunAlaniPanel.Controls.Add(ram);
        }

        private void BilgisayarOlustur()
        {
            _bilgisayar = new Bilgisayar(_bilgisayarPanel.Width, _bilgisayarPanel.Size);

            _bilgisayarPanel.Controls.Add(_bilgisayar);
        }

        private void ZamanlayicilariBaslat()
        {
            _ramOlusturmaTimer.Start();
        }

        private void Bitir()
        {
            if (!DevamEdiyorMu) return;
            DevamEdiyorMu = false;
            _gecenSureTimer.Stop();
            ZamanlayicilariDurdur();
        }

        private void ZamanlayicilariDurdur()
        {
            _ramOlusturmaTimer.Stop();
        }
        public void BilgisayariHareketEttir(Yon yon)
        {
            if (!DevamEdiyorMu) return;

            _bilgisayar.HareketEttir(yon);
        }
        
        #endregion
    }
}
