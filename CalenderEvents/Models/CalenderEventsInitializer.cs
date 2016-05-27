using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CalenderEvents.Models
{
    public class CalenderEventsInitializer : CreateDatabaseIfNotExists<CalenderEventContext>
    {
        protected override void Seed(CalenderEventContext context)
        {
            base.Seed(context);
        }
    }
}