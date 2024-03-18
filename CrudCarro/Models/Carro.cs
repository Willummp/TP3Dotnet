using System.ComponentModel.DataAnnotations;

namespace CrudCarro.Models
{
    public class Carro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Marca é obrigatório")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "O campo Modelo é obrigatório")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "O campo Ano é obrigatório")]
        public int Ano { get; set; }

        [Required(ErrorMessage = "O campo Categoria é obrigatório")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "O campo Preço é obrigatório")]
        public float Preco{ get; set; }

    }
}
