   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5       Chapters-   'Chapters.Chapter05.ListBoxCustomization   5      R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      7System&clr-namespace:System;assembly=mscorlib    5        � 	Resources  5      �� 5         Key
DataSource   �� Type" ��5      .s�5      ��Sun��6   ��5	      
Sirius��6   ��5
      Canopus��6   ��5      Rigil Kentaurus��6$   ��5      Arcturus��6   ��5      Vega��6   ��5      Capella��6   ��5      	Rigel��6   ��5      Procyon��6   ��5      Achernar��6   ��5      
Betelgeuse��6   ��5      	Hadar��6   5      �� 5      NormalBrush   �� 
StartPoint$	 0,0&�5   	    �� EndPoint$	 0,1&�5   	   .��5      �  � Offset$ 0Q�6    � Color$ #feffe8��5   	   � 5      $ 1Q�6   $ #d6dbbf��5   	   5      �� 5      SelectedBrush  $	 0,0&�5   	   $	 0,1&�5    	   .��5!      � $ 0Q�6   $ 	#7fcfe1ed��5"   	   � 5#      $ 1Q�6   $ 	#7f7faaca��5$   	   5%      �� 5'      ListBoxItemStyle   �� 
TargetType" ��5(      .�5)      ��  �� Property �@�FocusVisualStyle �� Value 5*      Z� �� 5+       � ��$ 5,5,5,0q�5,      �� 5.       �@J�RenderTransformOrigin$ 0,0.5&�5/      �� 51       � z� 52      �� 53      	 �� ScaleX$	 1Q�6   
 �� ScaleY$
 1Q�54   
   56      �� 58       � �� 59      �� 5:       �� 
TargetType" ��6   .R�5;      ��  ��Name$
 Root��6   ���#bdc1a3$��1q�5=   	    �� CornerRadius$ 5��5>   	     NormalBrush#��[ 5?   	   ._�5@   	   �� #��z��6   #��z��5A      $��Center=�5B      $��Center=�5C      5D   	    �� Triggers 5F      P� 5H   	    P� Property �@J�IsMouseOver P� Value . . �5J   
   ��  �� 
TargetName$
 Root��5L       � �� �#2a849d5M   
   P� 5P   	    �@��
IsSelected . . �5R   
   ��  �@K�ZIndex$ 1��5S      �� 5T   
   $
 Root��5V       � �� �#2a849d�� 5W   
     SelectedBrush# [ 5X      $
 Root��5Y       � �� N� EnterActions 5Z   
   �� 5[      .��5\      �� .��5]      W� 	 W� To$
 1.25X�6    g� Duration$ 0:0:0.25D�5^       �� TargetProperty$- 'RenderTransform.(ScaleTransform.ScaleX)�5_      W� 5`      $	 1.5X�6   $ 0:0:0.25D�5a      $- 'RenderTransform.(ScaleTransform.ScaleY)�5b      5c      5d       N� ExitActions 5f   
   �� 5g      .��5h      �� .��5i      W� $ 1X�6   $ 0:0:0.25D�5j      $- 'RenderTransform.(ScaleTransform.ScaleX)�5k      W� 5l      $ 1X�6   $ 0:0:0.25D�5m      $- 'RenderTransform.(ScaleTransform.ScaleY)�5n      5o      5p      5r   
   5t      5v      5w      �� 5y      ItemTemplate  .R�5z      �� $��18(�5{   	   ��5z      �� 5{   	   5|      �� 5~      PanelTemplate  .R�5      �  � 	ItemWidth$	 200��6    � 
ItemHeight$ 50��5�   	    � Orientation$ Vertical=�5�   	    K� IsItemsHost . $��0,10,0,0q�5�   	   5�      .��5�      � .+�5�      �� -   5         ��Name$ _listBox��5�        
DataSource#��[ 5�        ListBoxItemStyle#��[ 5�        ItemTemplate#��[ 5�        PanelTemplate#��[ 5�      $��Center=�5�      $	��250��5�      $��0q�5�      5�      5�      