   M S B A M L   `   `   `  ����C  ?Chapters, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Chapters.Chapter18Chapters.Chapter18  5      )    #Chapters.AutomationClientAPIExample   5      R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    8x,http://schemas.microsoft.com/winfx/2006/xaml    5      >d2http://schemas.microsoft.com/expression/blend/2008    5      Hmc;http://schemas.openxmlformats.org/markup-compatibility/2006    5      =Chapters_Chapter18 clr-namespace:Chapters.Chapter18    5      -   5          >�Name$  UserControl��5      4  .System.Windows.Automation.AutomationProperties   AutomationId$ ID_AutomationClient��5      .��5      ]� -   5         ]�Name$ 
LayoutRoot��5      .+�5   
   �� -   5         ��Name$ ConsoleText��5      $��0,0,0,8q�5      $��Bottom=�5      $	��200��5      $��Bottom=�5       �� TextWrapping$
 Wrap=�5       �� AcceptsReturn . " �� VerticalScrollBarVisibility$ Visible=�5      $ �� HorizontalScrollBarVisibility$ Hidden=�5      $ ID_ConsoleText��5      �� 5   
   $	��Top=�6   $��47��5      $��Bottom=�5       �� Orientation$ 
Horizontal=�5      .+�5      �� -   5        $
��Left=�5      $��8,0,0,0q�5      $��Locate Elements��5      $��Center=�5      	   Name$	 Locate Elements��5       5!      �� 5"      -   5        $
��Left=�5"      $��8,0,0,0q�5#      $��Find ScrollPattern��5$      $��Center=�5%      $	 Find ScrollPattern��5&      5'      �� 5(      -   5        $
��Left=�5(      $��8,0,0,0q�5)      $��Read Properties��5*      $��Center=�5+      $	 Read Properties��5,      5-      �� 5.      -   5        $
��Left=�5.      $��8,0,0,0q�5/      $��Listen to Events��50      $��Center=�51      $	 Subscribe to Events��52      53      �� 54      -   5        $
��Left=�54      $��8,0,0,0q�55      $��Unsubscribe from Events��56      $��Center=�57      $	 Unsubscribe from Events��58      59      �� 5:      -	   5        $
��Left=�5:      $��8,0,0,0q�5;      $��Navigate Tree��5<      $��Center=�5=      $	 Navigate Tree��5>      5?      �� 5@      -
   5        $
��Left=�5@      $��8,0,0,0q�5A      $��Invoke Operation��5B      $��Center=�5C      $	 Invoke Operation��5D      5E      �� 5F      -   5        $
��Left=�5F      $��8,0,0,0q�5G      $ ��Invoke Operation on Window��5H      $��Center=�5I      $ 	 Invoke Operation on Window��5J      5K      5L      � 5M   
   .+�5N      �� $	��Top=�6   $��27��5O      $��Button-1��5P      $	 Button-1��5Q      $��79��5R      $
��Left=�5S      $��8,8,0,0q�5T      �� 5U      $
��Left=�6   $��91,8,0,8q�5V      $	��117��5W      $
 �� IsSynchronizedWithCurrentItem$

 TrueY�5X      .@�5Y      �� $
��This��6   $
��Wrap=�5Z      $
��Bold"�5[      �� 5\      $��is��6   $
��Wrap=�5]      $
��Bold"�5^      �� 5_      $��a��6   $
��Wrap=�5`      $
��Bold"�5a      �� 5b      $��ListBox��6   $
��Wrap=�5c      $
��Bold"�5d      5e      &    Chapters.Chapter18.RangeSelector  5f      $	��Top=�6/   $��31��5g   /      Maximum$	 100Q�5h   /      
RangeStart$ 25Q�5i   /      RangeEnd$ 75Q�5j   /   $ ID_RangeSelector��5k   /   $��212,8,228,0q�5l   /   �� 5m      -   5        $��Bottom=�5m      $��27��5n      $��Invoke Button��5o      $��79��5p      $
��Left=�5q      $��8,0,0,8q�5r      $ ID_InvokeButton��5s      5t      5u      5v      5w      