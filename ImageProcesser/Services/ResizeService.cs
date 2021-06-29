using System;
using ImageProcesser.Image;
using ImageProcesser.Image.Capabilities;

namespace ImageProcesser.Services
{
    public class ResizeService : IService
    {
        public ResizeService()
        {
        }

        //Resize Image
        public void Assign(IImage image)
        {
            //Do Stuff
            DoProcess(image);
        }

        public void DoProcess(IResize image)//Liskov Substitution
        {

        }
    }
}
