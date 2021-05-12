using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howsden_Dialer
{
    class Phone
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private long _number;

        public long Number
        {
            get { return _number; }
            set { _number = value; }
        }

        private int _type;

        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public Phone(string companyName, long phoneNumber, int phoneType)
        { 
            Name = companyName;
            Number = phoneNumber;
            Type = phoneType;
        }

        public virtual string Dial()
        {
            return Number.ToString("(###) ###-####");
        }
    }
}
