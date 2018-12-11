using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace api1.Services
{
    public class NameService : INameService
    {
        private readonly string _nameurl="http://name-api/api/values"; 
        public async Task<string> GetName()
        {
            return await _nameurl.GetStringAsync();
        }
    }
}