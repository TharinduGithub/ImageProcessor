using System;
using ImageProcesser.Enums;
using ImageProcesser.Services;

namespace ImageProcesser.Factories.FunctionFactory
{
    public abstract class FunctionFactoryAbstract
    {
        public abstract IService GetService(Functions function);
    }
}
