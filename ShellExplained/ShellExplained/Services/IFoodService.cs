using Refit;
using ShellExplained.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShellExplained.Services
{
    public interface IFoodService
    {                
        [Get("/search?key={apiKey}&q={query}")]
        Task<ApiResponse<dynamic>> GetRecipes(string query, string apiKey);
    }
}
