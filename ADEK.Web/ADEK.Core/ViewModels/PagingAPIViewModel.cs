﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ADEK.Core.ViewModels
{
    public class PagingAPIViewModel
    {
        public int NumberOfPages { get; set; }

        public int CureentPage { get; set; }

        public object Data { get; set; }
    }
}
