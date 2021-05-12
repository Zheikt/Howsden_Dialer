using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howsden_Dialer
{
    class HomePhone : Phone
    {
        public HomePhone (string companyName, long phoneNumber, int phoneType) : base(companyName, phoneNumber, phoneType)
        { }
    }
}
