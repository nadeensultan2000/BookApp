using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class Book
	{
		public Guid Id { get; set; }
		[MinLength(3)]
		[MaxLength(50)]
		public string Name { get; set; }
		[MinLength(3)]
		[MaxLength(50)]
		public string Author {  get; set; }	
		public string Description { get; set; }	
		public string ImageName { get; set; }
		public string FileName { get; set; }
		public bool Publish {  get; set; }


		
		public Guid CatrgoryId { get; set; }
		[ForeignKey("CatrgoryId")]
		public Category category { get; set; }


		
		public Guid SubCategoryId { get; set; }
		[ForeignKey("SubCategoryId")]
		public SubCategory Subcategory { get; set; }

		public int CurrentState { get; set; }


	}
}
