using Content.Api.Models;

namespace Content.Api.Servicesk
{
    public interface IContentService
    {
        ContentItem GetById(Guid id);
        IEnumerable<ContentItem> GetContentItems();
    }
}