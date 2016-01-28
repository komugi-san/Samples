﻿using Microsoft.SharePoint.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Models
{

    public class SharePointDataContext : DataContext
    {

        public SharePointDataContext(string url)
            : base(url)
        {
        }

        public EntityList<Test> Tests { get { return this.GetList<Test>("テスト"); } }

    }

}
