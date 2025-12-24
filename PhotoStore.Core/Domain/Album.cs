namespace PhotoStore.Core.Domain;

public sealed class Album
{
    public Guid Id { get; }
    public string Title { get; }
    public string? Category { get; }
    public DateOnly? EventDate { get; }
    public string CoverUrl { get; }

    public Album(Guid id, string title, string coverUrl, string? category = null, DateOnly? eventDate = null)
    {
        if (id == Guid.Empty) throw new ArgumentException("Album id is required.", nameof(id));
        if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException("Album title is required.", nameof(title));
        if (string.IsNullOrWhiteSpace(coverUrl)) throw new ArgumentException("Cover url is required.", nameof(coverUrl));

        Id = id;
        Title = title.Trim();
        CoverUrl = coverUrl.Trim();
        Category = string.IsNullOrWhiteSpace(category) ? null : category.Trim();
        EventDate = eventDate;
    }
}
