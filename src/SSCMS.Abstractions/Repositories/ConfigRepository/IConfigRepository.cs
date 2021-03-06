using System.Threading.Tasks;
using Datory;

namespace SSCMS.Abstractions
{
    public partial interface IConfigRepository : IRepository
    {
        Task<int> InsertAsync(Config config);

        Task UpdateAsync(Config config);

        Task<bool> IsInitializedAsync();

        Task UpdateConfigVersionAsync(string productVersion);

        Task<bool> IsNeedInstallAsync();
    }
}
