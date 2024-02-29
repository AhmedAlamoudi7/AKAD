using AutoMapper;
using ADEK.Data.Data;
using Microsoft.EntityFrameworkCore;
using ADKE.Data.Models;
using ADEK.Core.Dtos;
using ADEK.Core.Exceptions;
using ADEK.Core.ViewModels;

namespace ADEK.infrastructure.Services
{
    public class CategoryService : ICategoryService
	{
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
         public CategoryService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        } 
        public async Task<List<CategoryViewModel>> GetAll(string? GeneralSearch, string language)
        {
            IQueryable<Category> query = _dbContext.Categories
                .Where(x => !x.IsDelete && (string.IsNullOrWhiteSpace(GeneralSearch) || x.Name.Contains(GeneralSearch)))
                .OrderByDescending(x => x.CreatedAt);

            switch (language.ToLower())
            {
                case "en":
                    query = query.Select(c => new Category { Name = c.Name_EN });
                    break;
                case "ar":
                    query = query.Select(c => new Category { Name = c.Name_AR });
                    break;
                // Add cases for other languages if necessary
                default:
                    break;
            }

            var categories = await query.ToListAsync();
            var categoryViewModels = _mapper.Map<List<CategoryViewModel>>(categories);

            return categoryViewModels;
        }

        public PagingAPIViewModel GetAll(int page, string language)
        {
            var pageSize = 10;
            var totalCategories = _dbContext.Categories.Count();
            var totalPages = (int)Math.Ceiling(totalCategories / (double)pageSize);

            // Ensure page number is within valid range
            page = Math.Clamp(page, 1, totalPages);

            var skipCount = (page - 1) * pageSize;

            IQueryable<Category> query = _dbContext.Categories
                .Where(x => !x.IsDelete)
                .OrderByDescending(x => x.CreatedAt)
                .Skip(skipCount)
                .Take(pageSize);

            switch (language.ToLower())
            {
                case "en":
                    query = query.Where(c =>  c.Name == c.Name_EN );
                    break;
                case "ar":
                    query = query.Where(c => c.Name == c.Name_AR);
                    break;
                // Add cases for other languages if necessary
                default:
                    break;
            }

            var categories = query.ToList();
            var categoryViewModels = _mapper.Map<List<CategoryViewModel>>(categories);

            var pagingResult = new PagingAPIViewModel
            {
                Data = categoryViewModels,
                NumberOfPages = totalPages,
                CureentPage = page
            };

            return pagingResult;
        }
        public async Task<int> Create(CreateCategoryDto dto)
        {
            if (dto is null)
            {
                throw new InvalidDateException();
            }
            var model = _mapper.Map<Category>(dto);
            
            await _dbContext.Categories.AddAsync(model);
            await _dbContext.SaveChangesAsync();
            return model.Id;
        }
        public async Task<int> Update(UpdateCategoryDto dto)
        {
            var model = await _dbContext.Categories.SingleOrDefaultAsync(x => !x.IsDelete && x.Id == dto.Id);
            if (model == null)
            {
                throw new EntityNotFoundException();
            }
            var updatedmodel = _mapper.Map<UpdateCategoryDto, Category>(dto, model);
          
            _dbContext.Categories.Update(updatedmodel);
            await _dbContext.SaveChangesAsync();
            return updatedmodel.Id;
        }
        public async Task<int> Delete(int Id)
        {
            var model = await _dbContext.Categories.SingleOrDefaultAsync(x => x.Id == Id && !(bool)x.IsDelete);
            if (model == null)
            {
                throw new EntityNotFoundException();
            }
            model.IsDelete = true;
            _dbContext.Categories.Update(model);
            await _dbContext.SaveChangesAsync();
            return model.Id;
        }
        public async Task<UpdateCategoryDto> Get(int Id)
        {
            var model = await _dbContext.Categories.SingleOrDefaultAsync(x => x.Id == Id && !(bool)x.IsDelete);
            if (model == null)
            {
                throw new EntityNotFoundException();
            }
            return _mapper.Map<UpdateCategoryDto>(model);
        }
    }
}
