#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EJ2CoreSampleBrowser.Models;


namespace EJ2CoreSampleBrowser.Controllers
{
    public partial class PivotTableController : Controller
    {
        public IActionResult SummaryCustomization()
        {
            ViewBag.data = new PivotTableData().GetPivot_Data();
            ViewBag.drilledMembers = new string[] { "France", "Germany" };
            ViewBag.filterMembers = new string[] { "Gloves", "Helmets", "Shorts", "Vests" };
            ViewBag.fielddata = new Fields().FieldList();
            ViewBag.summaryOption = new SummaryOption().GetSummaryOption();
            ViewBag.selectedOption = "grandTotals";
            return View();
        }
    }
    
    public class Fields
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public List<Fields> FieldList()
        {
            List<Fields> fields = new List<Fields>();
            fields.Add(new Fields { Name = "Country" });
            fields.Add(new Fields { Name = "Year" });
            return fields;
        }
    }
    public class SummaryOption
    {
        public string value { get; set; }
        public string text { get; set; }
        public List<SummaryOption> GetSummaryOption()
        {
            List<SummaryOption> summaryOption = new List<SummaryOption>();
            summaryOption.Add(new SummaryOption { value = "grandTotals", text = "Grand Totals" });
            summaryOption.Add(new SummaryOption { value = "subTotals", text = "Sub-totals" });
            return summaryOption;
        }
    }
}
