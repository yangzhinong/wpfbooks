using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonSource
{
    class Person
    {
        private string m_FirstName;
        public string FirstName
        {
            get { return m_FirstName; }
            set { m_FirstName = value; }
        }

        private string m_LastName;
        public string LastName
        {
            get { return m_LastName; }
            set { m_LastName = value; }
        }

        private decimal m_NetWorth;
        public decimal NetWorth
        {
            get { return m_NetWorth; }
            set { m_NetWorth = value; }
        }
    }
}
