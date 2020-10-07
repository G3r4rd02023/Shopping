using System;
using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(15, ErrorMessage =
           "El Campo {0} puede contener {1} y minimo {2} caracteres",
           MinimumLength = 3)]
        [Display(Name = "Código")]
        public string Code { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido!")]
        [Display(Name = "Impuesto")]
        public int TaxID { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name = "Imagen")]
        public string ImageUrl { get; set; }

        [Display(Name = "Ultima Compra")]
        public DateTime? LastPurchase { get; set; }

        [Display(Name = "Ultima Venta")]
        public DateTime? LastSale { get; set; }

        [Display(Name = "Disponible?")]
        public bool IsAvailabe { get; set; }

        [Display(Name = "En Existencia")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }

        [Display(Name = "Compañia")]
        public int CompanyId { get; set; }

        public User User { get; set; }
    }
}
