using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonList
{
    class Person2
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

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
