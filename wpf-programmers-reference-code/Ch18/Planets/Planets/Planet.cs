using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Media;

namespace Planets
{
    class Planet
    {
        private string m_Name = "";
        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        private string m_Stats = "";
        public string Stats
        {
            get { return m_Stats; }
            set { m_Stats = value; }
        }

        private ImageSource m_Picture = null;
        public ImageSource Picture
        {
            get { return m_Picture; }
            set { m_Picture = value; }
        }
    }
}
