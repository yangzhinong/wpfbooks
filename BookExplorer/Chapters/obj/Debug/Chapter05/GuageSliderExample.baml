   M S B A M L   `   `   `  ����C  ?Chapters, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Chapters.Chapter05Chapters.Chapter05  5      +    %Chapters.Chapter05.GuageSliderExample   5      R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      4	Chapter05 clr-namespace:Chapters.Chapter05    5        � 	Resources  5         DrawingBrush1 j� Viewbox j� ViewboxUnits L� Drawing � Brush � Color � Offset � Geometry � 	Transform	 u� Matrix

 � Pen >� Brush >� DashCap >� 
EndLineCap >� LineJoin >� 
MiterLimit >� StartLineCap >� 	Thickness  SliderTemplate �� 
TargetType � RowDefinitions   Chapters.Chapter05.Guage   Ticks   TickSize   	TickBrush  Name J� RenderTransformOrigin J� Opacity �� Angle �� RelativeSource��%�  &	        &	 �    L� 5   
   $ 
0,0,21,121�5      $ Absolute=�5       5	      � 5
       5      
� 5      .��5      � $ 	#FFF51212��6+   $ 0Q�5      � 5      $ 	#FFE45808��6+   $ 1Q�5      5       5      B� 5      $����M149.50001,79.499991 C149.50001,79.499991 139.49997,189.49994 139.49997,189.49994 139.49997,189.49994 149.50001,199.49994 149.50001,199.49994 L159.50005,189.49994 zC�6'    5      u� 5   "   $M	 G0.999996185317286,0,0,1.00000044504821,-138.9994373343,-79.000027751935x�62   5      
 5      >� 5       �	#FF000000$
 Flat=�5   	   $
 Flat=�5   	   $ Miter=�5   	   $ 10Q�5   	   $
 Flat=�5    	   $ 1Q�5!   	   5#      5%      �� 5'   
   " ��5(      .R�5)      �  5*      �� 5+      �� 5,      .+�5.        $	 100��6"   $
 1,25��5/   
   $��0��50   
   $��2��51   
   
 �����52   
     53      $ 
PART_Track��58   
   $ 20��53   "   $
 2,50��54   
   $��0��55   
   $��2��56   
   
 �\\��58   
   �� 59      $��WPF Speedometer��6   $��14(�5:   
   
���   �$��Center=�5<   
   $��Center=�5=   
   �� 5>      $��0��6   $��Stretch=�5?   
   $ 0.5,1&�5@   
   $��50��5A   
   $
 0.75Q�5B   
   
���  ��z�5D      �� 5E       6*   �� *Value+ �� *TemplatedParent+5G      5H      5I      5J      .��5K      ]� .+�5L   
   �� $	��Top=�5M      ��5L      �� *Value+ �� ElementName$ _slider��5M      �� 5N   
   -   5         ��Name$ _moveSlider��5N       � Minimum$	 -90Q�5O       � Maximum$ 90Q�5P        � Value$  45Q�5Q      ! �� Orientation$! Vertical=�5R      $��50��5S      $��20,0,0,0q�5T      $	��Top=�5U      $	��200��5V      $
��Left=�5W      �� 5X   
   -   5        $ _slider��5X      $	 -90Q�5Y      $ 90Q�5Z      #��[ 5[        5\      �� *Value+$ _moveSlider��5]      5^      