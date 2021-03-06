﻿using MemberShipManage.Domain;
using MemberShipManage.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Webdiyer.WebControls.Mvc;

namespace MemberShipManage.Models
{
    public class CustomerListModel
    {
        public string UserNo { get; set; }
        public string Name { get; set; }
        public int? Sex { get; set; }
        public IPagedList<CustomerEntity> CustomerList { get; set; }
    }
}