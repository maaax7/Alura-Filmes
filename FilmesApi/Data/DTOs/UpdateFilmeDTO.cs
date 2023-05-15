using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.DTOs;

public class UpdateFilmeDTO
{
    [Required(ErrorMessage = "O Título do filme é obrigatório!")]
    [StringLength(30, ErrorMessage = "Título só pode conter 30 caracteres!")]
    public string? Titulo { get; set; }

    [Required(ErrorMessage = "O Gênero do filme é obrigatório! ")]
    [MaxLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres!")]
    public string? Genero { get; set; }

    [Required]
    [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 a 600 minutos!")]
    public int Duracao { get; set; }
}

