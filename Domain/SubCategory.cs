using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class SubCategory
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		
		public Guid CategoryId { get; set; }
		[ForeignKey("CategoryId")]
		public Category Category { get; set; }

		public int CurrentState { get; set; }
	}
}
