using System;

namespace PhotoStore.Core.Domain;

public sealed class Photo
{
    public Guid Id { get; }
    public Guid AlbumId { get; }
    public string Url { get; }
    public bool IsLocked { get; }
    public decimal Price { get; }

    public Photo(Guid id, Guid albumId, string url, bool isLocked, decimal price)
    {
        if (id == Guid.Empty) throw new ArgumentException("Photo id is required.", nameof(id));
        if (albumId == Guid.Empty) throw new ArgumentException("Album id is required.", nameof(albumId));
        if (string.IsNullOrWhiteSpace(url)) throw new ArgumentException("Photo url is required.", nameof(url));
        if (price < 0) throw new ArgumentOutOfRangeException(nameof(price), "Price must be >= 0.");

        Id = id;
        AlbumId = albumId;
        Url = url.Trim();
        IsLocked = isLocked;
        Price = price;
    }
}
