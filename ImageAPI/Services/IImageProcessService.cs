using System;
using System.Collections.Generic;
using ImageProcesser.Image;

namespace ImageAPI.Services
{
    public interface IImageProcessService
    {
        void Process(IEnumerable<IImage> images);
    }
}
