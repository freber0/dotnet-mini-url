namespace MiniUrl.Controllers
{
    public class ServiceLocator
    {
        private static MiniUrlService _urlService;

        public MiniUrlService GetInstance()
        {
            return _urlService ?? (_urlService = new MiniUrlService());
        }
    }
}