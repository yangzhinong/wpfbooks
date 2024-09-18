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

        private Manager[] m_Managers;
        public Manager[] Managers
        {
            get { return m_Managers; }
            set { m_Managers = value; }
        }

        private Project[] m_Projects;
        public Project[] Projects
        {
            get { return m_Projects; }
            set { m_Projects = value; }
        }
    }
}
