   M S B A M L   `   `   `  ����C  ?Chapters, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Chapters.Chapter10Chapters.Chapter10  5      R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35  �� 
TargetType �� TypeInTargetAssembly �� 
ResourceId �� Property �� Value �� 
TargetType ��Name �� Path �� RelativeSource	 �� Triggers
 P� Property P� Value �� 
TargetName   
TitleBrush �� 
StartPoint �� EndPoint � Offset � Color+    %Chapters.Chapter10.CustomChromeWindow � RowDefinitions �� CornerRadius ]�Name A� Rows ��Name    NormalImage    
HoverImage    PressedImage � Icon � Title�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    8x,http://schemas.microsoft.com/winfx/2006/xaml    5      .	Chapter10 clr-namespace:Chapters.Chapter10  5      %�  (��       5   	   $" Chapter10:CustomChromeWindowL�$ WindowButtonStyle��)&	  w    (�� �    56      $" Chapter10:CustomChromeWindowL�$ WindowTemplate��)7   0�� 5R      *�� $" Chapter10:CustomChromeWindowL�$ WindowButtonStyle��+10�� 5W      *�� $" Chapter10:CustomChromeWindowL�$ WindowButtonStyle��+10�� 5\      *�� $" Chapter10:CustomChromeWindowL�$ WindowButtonStyle��+1'   �    0�� 5�      *�� $" Chapter10:CustomChromeWindowL�$ WindowTemplate��+1�� 5      "  ��5      .�5      ��  � ��$ 30��5      �� 5       � �� 5	      �� 5
      " ��5   
   (��       5
      $" Chapter10:CustomChromeWindowL�$ ButtonTemplate��).R�5      � .+�5      �� ._�5   	   �� $ ButtonImage��6   $��24��5      $��20��5      $
��Fill=�5      ��5      �� $0 *(Chapter10:CustomChromeWindow.NormalImage)� �� *TemplatedParent+5      5   	   5      	 5      P� 5      
 �@J�IsMouseOver . . �5   	   �� $ ButtonImage��5   
    5   
   �� $/ )(Chapter10:CustomChromeWindow.HoverImage)� �� *TemplatedParent+ � ��5   	   P� 5      
 � �� . . �5   	   �� $ ButtonImage��5    
    5!   
   �� $1 +(Chapter10:CustomChromeWindow.PressedImage)� �� *TemplatedParent+ � ��5"   	   5$      5&      5'      �� 5)      $	 0,0&�5*      $	 0,1&�5+      .��5,      � $ 0Q�6   $ 	#5FCCCCCC��5-      � 5.      $	 0.5Q�6   $ 	#5FCCCCCC��5/      � 50      $	 0.5Q�6   $ Transparent��51      � 52      $ 1Q�6   $ Transparent��53      54      �� 56      "   57      .R�58      � 
������  59      �� 5:      $��32 �6   �� 5;      $��* �6   .+�5>      �� $��0��6   $��2��5?      
���   �$��1q�5A      $ 5��5B      ._�5C      �� ���	#0FFFFFFF$��1q�5D      $ 5��5E      ���	#cF0000005F      5G      ]� 5H      $ PART_TitleBar��6   $��0��5I   	   8��  .+�5K      A� $ 1��6   $��0,2,10,0q�5L   	   $��Right=�5M   	   .+�5N      �� $ PART_Minimize��6   $% WindowDecoration/min_normal.png��5O      $$ WindowDecoration/min_hover.png��5P      $&  WindowDecoration/min_pressed.png��5Q      ��5R      2 �� 5S      $ PART_Maximize��6   $% WindowDecoration/max_normal.png��5T      $$ WindowDecoration/max_hover.png��5U      $&  WindowDecoration/max_pressed.png��5V      ��5W      2 �� 5X      $ 
PART_Close��6   $' !WindowDecoration/close_normal.png��5Y      $&  WindowDecoration/close_hover.png��5Z      $( "WindowDecoration/close_pressed.png��5[      ��5\      2 5]      �� 5^      $��22��6   $��22��5_   	   $
��Left=�5`   	   #��z 5a   	   $��10,2,2,0q�5b   	   �� 5c      #��z 6   
�������$��Center=�5e   
   $
��Bold"�5f   
   5g      �� 5i      $��1��6   $��1q�5j      ���	#3FFFFFFF$��8,0,8,8q�5l      ._�5m      �� 5n      5p      	 5r      P� 5s      
 �@�WindowState$ 	Maximized=�5t      . �5u      �� $ PART_Maximize��5w       �@  NormalImage$) #WindowDecoration/restore_normal.png��5v      5w      �� 5x      $ PART_Maximize��5z       �@  
HoverImage$( "WindowDecoration/restore_hover.png��5y      5z      �� 5{      $ PART_Maximize��5}       �@  PressedImage$* $WindowDecoration/restore_pressed.png��5|      5}      5~      5�      �� 5�      "    6	   .�5�      ��  � �� 5�      2  5�      5�      