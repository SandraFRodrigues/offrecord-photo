using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PhotoStore.Core.Abstractions;
using PhotoStore.Core.Domain;

namespace PhotoStore.App.Pages.Portfolio;

public class AlbumModel : PageModel
{
    private readonly IAlbumRepository _albums;
    private readonly IPhotoRepository _photos;

    public AlbumModel(IAlbumRepository albums, IPhotoRepository photos)
    {
        _albums = albums;
        _photos = photos;
    }

    public Album? Album { get; private set; }
    public IReadOnlyList<Photo> Photos { get; private set; } = [];

    public async Task<IActionResult> OnGet(Guid id, CancellationToken ct)
    {
        Album = await _albums.GetByIdAsync(id, ct);
        if (Album is null) return NotFound();

        Photos = await _photos.GetByAlbumAsync(id, ct);
        return Page();
    }
}
