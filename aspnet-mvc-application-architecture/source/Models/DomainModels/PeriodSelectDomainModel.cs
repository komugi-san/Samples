using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.DomainModels
{

    public class PeriodSelectDomainModel
    {

        public PeriodSelectDomainModel()
        {
        }

        public Guid Id { get; set; }

        public DateTime Period { get; set; }

    }

}
