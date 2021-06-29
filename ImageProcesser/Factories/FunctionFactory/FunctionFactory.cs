using System;
using ImageProcesser.Enums;
using ImageProcesser.Services;

namespace ImageProcesser.Factories.FunctionFactory
{
    public class FunctionFactory : FunctionFactoryAbstract
    {
        public FunctionFactory()
        {
        }

        public override IService GetService(Functions function)
        {
            return function switch
            {
                Functions.Filter => new FilterService(),
                Functions.Resize => new ResizeService(),
                Functions.Radius => new RadiusService(),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
