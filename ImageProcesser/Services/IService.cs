using System;
using ImageProcesser.Image;
using ImageProcesser.Image.Capabilities;

namespace ImageProcesser.Services
{
    public interface IService
    {
        void Assign(IImage image);
    }
}
