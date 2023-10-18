using System.Threading;
using System.Threading.Tasks;
using ZendeskApi.Client.Models;
using ZendeskApi.Client.Responses;

namespace ZendeskApi.Client.Resources.Interfaces
{
    public interface ITagsResource
    {
        #region List
        /// <summary>
        /// Lists all tags. This request is paginated.
        /// </summary>
        Task<TagResponse> GetAllAsync(
            CursorPager cursor = null,
            CancellationToken cancellationToken = default(CancellationToken));

        #endregion
    }
}

