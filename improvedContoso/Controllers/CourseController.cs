using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using improvedContoso.Data;
using improvedContoso.Models;


namespace improvedContoso.Controllers{

    public class CourseController : Controller{

        private readonly SchoolContext _context;

        public CourseController(SchoolContext? context){
            _context = context;
        }
    }
}
