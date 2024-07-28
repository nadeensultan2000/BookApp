using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class LogSubCategory
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		[ForeignKey(nameof(Subcategory))]
		public Guid SubCategoryId { get; set; }
		public SubCategory Subcategory { get; set; }

		public int CurrentState { get; set; }
	}
}
