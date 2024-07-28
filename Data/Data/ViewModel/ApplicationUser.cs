using Microsoft.AspNetCore.Identity;

namespace BookApp.ViewModel
{
	public class ApplicationUser:IdentityUser
	{
		public string Name { get; set; }
		public string Image { get; set; }
		public bool ActiveUser { get; set; }

	}
}
