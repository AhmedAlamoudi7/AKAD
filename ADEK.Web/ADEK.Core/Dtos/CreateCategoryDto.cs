using ADEK.Core.Constants;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ADEK.Core.Constants.Message;

namespace ADEK.Core.Dtos
{
    public class CreateCategoryDto
    {
        [Required]
        [StringLength(Message.MaxLength100, ErrorMessage = Message.ErrorMessage.Max100_Min3Length, MinimumLength = Message.MinLength3)]
        [Display(Name = Message.DescriptionName)]
        public string Name { get; set; }
        [Required]
        [StringLength(Message.MaxLength100, ErrorMessage = Message.ErrorMessage.Max100_Min3Length, MinimumLength = Message.MinLength3)]
        [Display(Name = Message.DescriptionName)]
        public string Name_EN { get; set; }
        [Required]
        [StringLength(Message.MaxLength100, ErrorMessage = Message.ErrorMessage.Max100_Min3Length, MinimumLength = Message.MinLength3)]
        [Display(Name = Message.DescriptionName)]
        public string Name_AR { get; set; }

    }
}
