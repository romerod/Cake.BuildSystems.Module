// A Hello World! program in C#.

using Cake.Core;
using Cake.Core.Annotations;
using Cake.Core.Composition;

[assembly: CakeModule(typeof(Cake.TFBuild.Module.TFBuildEngineModule))]

namespace Cake.TFBuild.Module
{
    class TFBuildEngineModule : ICakeModule
    {
        public void Register(ICakeContainerRegistrar registrar)
        {
            registrar.RegisterType<TFBuildEngine>().As<ICakeEngine>().Singleton();
        }
    }
}