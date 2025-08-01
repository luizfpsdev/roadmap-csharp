using Recycle_web_api.Abstrations;

namespace Recycle_web_api.Services
{
    public class CicloDeVidaTransientService : ICicloDeVidaTransientService
    {
        private static int contador;
        public CicloDeVidaTransientService()
        {
            contador++;
        }
        public int GetContador()
        {
            return contador;
        }
    }
}
