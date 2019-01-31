﻿using MemberShipManage.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Webdiyer.WebControls.Mvc;

namespace MemberShipManage.Models
{
    public class DishesListModel
    {
        public string Name { get; set; }
        public IPagedList<Dishes> DishesList { get; set; }
    }
}