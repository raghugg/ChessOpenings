using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ChessOpenings.Models;

namespace ChessOpenings.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
{

public DbSet<ChessOpenings.Models.Opening> Opening { get; set; } = default!;
}
