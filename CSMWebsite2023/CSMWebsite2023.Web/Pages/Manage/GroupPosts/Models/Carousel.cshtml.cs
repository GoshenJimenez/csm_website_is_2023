using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSMWebsite2023.Web.Pages.Manage.GroupPosts.Models
{
    public class CarouselModel : PageModel
    {
        public class Carousel
        {
            public Carousel? Id { get; set; }
        }
    }
}