using PhotoStore.Core.Abstractions;
using PhotoStore.Core.Domain;

namespace PhotoStore.Infrastructure.Repositories;

public sealed class InMemoryAlbumRepository : IAlbumRepository
{
    // IDs fixos 
    public static readonly Guid WeddingAlbumId = Guid.Parse("11111111-1111-1111-1111-111111111111");
    public static readonly Guid PortraitAlbumId = Guid.Parse("22222222-2222-2222-2222-222222222222");

    private readonly List<Album> _albums =
    [
        new Album(
            id: WeddingAlbumId,
            title: "Wedding - Sofia & Miguel",
            coverUrl: "/images/albums/wedding-cover.jpg",
            category: "Wedding",
            eventDate: new DateOnly(2024, 6, 15)
        ),
        new Album(
            id: PortraitAlbumId,
            title: "Portrait Session - Rita",
            coverUrl: "/images/albums/portrait-cover.jpg",
            category: "Portrait",
            eventDate: new DateOnly(2024, 9, 2)
        )
    ];

    public Task<IReadOnlyList<Album>> GetPublicAsync(CancellationToken ct = default)
        => Task.FromResult<IReadOnlyList<Album>>(_albums);

    public Task<Album?> GetByIdAsync(Guid albumId, CancellationToken ct = default)
        => Task.FromResult(_albums.FirstOrDefault(a => a.Id == albumId));
}
