using System;
using ImageProcesser.Image.Capabilities;

namespace ImageProcesser.Image
{
    //Interface Segrigation
    public interface IImage : IResize, IRadius, IFilter
    {
    }
}
