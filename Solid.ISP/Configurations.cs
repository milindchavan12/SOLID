using System;

namespace Solid.ISP
{
    public class Configurations : IConfigurations
    {
        public static IConfigurations Settings
        {
            get
            {
                return new Configurations();
            }
        }

        public string About
        {
            get
            {
                return "Get Some About Information";
            }
        }

        public string ApplicationName => throw new NotImplementedException();

        public string AuthorName => throw new NotImplementedException();
    }
}
