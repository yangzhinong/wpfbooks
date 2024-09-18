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

using System.Collections.ObjectModel;

namespace UseListView
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

            // Create a list of BookInfos.
            ObservableCollection<BookInfo> books =
                new ObservableCollection<BookInfo>();
            books.Add(new BookInfo("Daniel Pinkwater", "5 Novels", "1997", "9.56"));
            books.Add(new BookInfo("Glen Cook", "Cold Copper Tears (Garrett Files)", "2007", "6.99"));
            books.Add(new BookInfo("Simon R. Green", "The Man With the Golden Torc", "2008", "7.99"));
            books.Add(new BookInfo("Tad Williams", "The War of the Flowers", "2004", "8.99"));
            books.Add(new BookInfo("Tom Holt", "You Don't Have to Be Evil to Work Here, But it Helps", "2007", "10.00"));

            // Set the ListView's data context to this list.
            lvwBooks.DataContext = books;
		}
	}

    public class BookInfo
    {
        // Initialize a new object's fields.
        public BookInfo(string new_Author, string new_Title, string new_Year, string new_Price)
        {
            Author = new_Author;
            Title = new_Title;
            Year = new_Year;
            Price = new_Price;
        }

        private String m_Author;
        public string Author
        {
            get { return m_Author; }
            set { m_Author = value; }
        }

        private String m_Title;
        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }

        private String m_Year;
        public string Year
        {
            get { return m_Year; }
            set { m_Year = value; }
        }

        private String m_Price;
        public string Price
        {
            get { return m_Price; }
            set { m_Price = value; }
        }
    }
}