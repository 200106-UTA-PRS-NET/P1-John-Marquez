using Pizza_Data.Models;

namespace Pizza_Data.Methods
{
    public class FindLocation
    {
        public string returnLocation(int locationID) // converts location ID to location Address for user history view
        {
            string locAddress = "Location Unknown";
            Entity db = new Entity();
            var locations = Repository.Repository.GetLocations(db);

            foreach (var loc in locations)
            {
                if (loc.Id == locationID)
                {
                    locAddress = loc.Locat;
                }

            }

            return locAddress;
        }
    }
}
