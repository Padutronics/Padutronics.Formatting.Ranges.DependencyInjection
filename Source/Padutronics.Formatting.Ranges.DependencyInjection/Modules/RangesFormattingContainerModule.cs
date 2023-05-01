using Padutronics.DependencyInjection;

namespace Padutronics.Formatting.Ranges.DependencyInjection.Modules;

public sealed class RangesFormattingContainerModule : IContainerModule
{
    public void Load(IContainerBuilder containerBuilder)
    {
        containerBuilder.For<RangeFormatOptions>().UseSelf().InstancePerDependency();
    }
}