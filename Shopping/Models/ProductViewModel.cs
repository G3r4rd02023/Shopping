using Microsoft.AspNetCore.Http;
using Shopping.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
	public class ProductViewModel : Product
	{
		[Display(Name = "Imagen")]
		public IFormFile ImageFile { get; set; }
	}

}
