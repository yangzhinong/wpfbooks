   M S B A M L   `   `   `  ����C  ?Chapters, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Chapters.Chapter08Chapters.Chapter08  5      D @Resources, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullJ3clr-namespace:Chapters.Resources;assembly=ResourcesChapters.Resources 5      -    'Chapters.Chapter08.StaggeredPanelTester   5      R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      4	Chapter08 clr-namespace:Chapters.Chapter08    5      G	Resources3clr-namespace:Chapters.Resources;assembly=Resources    5        � 	Resources  5      )  #Chapters.Resources.StringCollection   
DataSource  BackgroundBrush �� 
StartPoint �� EndPoint � Offset � Color  HilightBrush  SelectedBrush  StringTemplate ��Name �� Triggers �� Value �� Binding	 �� Path
 �� RelativeSource �� Mode �� AncestorType �� 
TargetName �� Property �� Value �� 
TargetType �� 
TargetType ��Name �� CornerRadius J� SnapsToDevicePixels �� Triggers P� Property P� Value��%�  &	        &	      &	 �     &	 [    &	 3    '�� �    7  7  7    5      6   �� 5      $	 0,0&�5	   	   $	 1,0&�5
   	   .��5      � $ 0Q�6   $ #777777��5   	   � 5      $ 1Q�6   $ #222222��5   	   5      �� 5      $	 0,0&�5   	   $	 1,0&�5   	   .��5      � $ 0Q�6   $ #999999��5   	   � 5      $ 1Q�6   $ #555555��5   	   5      �� 5      $	 0,0&�5   	   $	 1,0&�5   	   .��5      � $ 0Q�6   $ #c1dbe8��5   	   � 5      $	 0.5Q�6   $ #008fc7��5    	   � 5!      $ 1Q�6   $ #066caa��5"   	   5#      �� 5%      .R�5&      �� $
 Text��6   $��24(�5(   	   
�������$
��Left=�5*   	   $��Center=�5+   	   $��10q�5,   	   ��5'   	   �� 5,   	    5.      �� 5/      $
 True��50   	    5/      �� $	 
IsSelected�
 �� $ FindAncestor=�" ��.a�51      �� $
 Text��53       � �� �#33333354      56      �� 58      " ��6
   .�59      ��  � �� 5:      �� 5;      " ��6   .R�5<      �� $ Border��6   $ 	20,0,0,20��5=   	   8��  
���   �$��1q�5@   	    . ._�5B   	   �� #��z��6   #��z��5C      5D   	    5F      P� 5G   	    �@J�IsMouseOver . . �5I   
   �� 8  $ Border��5K       � ��5L   
   P� 5M   	    �@��
IsSelected . . �5O   
   �� 8  $ Border��5Q       � ���� 5R   
   $ Border��5T       � �� �#0075b05U   
   5W      5Y      5Z      5\      .��5^      ]� .+�5_      �� -   5         ��Name$ _deferredScroll��5_      $	��Top=�5`      $��10q�5a      .��6   Deferred Scrolling6'   � 5b      .+�5c      �� -   5         ��Name$ _itemsControl��5c      #��[  5d      #��[ 5e      $��Stretch=�5f      $��Stretch=�5g      $��10q�5h      ��5j      �� 5k      .R�5l      �� ��. $��Visible=�5m      ! �� IsDeferredScrollingEnabled 5n      �� *	IsChecked+ �� ElementName$ _deferredScroll��.��5o   	   �� 5p   	   5q      ��5t      �� 5u      .R�5v      '   !Chapters.Chapter08.StaggeredPanel     	ItemWidth$	 200Q�6!      
ItemHeight$	 150Q�5w         StaggerValue$	 0.5Q�5x       K� IsItemsHost . 5y      5z      5}      5~      �� 5�        $� IsVirtualizing  . ! $� VirtualizationMode$! 	Recycling=�5�      #��[  5�      #��[ 5�      5�      5�      