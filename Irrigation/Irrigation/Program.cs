
using Irrigation;

var _context = new AppDbContext();

/* *-*-*-*-*-*-*-*-* PLANTS *-*-*-*-*-*-*-*-* */

// GET ALL
/*
var allPlants = _context.Plants.ToList();
allPlants.ForEach(p => Console.WriteLine(p));
*/


// GET BY NAME
/*
var plantByName = from p in _context.Plants
                  where p.Name.Contains("Peach")
                  select p;
Console.WriteLine(plantByName.ToList().First());
*/


// INSERT NEW PLANT
/*
var plant =  new Plant()
{
    PlantType = true,
    Name = "Test Plant",
    GalsPerWeek = 25,
    Quantity = 1,
    EmittersPerPlant = 3,
    EmitterGPH = 3,
    ZoneId = 1,
};
_context.Add(plant);
_context.SaveChanges();
*/


// UPDATE PLANT
/*
var updatePlant = from p in _context.Plants
                  where p.Name.Contains("Test")
                  select p;
updatePlant.ToList().First().Name = "Updated Test Plant";
_context.SaveChanges();
*/


// DELETE PLANT
/*
var delPlant = from p in _context.Plants
               where p.Name.Contains("Test")
               select p;
if (delPlant == null) return;
_context.Remove(delPlant.ToList().First());
_context.SaveChanges();
*/


/* *-*-*-*-*-*-*-*-* ZONES *-*-*-*-*-*-*-*-* */

// GET ALL
/*
var allZones = _context.Zones.ToList();
allZones.ForEach(zone => Console.WriteLine(zone));
*/

// GET BY ID
/*
Console.WriteLine(_context.Zones.Find(5));
*/

// INSERT
/*
var newPlant = new Zone()
{
    Name = "Zone 5 - Test",
    RuntimeHours = 1,
    RuntimeMinutes = 45,
    RuntimesPerWeek = 3,
};
_context.Zones.Add(newPlant);
_context.SaveChanges();
*/

// UPDATE
/*
var updateZone = _context.Zones.Find(5);
updateZone.Name = "Zone 5 - Update Test";
_context.SaveChanges();
*/

// DELETE
/*
var delZone = _context.Zones.Find(5);
_context.Zones.Remove(delZone);
_context.SaveChanges();
*/


/* *-*-*-*-*-*-*-*-* ZONES & PLANTS JOIN *-*-*-*-*-*-*-*-* */

var plantsZones = from p in _context.Plants
                  join z in _context.Zones
                    on p.ZoneId equals z.Id
                    orderby z.RuntimesPerWeek, z.Id
                    select new
                    {
                        z.Id,
                        z.RuntimesPerWeek,
                        totalMinutes = z.TotalRuntimeMunites(),
                        GalsPerWeek = p.GalsPerWeek * p.Quantity,
                        p.Quantity,
                        p.EmittersPerPlant,
                        p.EmitterGPH,
                        PlantName = p.Name
                    };
plantsZones.ToList().ForEach(i => Console.WriteLine($"" +
    $"Zone: {i.Id} | " +
    $"RT/WK: {i.RuntimesPerWeek} | " +
    $"RT Mins: {i.totalMinutes} | " +
    $"GALS/WK {i.GalsPerWeek} | " +
    $"Count: {i.Quantity} | " +
    $"Emit/Plant {i.EmittersPerPlant} | " +
    $"EmitGPH {i.EmitterGPH} | " +
    $"Plant: {i.PlantName}"));
