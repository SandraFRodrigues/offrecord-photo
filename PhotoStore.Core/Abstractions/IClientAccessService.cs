namespace PhotoStore.Core.Abstractions;

public interface IClientAccessService
{
    Task<bool> CanAccessAlbumAsync(Guid clientId, Guid albumId, CancellationToken ct = default);
    Task<bool> HasPurchasedPhotoAsync(Guid clientId, Guid photoId, CancellationToken ct = default);
}