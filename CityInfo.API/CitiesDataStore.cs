using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto() { Id = 1, Name = "Gabes", Description = "It is located on the coast of the Gulf of Gabès. With a population of 152,921, Gabès is the 6th largest Tunisian city.", PointOfInterests = new List<PointOfInterestDto>() { new PointOfInterestDto() { Id = 1, Name = "Soug el henna", Description = "Henna Market" } } },
                new CityDto() { Id = 2, Name = "Tunis", Description = "The capital and largest city of Tunisia. The greater metropolitan area of Tunis."},
                new CityDto() { Id = 3, Name = "Sfax", Description = "It is a city in Tunisia, located 270 km (170 mi) southeast of Tunis. The city, founded in AD 849 on the ruins of Roman Taparura."}
            };
        }
    }
}
