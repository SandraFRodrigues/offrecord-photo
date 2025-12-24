using PhotoStore.Core.Domain;

namespace PhotoStore.Core.Abstractions;

public interface IAlbumRepository
{
    Task<IReadOnlyList<Album>> GetPublicAsync(CancellationToken ct = default);
    Task<Album?> GetByIdAsync(Guid albumId, CancellationToken ct = default);
}
