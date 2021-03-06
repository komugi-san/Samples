﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.ViewModels
{

    public class ExpenseDeleteItemViewModel
    {

        public ExpenseDeleteItemViewModel()
        {
        }

        public Guid Id { get; set; }

        [Display(Name = "Employee")]
        public string EmployeeName { get; set; }

        [Display(Name = "Job Title")]
        public string JobTitleName { get; set; }

        [Display(Name = "Period")]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime PeriodDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime Date { get; set; }

        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:#,##0}")]
        public decimal Amount { get; set; }

        public byte[] RowVersion { get; set; }

    }

}
