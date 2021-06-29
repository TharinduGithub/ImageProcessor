using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImageAPI.Services;
using ImageProcesser.Image;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ImageAPI.Controllers
{
    [ApiController]
    public class ImageProcessingController : ControllerBase
    {
        IImageProcessService _imageProcessService;
        public ImageProcessingController(IImageProcessService imageProcessService)//Dependancy Inversion
        {
            _imageProcessService = imageProcessService;
        }
        // GET: /<controller>/
        public OkResult Index(IEnumerable<IImage> images)
        {
            _imageProcessService.Process(images);
            return Ok();
        }
    }
}
