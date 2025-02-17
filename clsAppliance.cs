using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApplianceRentalSystem
{
    class clsAppliance

    /// Encapsulation (Getter, Setter) ///
    {
        private String _ApplianceID, _AN, _PU, _TU, _Model, _Dim, _Col, _ECon, _AID, _ATID;
        private int _EAC, _MF, _Quan;

        public String ApplianceID
        {
            get
            {
                return _ApplianceID;
            }
            set
            {
                _ApplianceID = value;
            }
        }

        public String AppName
        {
            get
            {
                return _AN;
            }
            set
            {
                _AN = value;
            }
        }

        public String PUsage
        {
            get
            {
                return _PU;
            }
            set
            {
                _PU = value;
            }
        }

        public String TUsage
        {
            get
            {
                return _TU;
            }
            set
            {
                _TU = value;
            }
        }

        public int AnnualCost
        {
            get
            {
                return _EAC;
            }
            set
            {
                _EAC = value;
            }
        }

        public String Model
        {
            get
            {
                return _Model;
            }
            set
            {
                _Model = value;
            }
        }

        public String Dimen
        {
            get
            {
                return _Dim;
            }
            set
            {
                _Dim = value;
            }
        }

        public String Colour
        {
            get
            {
                return _Col;
            }
            set
            {
                _Col = value;
            }
        }

        public String EnCon
        {
            get
            {
                return _ECon;
            }
            set
            {
                _ECon = value;
            }
        }

        public int MFee
        {
            get
            {
                return _MF;
            }
            set
            {
                _MF = value;
            }
        }

        public String AdID
        {
            get
            {
                return _AID;
            }
            set
            {
                _AID = value;
            }
        }

        public String ATID
        {
            get
            {
                return _ATID;
            }
            set
            {
                _ATID = value;
            }
        }

        public int Quant
        {
            get
            {
                return _Quan;
            }
            set
            {
                _Quan = value;
            }
        }
    }
}
