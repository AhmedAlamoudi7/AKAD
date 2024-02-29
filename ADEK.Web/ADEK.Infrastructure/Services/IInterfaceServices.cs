using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

 
namespace ADEK.infrastructure.Services
{
    public  interface IInterfaceServices
	{

		 ICategoryService categoryService { get;}
		
	}
}
