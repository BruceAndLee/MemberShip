﻿using MemberShipManage.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Webdiyer.WebControls.Mvc;

namespace MemberShipManage.Models
{
    public class RechargeListModel
    {
        public int? CustomerID { get; set; }
        public string UserNo { get; set; }
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public IPagedList<RechargeRecord> RechargeRecordList { get; set; }
    }
}