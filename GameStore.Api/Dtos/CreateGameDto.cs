using System.ComponentModel.DataAnnotations;

namespace GameStore.Api.Dtos;

public record class CreateGameDto(
    [Required]
    [StringLength(50, MinimumLength = 3)]
    string Name, 
    int GenreId,
    [Range(1, 999.99)]
    decimal Price, 
    DateTime ReleaseDate
);