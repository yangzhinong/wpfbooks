using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrgChartTreeView
{
    class Department
    {
        private string m_Name;
        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        private List<Manager> m_Managers = new List<Manager>();
        public List<Manager> Managers
        {
            get { return m_Managers; }
            set { m_Managers = value; }
        }

        private List<Project> m_Projects = new List<Project>();
        public List<Project> Projects
        {
            get { return m_Projects; }
            set { m_Projects = value; }
        }
    }
}
