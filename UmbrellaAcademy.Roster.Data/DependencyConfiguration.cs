using Microsoft.Extensions.DependencyInjection;
using UmbrellaAcademy.Roster.Data.Storage;

namespace UmbrellaAcademy.Roster.Data
{
    public static class DependencyConfiguration
    {
        public static void RegisterDataDependencies(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IMemberService, MemberService>();
            serviceCollection.AddScoped<IRosterStorage, RosterStorage>();
        }
    }
}
