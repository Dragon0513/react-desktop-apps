using System;
using System.Threading.Tasks;
using System.IO;
using Funq;
using ServiceStack;
using Squirrel;
using MyApp.Resources;
using MyApp.ServiceInterface;

namespace MyApp.AppWinForms
{
    public class AppHost : AppSelfHostBase
    {
        public AppHost()
            : base("MyApp.AppWinForms", typeof(MyServices).Assembly) { }

        public override void Configure(Container container)
        {
            SetConfig(new HostConfig
            {
                DebugMode = true,
                EmbeddedResourceBaseTypes = { typeof(AppHost), typeof(SharedEmbeddedResources) },
                UseCamelCase = true,
            });

            Plugins.Add(new SharpPagesFeature());
        }
    }
}
