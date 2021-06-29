using System;
using ImageProcesser.Image;
using ImageProcesser.Image.Capabilities;

namespace ImageProcesser.Services
{
    public class RadiusService : IService
    {
        public RadiusService()
        {
        }

        //Add Radius to Image
        public void Assign(IImage image)
        {
            //Do Stuff
            DoProcess(image);
        }

        public void DoProcess(IRadius image)//Liskov Substitution
        {

        }
    }
}
