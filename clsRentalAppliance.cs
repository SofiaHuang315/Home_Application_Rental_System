using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApplianceRentalSystem
{
    class clsRentalAppliance
    {
        /// Encapsulation (Getter, Setter) ///
        
        String _RentID, _RentStatus;
        String _RentDate;
        int _TotalMonth, _AllTotalAmount, _RentPrice, _RentQuantity;

        public String RentID
        {
            get { return _RentID; }
            set { _RentID = value; }
        }

        public String RentStatus
        {
            get { return _RentStatus; }
            set { _RentStatus = value; }
        }

        public String RentDate
        {
            get { return _RentDate; }
            set { _RentDate = value; }
        }

        public int TotalMonth
        {
            get { return _TotalMonth; }
            set { _TotalMonth = value; }
        }

        public int RentPrice
        {
            get { return _RentPrice; }
            set { _RentPrice = value; }
        }

        public int RentQuantity
        {
            get { return _RentQuantity; }
            set { _RentQuantity = value; }
        }

        public int AllTotalAmount
        {
            get { return _AllTotalAmount; }
            set { _AllTotalAmount = value; }
        }
    }
}
