   M S B A M L   `   `   `  ����C  ?Chapters, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Chapters.Chapter03Chapters.Chapter03  5      ,    &Chapters.Chapter03.CircularMinuteTimer   5      R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      1Runner clr-namespace:Chapters.Chapter03    5        � 	Resources  5      1   +Chapters.Chapter03.ProgressToAngleConverter   ProgressConverter �� 
TargetType �� Property �� Value �� 
TargetType   Chapters.Chapter03.Arc   
StartAngle `� 	Converter �� Path �� RelativeSource	   EndAngle
 �� StringFormat��%�  &	        '�      7   7     5      6$   �� 5      " �6
   .�5	      ��  � �� 5
      �� 5      " �6   .R�5      � .+�5   	   A� 
���   �#��z��5      A� 5   	   
���   �$��40q�5      
�������5        5   	   $��30��6   #��z��5      $��5q�5       5   
   `� 5      8   .1�5      �� $ Minimum�6    5      �� *TemplatedParent+�� 5      $ .�6    5      �� *TemplatedParent+5      	 5   
   `� 5      8  .1�5      �� $ Value�6    5       �� *TemplatedParent+�� 5!      $ .�6    5"      �� *TemplatedParent+5#      5%   
   �� 5'   	   #��z��5(      $��Center=�5)      $��Center=�5*      $��72(�5+      $
��Bold"�5,      ��5'      �� *Value+ �� *TemplatedParent+$
 {0:0}��5,      5-   	   5.      50      51      52      .��54      � .+�55      � -   5         �Name$ 	_progress��55       � Minimum$ 0Q�56   
    � Maximum$ 60Q�57   
    � Value$ 30Q�58   
   ���#7f7f7f���#ffbd675:   
   5;       � Triggers 5=      :� 5>       :� RoutedEvent$ Window.Loaded��6   .[�5?      �� .��5@      ��  g� RepeatBehavior$ Forever��6   .��5A      W�  W� From$ 0X�6   	 W� To$ 60X�5B       �� 
TargetName$ 	_progress��5C       �� TargetProperty$ Value�5D       g� Duration$ 0:0:3D�5E      5F      5G      5H      5J      