using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApplianceRentalSystem
{
    class clsAdminRegister
    {
        private String _AdminID, _AdminName, _UserName, _Password, _Address, _PhoneNumber;

        /// Encapsulation (Getter, Setter) ///
        public String AdminID
        {
            get
            {
                return _AdminID;
            }
            set
            {
                _AdminID = value;
            }
        }

        public String AdminName
        {
            get
            {
                return _AdminName;
            }
            set
            {
                _AdminName = value;
            }
        }

        public String UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }

        public String Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
            }
        }

        public String Address
        {
            get
            {
                return _Address;
            }
            set
            {
                _Address = value;
            }
        }

        public String PhoneNumber
        {
            get
            {
                return _PhoneNumber;
            }
            set
            {
                _PhoneNumber = value;
            }
        }
    }
}
