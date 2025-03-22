﻿using Factory.BLL.InterFaces;
using Factory.DAL.Models.Permission;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Factory.BLL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity == null)
            {
                throw new KeyNotFoundException($"Entity of type {typeof(TEntity)} with ID {id} was not found.");
            }
            return entity;
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity == null)
            {
                throw new KeyNotFoundException($"Entity of type {typeof(TEntity)} with ID {id} was not found.");
            }
            return entity;
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            return await query.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id, string includeProperties = "")
        {
            IQueryable<TEntity> query = _dbSet;

            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            return await query.FirstOrDefaultAsync(entity => EF.Property<int>(entity, "Id") == id);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities)
        {
            if (entities == null || !entities.Any())
                return Enumerable.Empty<TEntity>();

            await _dbSet.AddRangeAsync(entities);
            await _context.SaveChangesAsync();
            return entities;
        }


        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> RemoveAsync(TEntity entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        // PermissionTyepe-Specific Methods
        public async Task<List<PermissionTyepe>> GetAllPermissionTyepeAsync()
        {
            return await _context.Set<PermissionTyepe>().ToListAsync();
        }

        public async Task<PermissionTyepe> GetPermissionTyepeByIdAsync(int id, string includeProperties = "")
        {
            IQueryable<PermissionTyepe> query = _context.Set<PermissionTyepe>();

            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            return await query.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<PermissionTyepe> AddPermissionTyepeAsync(PermissionTyepe PermissionTyepe)
        {
            await _context.Set<PermissionTyepe>().AddAsync(PermissionTyepe);
            await _context.SaveChangesAsync();
            return PermissionTyepe;
        }

        public async Task<PermissionTyepe> UpdatePermissionTyepeAsync(PermissionTyepe PermissionTyepe)
        {
            _context.Entry(PermissionTyepe).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return PermissionTyepe;
        }

        public async Task<PermissionTyepe> RemovePermissionTyepeAsync(PermissionTyepe PermissionTyepe)
        {
            _context.Set<PermissionTyepe>().Remove(PermissionTyepe);
            await _context.SaveChangesAsync();
            return PermissionTyepe;
        }

        // Module-Specific Methods
        public async Task<List<Module>> GetAllModulesAsync()
        {
            return await _context.Set<Module>().ToListAsync();
        }

        public async Task<Module> GetModuleByIdAsync(int id, string includeProperties = "")
        {
            IQueryable<Module> query = _context.Set<Module>();

            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            return await query.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<Module> AddModuleAsync(Module module)
        {
            await _context.Set<Module>().AddAsync(module);
            await _context.SaveChangesAsync();
            return module;
        }

        public async Task<Module> UpdateModuleAsync(Module module)
        {
            _context.Entry(module).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return module;
        }

        public async Task<Module> RemoveModuleAsync(Module module)
        {
            _context.Set<Module>().Remove(module);
            await _context.SaveChangesAsync();
            return module;
        }

        public async Task RegisterPoliciesAsync(AuthorizationOptions options)
        {
            var PermissionTyepe = await GetAllPermissionTyepeAsync();

            foreach (var Permission in PermissionTyepe)
            {
                options.AddPolicy(Permission.Name, policy =>
                    policy.RequireAssertion(context =>
                        context.User.HasClaim(c => c.Type == "PermissionTyepe" && c.Value == Permission.Name)));
            }
        }
        public async Task RemoveRangeAsync(IEnumerable<TEntity> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException(nameof(entities));
            }

            _dbSet.RemoveRange(entities);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Module>> GetModulesForUserAsync(string userId)
        {
            // Fetch the roles assigned to the user
            var userRoles = await _context.Set<IdentityUserRole<string>>()
                .Where(ur => ur.UserId == userId)
                .AsNoTracking()
                .Select(ur => ur.RoleId)
                .ToListAsync();

            // Fetch modules that the user has permissions for
            var modules = await _context.Set<RolePermission>()
                .Where(rp => userRoles.Contains(rp.RoleId))
                .AsNoTracking()
                .Select(rp => rp.Module)
                .Distinct()
                .ToListAsync();

            // Load submodules and pages for each module
            foreach (var module in modules)
            {
                // Load submodules for the module
                await _context.Entry(module)
                    .Collection(m => m.SubModules)
                    .LoadAsync();

                // Filter submodules to include only those the user has permissions for
                var allowedSubModules = await _context.Set<RolePermission>()
                    .Where(rp => userRoles.Contains(rp.RoleId) && rp.ModuleId == module.Id)
                    .Select(rp => rp.SubModule)
                    .Distinct()
                    .ToListAsync();

                module.SubModules = allowedSubModules;

                foreach (var subModule in module.SubModules)
                {
                    await _context.Entry(subModule)
                        .Collection(sm => sm.Pages)
                        .LoadAsync();

                    var allowedPages = await _context.Set<RolePermission>()
                        .Where(rp => userRoles.Contains(rp.RoleId) && rp.SubModuleId == subModule.Id)
                        .Select(rp => rp.Page)
                        .Distinct()
                        .ToListAsync();

                    subModule.Pages = allowedPages;
                }
            }

            return modules;
        }
        public IQueryable<TEntity> Query()
        {
            return _dbSet.AsQueryable();
        }

        public async Task<TEntity?> GetFirstOrDefaultAsync(Expression<Func<TEntity, bool>>? predicate = null)
        {
            if (predicate == null)
            {
                return await _dbSet.FirstOrDefaultAsync();
            }
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }


        public async Task<bool> AnyAsync<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class
        {
            return await _context.Set<TEntity>().AnyAsync(predicate);
        }

    }
}