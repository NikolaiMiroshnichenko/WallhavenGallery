using System.Threading.Tasks;
using WallhavenGallery.Models;

namespace WallhavenGallery.Services.Interfaces
{
    public interface IRestApiClient
    {
        Task<ResponseModel> GetAsyncAll();
        Task<ResponseModel> GetAsyncByCategory(string category);
    }
}
