   M S B A M L   `   `   `  ����C  ?Chapters, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ShaderLibraryShaderLibrary  5      6    0Chapters.Chapter13.Displacement_MultiInputTester   5      R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      3ShaderLibraryclr-namespace:ShaderLibrary    5        � 	Resources  5         GradientBrush 
� GradientOrigin 
� RadiusX 
� RadiusY 
� Center � SpreadMethod � Offset � Color��%"  &	        
� 5      $ 0.5,0.5&�5   	   $
 0.25Q�5   	   $
 0.25Q�5	   	   $ 0.5,0.5&�5
   	   $ Repeat=�5   	   .��5      � $ 0Q�6   $ White��5   	   � 5      $	 0.5Q�6   $ Black��5   	   � 5      $ 1Q�6   $ White��5   	   5      5      .��5      ]� .+�5      �� $��Effect Controls��6   $
��Left=�5      $	��150��5      .��5      �� .+�5      �� $��Scale-X��6   $
��Bold"�5   
   $��0,0,0,8q�5   
   �� 5      -   5         ��Name$ _scaleXSlider��5      	 � Minimum$	 0Q�5      
 � Maximum$
 2Q�5       � SmallChange$	 0.1Q�5       � LargeChange$	 0.1Q�5       �� 5!      $��Scale-Y��6   $
��Bold"�5"   
   $��0,0,0,8q�5#   
   �� 5$      -   5        $ _scaleYSlider��5$      $	 0Q�5%      $
 2Q�5&      $	 0.1Q�5'      $	 0.1Q�5(      5)      5*      � 5+      .+�5,      �� -   5         ��Name$ DisplacementVisual��5,      #��[  5-   	   �� 5.      $,��&/Resources;component/Shared/toucan.jpg��6   $
��Fill=�5/       J� Effect 50      &    ShaderLibrary.DisplacementEffect  51      -   5        
Effect��   ScaleX 52      �� *Value+ �� ElementName$ _scaleXSlider��   ScaleY 53      �� *Value+$ _scaleYSlider��   Input2 54      !� 55   	    !� Visual 6   �� $ DisplacementVisual��57      5:      5;      5=      5>      