using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Archi.API.Data;
using Archi.API.Models;
using Archi.Library.Controllers;

namespace Archi.API.Controllers
{
   
    public class CustomersController : BaseController<ArchiDbContext, Customer>
    {
        public CustomersController(ArchiDbContext context):base(context)
        { 
        }



        
        public void Bob()
        {

        }
        

       

        
    }
}
