using ADEK.Core.ViewModels;
using ADKE.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADEK.infrastructure.Services
{
    public interface ICategoryService

	{
        Task<List<CategoryViewModel>> GetAll(string? GeneralSearch, string language);
        PagingAPIViewModel GetAll(int page, string language);
    }
}
