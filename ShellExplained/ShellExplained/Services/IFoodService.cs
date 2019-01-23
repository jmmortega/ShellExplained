using Refit;
using System.Threading.Tasks;

namespace ShellExplained.Services
{
    public interface IFoodService
    {                
        [Get("/search?key={apiKey}&q={query}")]
        Task<ApiResponse<dynamic>> GetRecipes(string query, string apiKey);

        [Get("/get?key={apiKey}&rId={id}")]
        Task<ApiResponse<dynamic>> GetRecipeDetail(string id, string apiKey);
    }
}
