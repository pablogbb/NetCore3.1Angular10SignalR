using DAL;
using Microsoft.AspNetCore.Hosting;


namespace BLL
{
    public class PqrService
    {
        private readonly PqrRepository pqrRepository;        
        private IHostingEnvironment hostingEnvironment;
        public PqrService(PqrRepository _pqrRepository,                        
                          IHostingEnvironment _hostingEnvironment
                          )
        {
            pqrRepository = _pqrRepository;           
            hostingEnvironment = _hostingEnvironment;
        }
    }
}
