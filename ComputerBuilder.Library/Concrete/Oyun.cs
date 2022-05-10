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
        private readonly Timer _hareketTimer = new Timer { Interval = 100 };
        private readonly Timer _ramOlusturmaTimer = new Timer { Interval = 2000 };
        private readonly Timer _ekranKartiOlusturmaTimer = new Timer { Interval = 4000 };
        private readonly Timer _anaKartOlusturmaTimer = new Timer { Interval = 6000 };
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
            _hareketTimer.Tick += HareketTimer_Tick;
            _ramOlusturmaTimer.Tick += RamOlusturmaTimer_Tick;
            _ekranKartiOlusturmaTimer.Tick += EkranKartiOlusturmaTimer_Tick;
            _anaKartOlusturmaTimer.Tick += AnaKartOlusturmaTimer_Tick;
        }

        private void GecenSureTimer_Tick(object sender, EventArgs e)
        {
            GecenSure += TimeSpan.FromSeconds(1);
        }

        private void HareketTimer_Tick(object sender, EventArgs e)
        {
            RamleriHareketEttir();
        }

        private void RamleriHareketEttir()
        {
            foreach (var ram in _ramler)
            {
                ram.HareketEttir(Yon.Asagi);
            }
        }

        private void RamOlusturmaTimer_Tick(object sender, EventArgs e)
        {
            RamOlustur();
        }

        private void EkranKartiOlusturmaTimer_Tick(object sender, EventArgs e)
        {
            EkranKartıOlustur();
        }

        private void AnaKartOlusturmaTimer_Tick(object sender, EventArgs e)
        {
            AnakartOlustur();
        }
        public void Baslat()
        {
            if (DevamEdiyorMu) return;
            DevamEdiyorMu = true;
            _gecenSureTimer.Start();
            _hareketTimer.Start();

            ZamanlayicilariBaslat();
            BilgisayarOlustur();
            RamOlustur();
            EkranKartıOlustur();
            AnakartOlustur();
        }

        private void AnakartOlustur()
        {
            var anakart = new Anakart(_oyunAlaniPanel.Size);
            _oyunAlaniPanel.Controls.Add(anakart);
        }

        private void EkranKartıOlustur()
        {
            var ekrankartı = new EkranKartı(_oyunAlaniPanel.Size);
            _oyunAlaniPanel.Controls.Add(ekrankartı);
        }

        private void RamOlustur()
        {
            var ram = new Ram(_oyunAlaniPanel.Size);
            _ramler.Add(ram);
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
            _ekranKartiOlusturmaTimer.Start();
            _anaKartOlusturmaTimer.Start();
        }

        private void Bitir()
        {
            if (!DevamEdiyorMu) return;
            DevamEdiyorMu = false;
            _gecenSureTimer.Stop();
            _hareketTimer.Stop();
            ZamanlayicilariDurdur();
        }

        private void ZamanlayicilariDurdur()
        {
            _ramOlusturmaTimer.Stop();
            _ekranKartiOlusturmaTimer.Stop();
            _anaKartOlusturmaTimer.Stop();
        }
        public void BilgisayariHareketEttir(Yon yon)
        {
            if (!DevamEdiyorMu) return;

            _bilgisayar.HareketEttir(yon);
        }
        
        #endregion
    }
}
