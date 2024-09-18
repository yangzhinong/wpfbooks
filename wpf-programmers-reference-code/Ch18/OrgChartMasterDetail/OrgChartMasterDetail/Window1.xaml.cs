using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OrgChartMasterDetail
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Define Employees.
            Employee emp_a = new Employee() { FirstName = "Alice", LastName = "Able", Extension = "1111" };
            Employee emp_b = new Employee() { FirstName = "Ben", LastName = "Better", Extension = "2222" };
            Employee emp_c = new Employee() { FirstName = "Cindy", LastName = "Cable", Extension = "3333" };
            Employee emp_d = new Employee() { FirstName = "Dudley", LastName = "Denver", Extension = "4444" };
            Employee emp_e = new Employee() { FirstName = "Erin", LastName = "Evener", Extension = "5555" };
            Employee emp_f = new Employee() { FirstName = "Frank", LastName = "Fright", Extension = "6666" };

            // Define Managers.
            Manager mgr_a = new Manager() { FirstName = "Mindy", LastName = "Most", Extension = "0001", Title = "Manager of OR" };
            Manager mgr_b = new Manager() { FirstName = "Mark", LastName = "Malb", Extension = "0002", Title = "Manager of XOR" };
            Manager mgr_c = new Manager() { FirstName = "Macey", LastName = "Malin", Extension = "0003", Title = "Ops Manager" };
            Manager mgr_d = new Manager() { FirstName = "Mike", LastName = "Milner", Extension = "0004", Title = "Director of Direction" };
            mgr_a.Reports.Add(emp_a);
            mgr_a.Reports.Add(emp_b);
            mgr_b.Reports.Add(emp_c);
            mgr_b.Reports.Add(emp_d);
            mgr_c.Reports.Add(emp_e);
            mgr_d.Reports.Add(emp_f);
            mgr_d.Reports.Add(emp_a);

            // Define Projects.
            Project proj_acro = new Project() { Name = "ACROBAT", Description = "Categorization of company acronyms", TeamLead = emp_a };
            proj_acro.TeamMembers.Add(emp_a);
            proj_acro.TeamMembers.Add(emp_c);
            proj_acro.TeamMembers.Add(emp_d);

            Project proj_abend = new Project() { Name = "ABEND", Description = "Research into ending abstruse acronyms", TeamLead = emp_e };
            proj_abend.TeamMembers.Add(emp_e);
            proj_abend.TeamMembers.Add(emp_b);
            proj_abend.TeamMembers.Add(emp_f);

            Project proj_add = new Project() { Name = "ADD", Description = "Acronym Design and Development", TeamLead = emp_b };
            proj_add.TeamMembers.Add(emp_b);
            proj_add.TeamMembers.Add(emp_c);
            proj_add.TeamMembers.Add(emp_e);

            Project proj_unfug = new Project() { Name = "UNFUG", Description = "Unpredictably Functional GUIDs", TeamLead = emp_d };
            proj_add.TeamMembers.Add(emp_d);

            // Define Departments.
            Department dept_rd = new Department() { Name = "Research & Development Department" };
            dept_rd.Managers.Add(mgr_a);
            dept_rd.Managers.Add(mgr_b);
            dept_rd.Projects.Add(proj_acro);

            Department dept_aa = new Department() { Name = "Acronyms & Abbrevs Department" };
            dept_aa.Managers.Add(mgr_c);
            dept_aa.Projects.Add(proj_abend);
            dept_aa.Projects.Add(proj_add);

            Department dept_acq = new Department() { Name = "Other Stuff Department" };
            dept_acq.Managers.Add(mgr_d);
            dept_acq.Projects.Add(proj_unfug);

            // Define Regions.
            Region div_work = new Region() { RegionName = "East" };
            div_work.Departments.Add(dept_rd);

            Region div_acro = new Region() { RegionName = "Central" };
            div_acro.Departments.Add(dept_aa);
            div_acro.Departments.Add(dept_acq);

            // Make a list of the regions.
            List<Region> regions = new List<Region>();
            regions.Add(div_work);
            regions.Add(div_acro);

            // Make the TreeView controls display this list.
            spByManager.DataContext = regions;
            spByProject.DataContext = regions;
        }
    }
}