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

using System.Xml;
using System.Windows.Markup;

namespace ShowTemplate
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

        private void btnShowTemplate_Click(object sender, RoutedEventArgs e)
        {
            XmlWriterSettings writer_settings = new XmlWriterSettings();
            writer_settings.Indent = true;
            writer_settings.IndentChars = "    ";
            writer_settings.NewLineOnAttributes = true;

            StringBuilder sb = new StringBuilder();
            XmlWriter xml_writer = XmlWriter.Create(sb, writer_settings);
            
            XamlWriter.Save(Target.Template, xml_writer);

            txtResult.Text = sb.ToString();
        }
	}
}