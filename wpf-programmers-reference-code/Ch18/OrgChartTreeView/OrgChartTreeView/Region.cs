using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrgChartTreeView
{
    class Region
    {
        private string m_RegionName;
        public string RegionName
        {
            get { return m_RegionName; }
            set { m_RegionName = value; }
        }

        private List<Department> m_Departments = new List<Department>();
        public List<Department> Departments
        {
            get { return m_Departments; }
            set { m_Departments = value; }
        }
    }
}
