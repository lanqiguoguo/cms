using System.Collections.Generic;
using System.Threading.Tasks;
using Datory;

namespace SSCMS.Abstractions
{
    public interface IContentCheckRepository : IRepository
    {

        Task InsertAsync(ContentCheck check);

        Task<List<ContentCheck>> GetCheckListAsync(int siteId, int channelId, int contentId);
    }
}