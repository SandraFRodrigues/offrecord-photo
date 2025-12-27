using PhotoStore.Core.Abstractions;
using PhotoStore.Core.Domain;

namespace PhotoStore.Infrastructure.Repositories;

public sealed class InMemoryPhotoRepository : IPhotoRepository
{
    private readonly List<Photo> _photos =
    [
        // Wedding album photos 
        new Photo(Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
            Guid.Parse("11111111-1111-1111-1111-111111111111"),
            "/images/photos/wedding1.jpg",
            isLocked: true,
            price: 5m),

        new Photo(Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
            Guid.Parse("11111111-1111-1111-1111-111111111111"),
            "/images/photos/wedding2.jpg",
            isLocked: true,
            price: 5m),

        new Photo(Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc"),
            Guid.Parse("11111111-1111-1111-1111-111111111111"),
            "/images/photos/wedding3.jpg",
            isLocked: false,
            price: 5m),

        new Photo(Guid.Parse("dddddddd-dddd-dddd-dddd-dddddddddddd"),
            Guid.Parse("11111111-1111-1111-1111-111111111111"),
            "/images/photos/wedding4.jpg",
            isLocked: true,
            price: 5m),

        new Photo(Guid.Parse("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
            Guid.Parse("11111111-1111-1111-1111-111111111111"),
            "/images/photos/wedding5.jpg",
            isLocked: false,
            price: 5m),

        // Portrait album photos
        new Photo(Guid.Parse("f1f1f1f1-f1f1-f1f1-f1f1-f1f1f1f1f1f1"),
            Guid.Parse("22222222-2222-2222-2222-222222222222"),
            "/images/photos/portrait1.jpg",
            isLocked: true,
            price: 5m),

        new Photo(Guid.Parse("f2f2f2f2-f2f2-f2f2-f2f2-f2f2f2f2f2f2"),
            Guid.Parse("22222222-2222-2222-2222-222222222222"),
            "/images/photos/portrait2.jpg",
            isLocked: false,
            price: 5m),

        new Photo(Guid.Parse("f3f3f3f3-f3f3-f3f3-f3f3-f3f3f3f3f3f3"),
            Guid.Parse("22222222-2222-2222-2222-222222222222"),
            "/images/photos/portrait3.jpg",
            isLocked: true,
            price: 5m),
    ];

    public Task<IReadOnlyList<Photo>> GetByAlbumAsync(Guid albumId, CancellationToken ct = default)
        => Task.FromResult<IReadOnlyList<Photo>>(_photos.Where(p => p.AlbumId == albumId).ToList());
}
