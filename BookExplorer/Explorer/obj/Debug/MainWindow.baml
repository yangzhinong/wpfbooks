   M S B A M L   `   `   `  ����G  CBookExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ExplorerExplorer  5          Explorer.MainWindow   5   	   R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      )Explorerclr-namespace:Explorer    5        � Title$7  1Book Explorer - WPF Control Development Unleashed��5      $	��480��5      $	��640��5       � WindowState$ 	Maximized=�5       � Icon$ Resources/book.png��5	      ���#0e0e0e � 	Resources 5          Explorer.XmlToUriConverter   UriConverter  BookMeta � Source � XPath��%n   &	        &	        5      6   � 5      $ BookMeta.xml?�5      $ /Book/Chapter��5      5      .��5      ]� $��8q�6   .+�5      �� $
��Left=�6     BlackGradient#��[ 5        RedGradient#��[ 5      $��1q�5       �� Padding$ 5q�5       J� SnapsToDevicePixels . ._�5      R� -   5         R�Name$ 	_treeView��5        ChapterTemplate#��[ 5        TreeViewTemplate#��[ 5      $	��300��5      $��0q�5      
������ ��5      �� 	 �� Source#	 [ 5      5       ]� 5"      $��8,0,0,0q�5#      
 � DataContext
 5"      �� *SelectedItem+ �� ElementName$ 	_treeView��.+�5&      �� $	��Top=�6   $ 15q�5'      #��[ 5(      ._�5)      �� $��24(�5*   
    �� TextAlignment$ Center=�5+   
   
���������5)      ��  �� XPath$ @Title��5,   
   5-      �� 50      
�������$��Bottom=�51      ._�52      �� $
��Bold"�53   
   $��10q�54   
   $
��Wrap=�55   
   $ Center=�56   
   ��52      �� $ Description��56   
   57       � 5:        � NavigationUIVisibility$ Hidden=�5;      
�������  � Source 5:      ��  �� 	Converter# [  5<      5=      5>      5?      