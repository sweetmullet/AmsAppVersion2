

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;

namespace AmsApp.Models
{

    public class Views
    {

        public int ViewsId { get; set; }
        public string ViewsDescription { get; set; }
        public int ViewActiveInd { get; set; }
        public int IsBaseView { get; set; }

    }


}