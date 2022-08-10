using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Filme
    {
        [Required(ErrorMessage = "O campo Título é obrigatorio")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo Diretor é obrigatorio")]
        public string Diretor { get; set; }

        [Required(ErrorMessage = "O campo Gênero é obrigatorio")]
        public string Genero { get; set; }

        [Required]
        [Range(1, 480, ErrorMessage = "A Duração deve ser informada e no maximo de 480 min (8 horas)")]
        public int Duracao { get; set; }
    }
}
