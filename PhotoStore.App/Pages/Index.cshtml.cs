using Microsoft.AspNetCore.Mvc.RazorPages;
using PhotoStore.Core.Abstractions;
using PhotoStore.Core.Domain;

namespace PhotoStore.App.Pages;

public class IndexModel : PageModel
{
    private readonly IAlbumRepository _albums;

    public IndexModel(IAlbumRepository albums)
    {
        _albums = albums;
    }

    public IReadOnlyList<Album> FeaturedAlbums { get; private set; } = [];

    public async Task OnGet(CancellationToken ct)
    {
        FeaturedAlbums = await _albums.GetPublicAsync(ct);
    }
}
