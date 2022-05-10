using System.Drawing;
using ComputerBuilder.Library.Enum;

namespace ComputerBuilder.Library.Interface
{
    internal interface IHareketEden
    {
        Size HareketAlaniBoyutlari { get; }

        int HareketMesafesi { get; }
        
        /// <summary>
        /// Cismi istenilen yönde hareket ettirir
        /// </summary>
        /// <param name="yon">hangi yöne hareket edileceği</param>
        /// <returns>cisim duvara çarparsa true döndür</returns>
        bool HareketEttir(Yon yon);
    }
}
