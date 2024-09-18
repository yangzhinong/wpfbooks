using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrgChartTreeView
{
    class Manager : Employee
    {
        private string m_Title;
        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }

        private Employee[] m_Reports;
        public Employee[] Reports
        {
            get { return m_Reports; }
            set { m_Reports = value; }
        }
    }
}
