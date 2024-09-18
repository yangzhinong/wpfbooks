using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrgChartMasterDetail
{
    class Project
    {
        private string m_Name;
        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        private string m_Description;
        public string Description
        {
            get { return m_Description; }
            set { m_Description = value; }
        }

        private Employee m_TeamLead;
        public Employee TeamLead
        {
            get { return m_TeamLead; }
            set { m_TeamLead = value; }
        }

        private List<Employee> m_TeamMembers = new List<Employee>();
        public List<Employee> TeamMembers
        {
            get { return m_TeamMembers; }
            set { m_TeamMembers = value; }
        }
    }
}
