namespace DesafioSimpress.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Produtos")]
    public partial class Produto
    {
        public int ID { get; set; }

        [StringLength(250)]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Nome { get; set; }

        [StringLength(250)]
        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Perecível")]
        public bool Perecivel { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Ativo")]
        public bool Ativacao { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
