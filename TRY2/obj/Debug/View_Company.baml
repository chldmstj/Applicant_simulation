   M S B A M L   `   `   `  ����?  ;TRY2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TRY2TRY2  5   	   #clr-namespace:TRY2.APITRY2.API  5   	   #clr-namespace:TRY2.DBCTRY2.DBC  5   	       TRY2.View_Company   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:TRY2     5   	   &apiclr-namespace:TRY2.API     5   	   &dbcclr-namespace:TRY2.DBC     5   	     � Title$  View_Company��5
   	   $	��450��6   $
��1000��6+   .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $
��645* �6   �� 5      $
��149* �6   .+�5   
   �� -   5         ��Name$ 	lvControl��5      $
��Left=�6&   $	��271��6A   $��	25,29,0,0q�6N   $	��Top=�5      $	��600��6+    �� View 5      �� 5      -   5        list��.P�5      �� -   5        name��$��	회사명��5   3    �� Width$	 150��6@    �� DisplayMemberBinding 5   %   �� *Name+�� 5      -   5        	title��$��	공고명��5   4   $	 450��6A    5   %   �� *Title+�� 5      -   5        ID��$��공고 번호��5   1   $ 0��6@    5   %   �� *Id+5       5#      � 5%   
   
���P��$��650,26,9.6,20q�6"    J� RenderTransformOrigin$ -0.593,0.634&�69   $��2��6^   .+�5'      �� .+�5)      �� -   5         ��Name$ TITLE��52      
�������$
��Wrap=�5*      $��Century Gothic)�5+      $��25(�5,      $��
UltraBlack"�5.       �� 
LineHeight$ 10��50      	 �� TextAlignment$	 Center=�51      $ 0.477,0.269&�53      $��10,10,10,10q�65   $��74��6J   	회사명55      �� 56      -   5        $ Content��5?      
�������$
��Wrap=�57      $��10(�59      $��
UltraBlack"�5;      $ 20��5=      $
	 Left=�5>      $ 0.477,0.269&�5@      $��10,10,10.4,10q�65   $	��256��6L   공고내용5B      5C      �� 5D      -   5        $��Center=�5D      $��Bottom=�63   $	��100��6N   $��20��6Z   $��126,0,108,26q�6f   
���  ��$��	UltraBold"�5E   !   
�������.��5G   +   합격률 확인63   5M      �� 5O   
   -	   5        $
��Left=�5O      $��Bottom=�6,   $	��200��6G   $��50��6S   $��	20,0,0,20q�6_   $��뒤로가기��6r   5P      5U      5V      