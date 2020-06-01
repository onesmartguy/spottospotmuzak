using System.Threading.Tasks;

namespace SpotToSpotMuzik.Shared
{
    public interface IDatabaseInitializer
    {
        Task SeedAsync();
    }
}