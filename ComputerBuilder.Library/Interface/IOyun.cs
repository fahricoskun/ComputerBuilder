using System;
using ComputerBuilder.Library.Enum;
namespace ComputerBuilder.Library.Interface
{
    internal interface IOyun
    {
        event EventHandler GecenSureDegisti;
        bool DevamEdiyorMu { get; }
        TimeSpan GecenSure { get; }
        void Baslat();
        void BilgisayariHareketEttir(Yon yon);
    }
}
