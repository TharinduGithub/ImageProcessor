using System;
using System.Collections.Generic;
using ImageProcesser.Factories.FunctionFactory;
using ImageProcesser.Image;
using System.Linq;
using ImageProcesser.Attributes;
using ImageProcesser.Enums;
using ImageProcesser.Services;

namespace ImageAPI.Services
{
    public class ImageProcessService : IImageProcessService
    {
        public ImageProcessService()
        {
        }

        public void Process(IEnumerable<IImage> images)
        {

            FunctionFactory factory = new FunctionFactory();

            foreach (var image in images)
            {
                var attribute = Enum.Parse<Functions>(images.GetType().GetCustomAttributes(typeof(Functions), true).First().ToString());

                IService service = factory.GetService(attribute);
                service.Assign(image);

            }
        }
    }
}
