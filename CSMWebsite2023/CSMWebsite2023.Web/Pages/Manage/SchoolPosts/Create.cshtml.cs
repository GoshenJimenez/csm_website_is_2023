using CSMWebsite2023.Contracts;
using CSMWebsite2023.Contracts.SchoolPosts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace CSMWebsite2023.Web.Pages.Manage.SchoolPosts
{
    public class Create : PageModel
    {
        public readonly ISchoolPostService _schoolPostService;
        public readonly IWebHostEnvironment _env;
        public Create(ISchoolPostService schoolPostService, IWebHostEnvironment env)
        {
            _schoolPostService = schoolPostService;
            Dto = new CreateDto();
            _env = env;
        }

        public async Task OnPost()
        {
            var op = await _schoolPostService.Create(Dto);
            if (op != null && op.Status == OpStatus.Ok)
            {
                //$"//schoolposts//{schoolPost.Id}//article-image.png"
                var dirPath = _env.WebRootPath + "/schoolposts/" + op.ReferenceId.ToString();
                if (!Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(dirPath);
                }

                var imgUrl = "/article-image.png";
                var filePath = dirPath + imgUrl;
                if (ImageFile!.Length > 0)
                {
                    byte[] bytes = await FileBytes(ImageFile!.OpenReadStream());
                    using (Image<Rgba32> image = SixLabors.ImageSharp.Image.Load<Rgba32>(bytes))
                    {
                        //if image wider than 800 px scale to its aspect ratio
                        if (image.Width > 800)
                        {
                            var ratio = 800 / image.Width;
                            image.Mutate(x => x.Resize(800, Convert.ToInt32(image.Height * ratio)));
                        }
                        image.Save(filePath);
                    }
                }
            }
            else if (op != null && op.Status == OpStatus.Fail)
            {
                Error = op.Message;
            }
        }

        public async Task<byte[]> FileBytes(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }

        [BindProperty]
        public CreateDto? Dto { get; set; }

        [BindProperty]
        public IFormFile? ImageFile { get; set; }

        [BindProperty]
        public string? Error { get; set; }
    }
}
