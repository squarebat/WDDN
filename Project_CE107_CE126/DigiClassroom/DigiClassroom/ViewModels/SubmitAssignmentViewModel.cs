﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
namespace DigiClassroom.ViewModels
{
    public class SubmitAssignmentViewModel
    {
        public string AssignmentID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFileCollection Files { get; set; }
    }
}
