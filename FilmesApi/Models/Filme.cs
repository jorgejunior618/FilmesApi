using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Filme
    {
        [Required(ErrorMessage = "O campo Título é obrigatorio")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo Diretor é obrigatorio")]
        [StringLength(50, ErrorMessage = "O Nome do Diretor não pode conter mais que 50 caracteres")]
        public string Diretor { get; set; }

        [Required(ErrorMessage = "O campo Gênero é obrigatorio")]
        [StringLength(30, ErrorMessage = "O Gênero não pode conter mais que 30 caracteres")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "O campo Título é obrigatorio")]
        [Range(1, 480, ErrorMessage = "A Duração deve ser informada e no maximo de 480 min (8 horas)")]
        public int Duracao { get; set; }
    }
}
