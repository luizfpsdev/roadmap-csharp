using Recycle_web_api.Abstrations;

namespace Recycle_web_api.Services
{
    public class CicloDeVidaService : ICicloDeVidaService
    {
        public int contador = 0;
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
