using Microsoft.AspNetCore.Mvc.RazorPages;
using PhotoStore.Core.Abstractions;
using PhotoStore.Core.Domain;

namespace PhotoStore.App.Pages.Portfolio;

public class IndexModel : PageModel
{
    private readonly IAlbumRepository _albums;

    public IndexModel(IAlbumRepository albums)
    {
        _albums = albums;
    }

    public IReadOnlyList<Album> Items { get; private set; } = [];

    public async Task OnGet(CancellationToken ct)
    {
        Items = await _albums.GetPublicAsync(ct);
    }
}
