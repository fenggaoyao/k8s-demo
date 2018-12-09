using System.Threading.Tasks;

namespace api1.Services
{
    public interface INameService
    {
         Task<string> GetName();
    }
}