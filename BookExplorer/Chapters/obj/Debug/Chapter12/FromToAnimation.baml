   M S B A M L   `   `   `  ����  Chapters(    "Chapters.Chapter12.FromToAnimation   5      R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5        � 	Resources  5         FromToColorAnimation �� From	 �� To g� Duration �� 
TargetName �� TargetProperty��%�   &	        �� 5      .��5      �� $ VioletX�6   $	 RedX�5      $ 0:0:3D�5      $ FromToEllipse��5	      $" Fill.(SolidColorBrush.Color)�5
      5      5      .��5      ]� .+�5      ��  �� Orientation$ 
Horizontal=�6   $	��Top=�5   	   $��Right=�5   	   .+�5      �� -   5         ��Name$ _fromToPlay��5      .��6!   Play Animation61   5      A� 5      -   5         A�Name$ FromToEllipse��5      
�������
�������5      5      	 � Triggers	 5      :� 5      
 :� RoutedEvent$
 Button.Click��6    :� 
SourceName$ _fromToPlay��5   
   .[�5      �� #��[  6   5      5      