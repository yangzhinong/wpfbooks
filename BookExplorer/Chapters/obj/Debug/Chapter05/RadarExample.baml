   M S B A M L   `   `   `  ����C  ?Chapters, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Chapters.Chapter05Chapters.Chapter05  5      %    Chapters.Chapter05.RadarExample   5      R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      4	Chapter05 clr-namespace:Chapters.Chapter05    5        � 	Resources  5      �� 5         Key	EnemyList   �� Type   Chapters.Chapter05.Enemy"  5      .s�5           Location$ 200,350&�6      Velocity$	 3,4-�5	   	      Type$- '/Resources;component/Chapter05/ship.png��5
   	     5      $ 10,50&�6   $	 2,4-�5   	   $. (/Resources;component/Chapter05/plane.png��5   	     5      $ 150,50&�6   $	 3,4-�5   	   $. (/Resources;component/Chapter05/plane.png��5   	     5      $ 50,300&�6   $
 3,-4-�5   	   $- '/Resources;component/Chapter05/ship.png��5   	     5      $ 20,400&�6   $
 3,-4-�5   	   $, &/Resources;component/Chapter05/sub.png��5   	   5      �� 5      FluoroGreen   �� Color$ #42ff00��5      �� 5      RadarTemplate   �� 
TargetType" ��5      .R�5      �   5        SweepingLineBrush 
� GradientOrigin 
� RadiusX	 
� RadiusY
 � Offset � Color  FluoroGreen �� Source��%�   &	       7  
� 5      $	 0,1&�5       $ 1Q�5!      $	 1Q�5"      .��5#      � $
 0Q�6    5$      �� *Color+8   � 5%      $
 1Q�6   $ Transparent��5&      5'      5(       � RowDefinitions 5)      �� 5*      �� 5+       � ColumnDefinitions 5-      �� 5.      �� 5/      .+�52      �� $��64��6   $,��&/Resources;component/Chapter05/sub.png��53   	   $��0��54   	   $��0��55   	   $��2��56   	   $��2��57   	    J� Opacity$
 0.75Q�58   	   '   !Chapters.Chapter05.MarkersElement  5:         
Foreground# [ 6      
DeltaAngle$ 45Q�5;      $��0��5<      $��0��5=      $��2��5>      $��2��5?      $
 0.75Q�5@      F� 5B       F�Name$ 	SweepLine��6   #��[ 5C      $��0��5D       �� Stretch$ Uniform=�5E      $
��Left=�5F      $��0��5G      $��1��5H       J� RenderTransformOrigin$	 0,1&�5I      G����        �    @B zNJ��}�?��w��|�?zNJ��}�?��w��|�?�� 	z�5K      �� 5L      5N      �� 5P      $��0��6   $��0��5Q   	   $��2��5R   	   $��2��5S   	   5U       �� Triggers 5W      :� 5X       :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5Y      �� .��5Z      �� .��5[   	   W�  W� From$ 0X�6   	 W� To$ 359.99X�5\       g� Duration$ 0:0:5D�5]       �� 
TargetName$ 	SweepLine��5^       �� TargetProperty$- 'RenderTransform.(RotateTransform.Angle)�5_       g� RepeatBehavior$ Forever��5`      U� 5a   	   $ 0:0:2.5D�6'   $ 	SweepLine��5b      $ Opacity�5c      $ Forever��5d      .\�5e   
   ��  O� KeyTime$ 0%��6    O� Value 0.15f      �� 5g   
   $	 50%��6    15h      �� 5i   
   $
 100%��6    0.15j      5k   
   5l   	   5m      5n      5p      �� 5r      EnemyTemplate   �� DataType$ Chapter05:Enemy��5s      .R�5t      �� $
��Fill=�5u      ��5t      �� *Type+5u      5v      �� 5x      ListBoxItemTemplate  " ��5y      .R�5z      � $��30��6
   $��30��5{      .+�5      ��   ��Name$  Inspect��6   $y�	Collapsed=�5�      ! J� IsHitTestVisible! .  .+�5�      �� $6��0/Resources;component/Chapter05/InspectBubble.png��6   $	��150��5�   
   �� 5�      $��20q�6   $	��110��5�   	   .+�5�      �� 
�������$
��Bold"�5�      $��Center=�5�      ��5�      �� *
Location+" �� StringFormat$" ({0})��5�      �� 5�      
���������5�      �� *
Velocity+$" Direction: {0}���� 5�      
�������$��Italic$�5�      ��5�      �� *Angle+$" Angle: {0:F2}˚��5�      z�5�      T� 5�      # T� X$	# -75Q�6   $ T� Y$
$ -110Q�5�      5�      �� 5�      $ 0.5,0.5&�6   z�5�      �� 5�      % �� Angle% 6   �� *Angle+5�      z�5�      T� 5�      # 6   �� *
Location.X+$ 5�      �� *
Location.Y+5�       5�      P� 5�      & P� Property& �@��
IsSelected' P� Value' . . �5�      �� ( �� 
TargetName$( Inspect��5�      ) �� Property) � y�* �� Value$* Visible=�5�      5�      �� 5�      ) �@K�ZIndex$* 1��5�      5�      5�      �� 5�      + �� 
TargetType"+ ��6
   .�5�      �� ) � ��  ListBoxItemTemplate#* [ 5�      5�      �� 5�      "+ ��6
   .�5�      �� ) � ��  RadarTemplate#* [ 5�      �� 5�      ) � ��$	* 500��5�      �� 5�      ) � ��$	* 500��5�      �� 5�      ) � ��* 5�      �� 5�      .R�5�      �� , K� IsItemsHost, . 6   5�      5�      5�      .��5�      � 
���   �.+�5�      �� -   5        - ��Name$- _enemies��5�        	EnemyList#��[ 5�        EnemyTemplate#��[ 5�      5�      5�      