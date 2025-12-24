using Microsoft.AspNetCore.Mvc.RazorPages;
using PhotoStore.Core.Abstractions;
using PhotoStore.Core.Domain;

namespace PhotoStore.App.Pages;

public class Offrecord_PhotoModel : PageModel
{
    private readonly IAlbumRepository _albums;

    public Offrecord_PhotoModel(IAlbumRepository albums)
    {
        _albums = albums;
    }

    public IReadOnlyList<Album> Items { get; private set; } = [];

    public async Task OnGet(CancellationToken ct)
    {
        Items = await _albums.GetPublicAsync(ct);
    }
}
