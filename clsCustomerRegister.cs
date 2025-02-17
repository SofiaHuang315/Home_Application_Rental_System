using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApplianceRentalSystem
{
    class clsCustomerRegister
    {
        /// Encapsulation (Getter, Setter) ///
        private String _CustomerID,_CustomerName, _UserName, _Password, _Address, _PhoneNumber; 
 
        public String CustomerID
        {
            get
            {
                return _CustomerID;
            }
            set
            {
                _CustomerID = value;
            }
        }
 
        public String CustomerName
        {
            get 
            {
                return  _CustomerName; 
            }
            set 
            { 
                _CustomerName=value;                       
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
