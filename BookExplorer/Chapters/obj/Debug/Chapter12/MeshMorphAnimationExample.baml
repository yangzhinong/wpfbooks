   M S B A M L   `   `   `  ����C  ?Chapters, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Chapters.Chapter12Chapters.Chapter12  5      2    ,Chapters.Chapter12.MeshMorphAnimationExample   5      R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      ;Chapter_CustAnim clr-namespace:Chapters.Chapter12    5        � 	Resources  5         	MeshBrush �� ImageSource j� Stretch  MeshAnimator g� AccelerationRatio+   %Chapters.Chapter12.MeshMorphAnimation g� Duration   
EndSurface   HorizontalPoints   VerticalPoints �� 
TargetName	 �� TargetProperty��%.  &	        &	 Z    �� 5      $. (/Resources;component/Chapter12/world.jpg��5      $
 Fill=�5      �� 5
      $
 0.25Q�5      .��5        $ 0:0:2D�6)   $ CylinderX�5      $	 100��5      $	 100��5      $ MeshGeometry��5      $	 	Positions�5      5      5      .��5      ]� 
���   �.+�5      �� -   5        
 �� Orientation$
 Vertical=�5      
�������$��10q�5      $	��150��5      .+�5      	�  d� 	IsChecked$
 TrueY�6   .��6"   Plane6)   	� 5      .��6   Cone6   	� 5      .��6   
Cylinder6   	� 5      .��6   Sphere6   5      '� 5       -   5         '�Name$ 	_viewport��5        '� Camera 5!      =� 5"       =� FieldOfView$ 60Q�6    � Position$ 0,0,41�5#       � LookDirection$ 0,0,-45�5$       � UpDirection$ 0,1,05�5%      .x�5(      g�  g� Content 5)      h� 5*      .��5+      ��  �� Color$ 	LightCyan��6   h� 5,      -   5        _modelGroup�� j� 	Transform 5-   	   �� 5.   
    �� Rotation 5/      �� 50      -   5        Rotation�� �� Axis$ 0,1,05�51      53      56   	   57      5:      5<      5=      5?      