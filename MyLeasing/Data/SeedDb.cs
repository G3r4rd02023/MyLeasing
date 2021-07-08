using MyLeasing.Data.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeasing.Data
{
    public class SeedDb
    {
        private readonly ApplicationDbContext _context;

        public SeedDb(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckPropertyTypesAsync();
            await CheckOwnersAsync();
            await CheckLesseesAsync();
            await CheckPropertiesAsync();
        }

        private async Task CheckLesseesAsync()
        {
            if (!_context.Lessees.Any())
            {
                AddLessee("0801-1970-51679", "Jackeline", "Redondo", "2260-4157", "3310-2709", "Colonia Centroamerica");
                AddLessee("0801-1998-61471", "Mauricio", "Dubón", "2245-0178", "3309-2891", "Residencial Palma Real");
                AddLessee("0801-1990-51379", "Carlos", "Ordoñez", "2245-0462", "9802-2783", "Colonia America");
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckPropertyTypesAsync()
        {
            if (!_context.PropertyTypes.Any())
            {
                _context.PropertyTypes.Add(new PropertyType { Name = "Apartamento" });
                _context.PropertyTypes.Add(new PropertyType { Name = "Casa" });
                _context.PropertyTypes.Add(new PropertyType { Name = "Negocio" });
                await _context.SaveChangesAsync();
            }
        }

        

        private async Task CheckPropertiesAsync()
        {
            var owner = _context.Owners.FirstOrDefault();
            var propertyType = _context.PropertyTypes.FirstOrDefault();
            if (!_context.Properties.Any())
            {
                AddProperty("Calle 43 #23 32", "Taulabe", owner, propertyType, 800000M, 2, 72, 4);
                AddProperty("Calle 12 Sur #2 34", "Zamorano", owner, propertyType, 950000M, 3, 81, 3);
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckOwnersAsync()
        {
            if (!_context.Owners.Any())
            {
                AddOwner("0801-1997-64680", "Marcela", "Ponce", "2260-3783", "3309-2789", "Colonia Cerro Grande");
                AddOwner("0801-1987-14320", "Andrea", "Garay", "2260-3783", "3309-2789", "Colonia Satelite");
                AddOwner("0801-1990-64680", "Josefina", "Aguirre", "2260-3783", "3309-2789", "Residencial El Sauce");
                await _context.SaveChangesAsync();
            }
        }

        private void AddProperty(string address, string neighborhood, Owner owner, PropertyType propertyType, decimal price, int rooms, int squareMeters, int stratum)
        {
            _context.Properties.Add(new Property
            {
                Address = address,
                HasParkingLot = true,
                IsAvailable = true,
                Neighborhood = neighborhood,
                Owner = owner,
                Price = price,
                PropertyType = propertyType,
                Rooms = rooms,
                SquareMeters = squareMeters,
                Stratum = stratum
            });
        }

        private void AddOwner(string document, string firstname, string lastname,
            string fixedphone, string cellphone,string address)
        {
            _context.Owners.Add(new Owner
            {
                Address = address,
                CellPhone = cellphone,
                Document = document,
                FirstName = firstname,
                LastName = lastname,
                FixedPhone = fixedphone,
            });
        }

        private void AddLessee(string document, string firstname, string lastname,
           string fixedphone, string cellphone, string address)
        {
            _context.Lessees.Add(new Lessee
            {
                Address = address,
                CellPhone = cellphone,
                Document = document,
                FirstName = firstname,
                LastName = lastname,
                FixedPhone = fixedphone,
            });
        }
    }
}
