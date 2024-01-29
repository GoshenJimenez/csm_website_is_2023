using CSMWebsite2023.Contracts;
using CSMWebsite2023.Contracts.GroupPosts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SixLabors.ImageSharp.Processing;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using Microsoft.Extensions.Hosting;

namespace CSMWebsite2023.Web.Pages.Manage.GroupPosts
{
    public class Update : PageModel
    {
        public readonly IGroupPostService _grouppostService;
        public readonly IWebHostEnvironment _env;
        public Update(IGroupPostService grouppostService, IWebHostEnvironment env)
        {
            _grouppostService = grouppostService;
            Dto = new UpdateDto();
            _env = env;
        }

        public void OnGet(Guid? id = null)
        {
            //Chats = _chatService.GetChats();
            var record = _grouppostService.GetGroupPostById(id);

            if (record != null)
            {
                if (Dto == null)
                {
                    Dto = new UpdateDto();
                }
            }
        }

        public async Task OnPost()
        {
            if (ImageFile != null)
            {
                var fileSize = ImageFile!.Length;
                if ((fileSize / 1048576.0) > 5)
                {
                    Error = "The file you uploaded is too large. Filesize limit is 5mb.";
                }
                if (ImageFile!.ContentType != "image/jpeg" && ImageFile!.ContentType != "image/png")
                {
                    Error = "Please upload a jpeg or png file for the attachment.";
                }
            }

            if (Dto != null)
            {
                var op = await _grouppostService.Update(Dto);
                if (op != null && op.Status == OpStatus.Ok)
                {
                    if (ImageFile != null)
                    {
                        //$"//grouppost//{grouppost.Id}//article-image.png"
                        var dirPath = _env.WebRootPath + "/grouppost/" + op.ReferenceId.ToString();
                        if (!Directory.Exists(dirPath))
                        {
                            Directory.CreateDirectory(dirPath);
                        }

                        if (ImageFile!.Length > 0)
                        {
                            byte[] bytes = await FileBytes(ImageFile!.OpenReadStream());
                            using (Image<Rgba32> image = SixLabors.ImageSharp.Image.Load<Rgba32>(bytes))
                            {
                                var galleryImage = image;
                                SaveFile(galleryImage, "gallery-image.png", dirPath, 200);

                                var articleImage = image;
                                SaveFile(articleImage, "article-image.png", dirPath, 800);

                                var thumbnail = image;
                                SaveFile(thumbnail, "thumbnail.png", dirPath, 30);
                            }
                        }
                    }
                }
                else if (op != null && op.Status == OpStatus.Fail)
                {
                    Error = op.Message;
                }
            }
        }

        private void SaveFile(Image<Rgba32> image, string? filename = "", string? dirPath = "", int width = 800)
        {
            var filePath = dirPath + "/" + filename;

            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }            

            if (image.Width > width)
            {
                var ratio = width / image.Width;
                image.Mutate(x => x.Resize(width, Convert.ToInt32(image.Height * ratio)));
            }

            image.Save(filePath);
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
        public UpdateDto? Dto { get; set; }

        [BindProperty]
        public IFormFile? ImageFile { get; set; }

        [BindProperty]
        public string? Error { get; set; }
    }
}
