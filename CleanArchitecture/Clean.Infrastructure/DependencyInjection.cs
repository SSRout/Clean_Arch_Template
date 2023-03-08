using Microsoft.Extensions.DependencyInjection;

namespace Clean.Infrastructure
{
    /// <summary>
    ///DependencyInjection
    /// </summary>
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection service)
        { return service; }
    }
}