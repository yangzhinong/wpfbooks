   M S B A M L   `   `   `  ����  Chapters,    &Chapters.Chapter02.MediaElementExample   5      R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5        � 	Resources  5         
StopButton �� ImageSource  RewindButton  
PlayButton  PauseButton  ButtonTemplate �� 
TargetType ��Name  PlayButtonTemplate �� Triggers P� Property P� Value �� Value �� 
TargetName	 �� Property��%D  &	        &	 L     &	 �     &	 �     &	 2    &	 �    7  7  7  �� 5      $4 ./Resources;component/Chapter02/player_stop.png��5   	   �� 5      $5 //Resources;component/Chapter02/player_start.png��5   	   �� 5	      $4 ./Resources;component/Chapter02/player_play.png��5
   	   �� 5      $5 //Resources;component/Chapter02/player_pause.png��5   	   �� 5      " ��5      .R�5      � .+�5      �� $
 Rect��6   #��z��5      5      5      �� 5      " d�5      .R�5      � .+�5      �� $
 Rect��6   8��  5      5       5      P� 5       �@d�	IsChecked$
 TrueY�5   
   . �5      �� 8  $
 Rect��5!   
   	 � ��5"      P� 5#       �@d�	IsChecked$ FalseY�5$   
   . �5%      �� 8  $
 Rect��5'   
   	 � ��5(      5*      5+      
 J� CommandBindings
 5,      )  #System.Windows.Input.CommandBinding  5-      -   5           Command$# MediaCommands.TogglePlayPause��5-      5/        50      -   5        $ MediaCommands.Stop��50      52        53      -   5        $ MediaCommands.Rewind��53      55      .��57      ]� .+�58      � $��Bottom=�6	   .+�59      �� $	��180��6   $��24��5:      
�������
�������$��1q�5=       �� CornerRadius$ 12��5>       J� SnapsToDevicePixels .  5?      �� 5@       �� Orientation$ 
Horizontal=�6   $��Center=�5A   
   .+�5B      �� $��MediaCommands.Rewind��6   #��[ 5C   	   #��[ 5D   	   $��32��5E   	   $��32��5F   	   .��6   Rewind6   d� 5G      -   5         d�Name$ _playBtn��5G      $#��MediaCommands.TogglePlayPause��5H      #��[ 5I      $��48��5J      $��48��5K      $��	10,0,10,0q�5L       � FocusVisualStyle 5M      Z� �� 5N      $��MediaCommands.Stop��6   #��[ 5O   	   #��[  5P   	   $��32��5Q   	   $��32��5R   	   .��6   Stop6   5S      5T      r� 5U      -   5         r�Name$ 	_mediaElt��5U       r� Source$ Chapter02/Bear.wmv?�5V   
    r� LoadedBehavior$ Manual=�5W   
   5X      5Y      