using System.Threading.Tasks;

namespace SpotToSpotMuzak.Shared
{
    public interface IDatabaseInitializer
    {
        Task SeedAsync();
    }
}