using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace api1.Services
{
    public class NameService : INameService
    {
        private readonly string _nameurl="https://www.qq.com/?fromdefault"; 
        public async Task<string> GetName()
        {
            return await _nameurl.GetStringAsync();
        }
    }
}