using EntityFrameworkDBFirst.Models;

var _context = new PrsContext();

var users = _context.Users.ToList();

foreach (var user in users) {
    Console.WriteLine($"{user.Firstname} {user.Lastname}");
}

