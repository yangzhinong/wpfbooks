   M S B A M L   `   `   `  ����C  ?Chapters, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Chapters.Chapter13Chapters.Chapter13  5      -    'Chapters.Chapter13.EffectMappingExample   5      R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      4	Chapter13 clr-namespace:Chapters.Chapter13    5      .��5      ]� .+�5      �� $
��Left=�6   $	��200��5   	   .+�5      �� ��6   �� *Value+  �� ElementName$  _left�� �� StringFormat$ Left: {0:F2}���� 5	      -   5         ��Name$ _left��5	       � Minimum$ 0Q�5
   
    � Maximum$ 1Q�5   
    � Value$
 0.25Q�5   
    � SmallChange$	 0.1Q�5   
   �� 5      $��0,10,0,0q�6   ��5      �� *Value+$  _right��$ Right: {0:F2}���� 5      -   5        $ _right��5      $ 0Q�5   
   $ 1Q�5   
   $
 0.75Q�5   
   $	 0.1Q�5   
   5      {� 5      -   5         {�Name$ _buttonParent��5      ._�5      �� -   5         ��Name$ _button��5      $+��%Testing SqueezeEffect + EffectMapping��5      $��24(�5      	 J� Effect	 5      &    Chapters.Chapter13.SqueezeEffect  5      
   Left
 6   �� *Value+$  _left��   Right 5      �� *Value+$  _right��5      5      5       5!      