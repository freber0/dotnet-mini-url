using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MiniUrl.Controllers
{
    public class MiniUrlService
    {
        private Dictionary<string, string> _shortGuidUrlMapper = new Dictionary<string, string>();
        public MiniUrlService()
        {
        }

        public string ShrinkUrl(string url)
        {
            string shortGuid = GenerateShortGuid();
            _shortGuidUrlMapper.Add(shortGuid, url);
            return shortGuid;
        }

        public string GetUrlFromGuid(string guid)
        {
            string url;
            if(!_shortGuidUrlMapper.TryGetValue(guid, out url))
            {
                return "error";
            }
            return url;
        }

        private string GenerateShortGuid()
        {
            Guid guid = Guid.NewGuid();
            string shortGuid = Convert.ToBase64String(guid.ToByteArray());
            string trimedGuid = shortGuid.Trim('=');
            return trimedGuid;
        }
    }
}
