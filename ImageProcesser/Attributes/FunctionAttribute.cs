using System;
using ImageProcesser.Enums;

namespace ImageProcesser.Attributes
{
    public class FunctionAttribute : Attribute
    {
        public FunctionAttribute(Functions function)
        {
            Function = function;
        }

        public Functions Function { get; set; }
    }
}
