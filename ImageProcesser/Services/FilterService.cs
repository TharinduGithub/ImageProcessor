using System;
using ImageProcesser.Image;
using ImageProcesser.Image.Capabilities;

namespace ImageProcesser.Services
{
    public class FilterService : IService
    {
        public FilterService()
        {
        }

        //Add Filters to Image
        public void Assign(IImage image)
        {
            //Do Stuff
            DoProcess(image);
        }

        public void DoProcess(IFilter image)//Liskov Substitution
        {

        }
    }
}
