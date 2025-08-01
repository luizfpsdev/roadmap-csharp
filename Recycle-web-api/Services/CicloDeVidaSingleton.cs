using Recycle_web_api.Abstrations;

namespace Recycle_web_api.Services
{
    public class CicloDeVidaSingleton : ICiclodeVidaSingleton
    {
        private static int contador;
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
