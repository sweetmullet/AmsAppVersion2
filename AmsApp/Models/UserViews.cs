using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AmsApp.Models
{
    public class UserViews
    {
        public int UserViewsId { get; set; }
        public int ViewsId { get; set; }
        public int UserId { get; set; }

    }


}