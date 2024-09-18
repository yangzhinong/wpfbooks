using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrgChartTreeView
{
    public class Employee
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

        private string m_Extension;
        public string Extension
        {
            get { return m_Extension; }
            set { m_Extension = value; }
        }
    }
}
