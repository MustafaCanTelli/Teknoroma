using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.ViewModels.ReportsVM
{
    public class SalesTrackingVM
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }

        public string RoleName { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal MonthlySales { get; set; }
        public decimal Bonus { get; set; }

    }
}
