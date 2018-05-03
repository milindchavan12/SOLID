using System;
namespace Solid.ISP
{
    public interface IConfigurations : IApplicationsSettings
    {
        string About { get; }
    }
}
