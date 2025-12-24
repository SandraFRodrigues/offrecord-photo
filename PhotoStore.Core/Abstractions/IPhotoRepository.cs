using PhotoStore.Core.Domain;

namespace PhotoStore.Core.Abstractions;

public interface IPhotoRepository
{
    Task<IReadOnlyList<Photo>> GetByAlbumAsync(Guid albumId, CancellationToken ct = default);
}
