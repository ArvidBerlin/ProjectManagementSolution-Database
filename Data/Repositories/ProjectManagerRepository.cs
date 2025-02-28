using Data.Contexts;
using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Data.Repositories;

public class ProjectManagerRepository(DataContext context) : BaseRepository<ProjectManagerEntity>(context), IProjectManagerRepository
{
    public override async Task<IEnumerable<ProjectManagerEntity>> GetAllAsync()
    {
        try
        {
            var entities = await _context.ProjectManagers
                .Include(x => x.Employee)
                .ToListAsync();
            return entities;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return [];
        }
    }
}
