using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApplianceRentalSystem
{
    class clsRentDetails
    {
        /// Encapsulation (Getter, Setter) ///
        String _RentID, _ApplianceID;
        int _MonthlyFees, _RentPrice, _RentQuantity;

        public string RentID
        {
            get { return _RentID; }
            set { _RentID = value; }
        }

        public string ApplianceID
        {
            get { return _ApplianceID; }
            set { _ApplianceID = value; }
        }

        public int MonthlyFees
        {
            get { return _MonthlyFees; }
            set { _MonthlyFees = value; }
        }

        public int RentQuantity
        {
            get { return _RentQuantity; }
            set { _RentQuantity = value; }
        }

        public int RentPrice
        {
            get { return _RentPrice; }
            set { _RentPrice = value; }
        }
    }
}
