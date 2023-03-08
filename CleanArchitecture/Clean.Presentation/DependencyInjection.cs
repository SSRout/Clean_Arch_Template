using Microsoft.Extensions.DependencyInjection;

namespace Clean.Presentation
{
    /// <summary>
    /// DependencyInjection
    /// </summary>
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection service)
        { return service; }
    }
}