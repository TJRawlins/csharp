
using Irrigation;

var _context = new AppDbContext();

var plant =  new Plant()
{
    PlantType = 1,
    Name = "Test Plant",
    GalsPerWeek = 25,
    Quantity = 1,
    EmittersPerPlant = 3,
    EmitterGPH = 3,
    ZoneId = 1,
};
_context.Add(plant);
_context.SaveChanges();