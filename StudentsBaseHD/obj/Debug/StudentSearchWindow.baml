   M S B A M L   `   `   `  ����I  EStudentsBaseHD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:StudentsBaseHDStudentsBaseHD  5   	   (    "StudentsBaseHD.StudentSearchWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:StudentsBaseHD     5   	     � Title$  
Поиск��5   	   $	��200��6   $	��250��6$    � 
ResizeMode$ NoResize=�60   .��5	      � .+�5
   
   �� -   5         ��Name$ 	SomeText1��5
      $��Год рождения:��6#   $
��Left=�6;   $��Center=�6V   $��
20,0,0,110q�6q   �� 5   
   -   5        $ 	SomeText2��5      $y�Hidden=�6#   $��Фамилия:��67   $
��Left=�6J   $��Center=�6e   $��
20,0,0,110q�6�   �� 5   
   $��Факультет:��6   $
��Left=�6%   $��Center=�6@   $��	20,0,0,70q�6[   �� 5   
   -   5         ��Name$ 
FirstArgTB��5      $��Right=�6&    �� TextWrapping$
 Wrap=�6B   $��Center=�6W   $��50��6r   $��
0,0,20,110q�6}   �� 5   
   -   5        $ SecondArgTB��5      $��Right=�6'   $
 Wrap=�6C   $��Center=�6X   $��50��6s   $��	0,0,20,70q�6~   �� 5   
   $��Отмена��6   $
��Left=�6"   $��Bottom=�6=   $��75��6X   $��	20,0,0,10q�6y    �� IsCancel . ��6c   Z� 6�   �� 5   
   -   5        $��Искать��5      $��Right=�6"   $��Bottom=�6>   $��75��6Y   $��	0,0,20,10q�6z   ��6d   Z� 6�   	� 5   
   -   5         	�Name$ YearRB��5       d� 	IsChecked$
 TrueY�6&   $$��по году рождения��67   $
��Left=�6R   $��20,0,0,0q�6m   $��Center=�6   6�   	� 5   
   -   5        $��по факультету��5      $
��Left=�6.   $��	20,40,0,0q�6I   $��Center=�6\   6w   5      5      