using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace SuringFun.ImageZ.Service.Model;

/// <summary>
/// Represents author in the system.
/// </summary>
public class Author : IdentityUser<int>
{
    // Key is already present in `IdentityUser` parent.

    /// <summary>
    /// Avatar photo. May be missing.
    /// </summary>
    public Attachment? AuthorPhoto { get; set; }

    /// <summary>
    /// Represents name that is shown publically in the system.
    /// </summary>
    [Required]
    public string PublicName { get; set; } = default!;

    /// <summary>
    /// Represents all publications of the Author in the system.
    /// </summary>
    public ICollection<Publication> Publications { get; set; }
        = default!;
}

