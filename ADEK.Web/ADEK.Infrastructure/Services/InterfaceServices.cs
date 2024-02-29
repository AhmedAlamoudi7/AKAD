using ADEK.Core.Settings;
using ADEK.Data.Data;
using ADEK.infrastructure.Services;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ADEK.infrastructure.Services
{
    public class InterfaceServices  :IInterfaceServices
	{


		 private readonly IMapper _mapper;
         private readonly ApplicationDbContext _db;
         private readonly IConfiguration _configuration;
 
        public InterfaceServices(IMapper mapper, ApplicationDbContext db ,IConfiguration configuration)
		{
			_mapper = mapper;
			_db = db;
 			_configuration = configuration;
 			categoryService = new CategoryService(_db,_mapper);
            
		}
		public IConfiguration configuration { get; private set; }
 		public ICategoryService categoryService { get; private set; }
 		 
	}
}
