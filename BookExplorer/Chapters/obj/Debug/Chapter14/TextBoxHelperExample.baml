   M S B A M L   `   `   `  ����C  ?Chapters, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Chapters.Chapter14Chapters.Chapter14  5      -    'Chapters.Chapter14.TextBoxHelperExample   5      R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      4	Chapter14 clr-namespace:Chapters.Chapter14    5        � 	Resources  5       �� 
TargetType �� Property �� Value �� 
TargetType �� Padding J� SnapsToDevicePixels ��Name ��Name/   )Chapters.Chapter14.TextBoxWatermarkHelper	   WatermarkText
 � Cursor � ForceCursor �� Triggers P� Property P� Value �� 
TargetName��%�  '��       �� 5      " ��6
   .�5      ��  � �� �#9999995      �� 5	       � ��$ 0q�5
      �� 5       � ��$
 Bold"�5      �� 5       � ��$
 12pt(�5      �� 5       � �� 5      �� 5      " ��6   .R�5      �� $��1q�6   #��z��5   	   #��z��5   	   $ 1q�5   	    . ._�5   	   � .+�5   
   �� $ PART_ContentHost��6   $��4,0,0,0q�5      �� 5   
   $ 	Watermark��6   $��8,0,0,0q�5      #��z	 5      |�.  $��14(�5      $��Italic$�5      #��z��5       $��Center=�5!      $
 IBeam��5"       . ���	#AF0000005$      5%   
   5&   	    5(      P� 5)   	    �@ IsWatermarkVisible . . �5+   
   �� $ 	Watermark��5-       � y�$ Visible=�5,      5-      �� 5.   
   $ PART_ContentHost��50       � y�$ Hidden=�5/      50      51   
   P� 52   	    �@ IsWatermarkVisible .  . �54   
   �� $ 	Watermark��56       � y�$ Hidden=�55      56      �� 57   
   $ PART_ContentHost��59       � y�$ Visible=�58      59      5:   
   5<      5>      5?      5@      .��5B      � $��30��6   $	��200��5C       � ColumnDefinitions 5D      �� 5E      �� 5F      .+�5I      �� $��0��6   $	 Username��5J      $��0,0,8,0q�5K      �� 5L      $��1��6   $	 Password��5M      5N      5O      