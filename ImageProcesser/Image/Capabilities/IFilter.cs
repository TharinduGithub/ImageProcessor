using System;
using System.Collections.Generic;
using ImageProcesser.Attributes;

namespace ImageProcesser.Image.Capabilities
{
    [Function(Enums.Functions.Filter)]
    public interface IFilter
    {
        IEnumerable<string> Filters { get; set; }
    }
}
