using Edenlab.Creatio.Web.AspNet.Extensions;
using Edenlab.Creatio.Web.Hosting;
using Terrasoft.Core;

namespace Darnytsia.Creatio;

public static class Program
{
    public static void Main(AppConnection appConnection)
    {
        WebHost.Create(appConnection)
            .Build()
            .RunNetFramework();
    }

    public static void Shutdown()
    {
    }
}
