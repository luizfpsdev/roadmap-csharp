using Recycle_web_api.Abstrations;

namespace Recycle_web_api.Services
{
    public class CicloDeVidaSingleton : ICiclodeVidaSingleton
    {
        public static int contador = 0;
        public CicloDeVidaSingleton()
        {
            contador++;
        }
        public int GetContador()
        {
            return contador;
        }
    }
}
