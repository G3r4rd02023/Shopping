using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Data.Entities
{
	public class Country : IEntity
	{
		public int Id { get; set; }

		[MaxLength(50, ErrorMessage = "El Campo {0} solo puede contener {1} caracteres de longitud.")]
		[Required]
		[Display(Name = "País")]
		public string Name { get; set; }
	}

}
