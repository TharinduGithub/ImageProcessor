using System;
using ImageProcesser.Attributes;

namespace ImageProcesser.Image.Capabilities
{
    [Function(Enums.Functions.Radius)]
    public interface IRadius
    {
        double Radius { get; set; }
    }
}
