using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Filme
{
    [Required(ErrorMessage = "O campo Título é obrigatório.")]
    public string? Titulo { get; set; }

    [Required(ErrorMessage = "O campo Genero é obrigatório.")]
    [MaxLength(50, ErrorMessage = "O campo Gênero não pode ter mais que 50 caracteres.")]
    public string? Genero { get; set; }

    [Required(ErrorMessage = "O campo Duracao é obrigatório.")]
    [Range(60, 600, ErrorMessage = "A duração deve ter no mínimo 60 e no máximo 600 minutos.")]
    public int Duracao { get; set; }
}