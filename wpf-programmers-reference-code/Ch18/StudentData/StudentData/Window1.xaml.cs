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

using System.Data;
using System.Data.OleDb;

namespace StudentData
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

        OleDbDataAdapter m_daUsers;
        DataSet m_dsStudentData;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Connect to the database.
            OleDbConnection conn = new OleDbConnection(
                "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=StudentData.mdb");

            try
            {
                // Open the connection.
                conn.Open();

                // The DataSet to hold all of the data.
                m_dsStudentData = new DataSet();

                // Load Students table.
                m_daUsers = new OleDbDataAdapter();
                m_daUsers.SelectCommand =
                    new OleDbCommand("SELECT * FROM Students ORDER BY FirstName, LastName", conn);
                m_daUsers.Fill(m_dsStudentData, "Students");

                // Load TestScores table.
                OleDbDataAdapter daTestScores = new OleDbDataAdapter();
                daTestScores.SelectCommand =
                    new OleDbCommand("SELECT * FROM TestScores", conn);
                daTestScores.Fill(m_dsStudentData, "TestScores");
                
                // Load States table.
                OleDbDataAdapter daStates = new OleDbDataAdapter();
                daStates.SelectCommand =
                    new OleDbCommand("SELECT * FROM States ORDER BY StateName", conn);
                daStates.Fill(m_dsStudentData, "States");

                // Relation: States.State = Students.State.
                m_dsStudentData.Relations.Add(
                    "relStates_Students",
                    m_dsStudentData.Tables["States"].Columns["State"],
                    m_dsStudentData.Tables["Students"].Columns["State"]);

                // Relation: Students.StudentId = TestScores.StudentId.
                m_dsStudentData.Relations.Add(
                    "relStudents_TestScores",
                    m_dsStudentData.Tables["Students"].Columns["StudentId"],
                    m_dsStudentData.Tables["TestScores"].Columns["StudentId"]);

                // Set the Window's DataContext to the DataSet.
                this.DataContext = m_dsStudentData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Close the connection.
                conn.Close();
            }
        }

        // Save the changes to the Students table.
        private void mnuDataSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            // Shameless kludge to move focus off of the current control
            // so any pending changes are written into the DataSet.
            IInputElement has_focus = FocusManager.GetFocusedElement(this);
            lstStudents.Focus();
            has_focus.Focus();

            // Make a command builder to generate the UPDATE command.
            OleDbCommandBuilder cb = new OleDbCommandBuilder(m_daUsers);
            
            // Update the table.
            m_daUsers.Update(m_dsStudentData, "Students");

            MessageBox.Show("Changes saved.", "Changes Saved",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }
	}
}