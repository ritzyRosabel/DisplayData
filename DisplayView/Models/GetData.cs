using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DisplayView.Models
{
    public class GetData
    {
        public static List<Test> GetTest()
        {
            ApplicationDBContext db = new ApplicationDBContext();
            var result = db.Tests.ToList<Test>();
            return result;
        }
    }
}