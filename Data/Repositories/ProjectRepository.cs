using Data.Contexts;
using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Data.Repositories;

public class ProjectRepository(DataContext context) : BaseRepository<ProjectEntity>(context), IProjectRepository
{
    public override async Task<IEnumerable<ProjectEntity>> GetAllAsync()
    {
        try
        {
            var entities = await _context.Projects
                .Include(x => x.Customer)
                .Include(x => x.ProjectManager)
                .ThenInclude(x => x.Employee)
                .Include(x => x.ProjectType)
                .Include(x => x.Status)
                .Include(x => x.Service)
                .ToListAsync();
            return entities;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return [];
        }
    }

    public override async Task<ProjectEntity?> GetAsync(Expression<Func<ProjectEntity, bool>> expression)
    {
        try
        {
            var entity = await _context.Projects
                .Include(x => x.Customer)
                .Include(x => x.ProjectManager)
                .ThenInclude(x => x.Employee)
                .Include(x => x.ProjectType)
                .Include(x => x.Status)
                .Include(x => x.Service)
                .FirstOrDefaultAsync(expression);
            return entity;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return null;
        }
    }
}
