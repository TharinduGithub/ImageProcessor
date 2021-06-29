using System;
using ImageProcesser.Attributes;

namespace ImageProcesser.Image.Capabilities
{
    [Function(Enums.Functions.Resize)]
    public interface IResize
    {
        double Width { get; set; }
        double Height { get; set; }
    }
}
