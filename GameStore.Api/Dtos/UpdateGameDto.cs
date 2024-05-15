using System.ComponentModel.DataAnnotations;

namespace GameStore.Api.Dtos;

public record class UpdateGameDto (
    [Required]
    [StringLength(50, MinimumLength = 3)]
    string Name, 
    [Required]
    int GenreId, 
    [Required]
    [Range(1, 999.99)]
    decimal Price, 
    DateTime ReleaseDate
);
