using Recycle_web_api.Abstrations;

namespace Recycle_web_api.Services
{
    public class CicloDeVidaService : ICicloDeVidaService
    {
        private static int contador;
        public CicloDeVidaService()
        {
            contador++;
        }
        public int GetContador()
        {
            return contador;
        }
    }
}
