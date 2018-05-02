using System;
namespace Solid.ISP
{
    public class AboutPage
    {
        private readonly IConfigurations _configurations;

        public AboutPage(IConfigurations configurations)
        {
            _configurations = configurations;
        }

        public AboutPage() : this(Configurations.Settings)
        {
        }


    }
}
