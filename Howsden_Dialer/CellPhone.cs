using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howsden_Dialer
{
    class CellPhone : Phone
    {
        public CellPhone(string companyName, long phoneNumber, int phoneType) : base(companyName, phoneNumber, phoneType)
        { }

        public override string Dial()
        {
            return Number.ToString("1+(###) ###-####");
        }
    }
}
