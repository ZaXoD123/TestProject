   M S B A M L   `   `   `  ����I  EStudentsBaseHD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:StudentsBaseHDStudentsBaseHD  5   	   "    StudentsBaseHD.AddStudWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:StudentsBaseHD     5   	     � Title$  Добавить��5   	   $	��200��6   $	��250��6'    � 
ResizeMode$ NoResize=�63   .��5	      �  � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      .+�5   
   �� $��Фамилия:��6   $��Stretch=�6#   $	��Top=�6A   $��0��6Y   $��	10,20,0,0q�6i   �� 5   
   $��Факультет:��6   $��Stretch=�6%   $	��Top=�6C   $��0��6[   $��	10,40,0,0q�6k   �� 5   
   $��Год рождения:��6   $��Stretch=�6(   $	��Top=�6F   $��0��6^   $��	10,60,0,0q�6n   �� 5   
   -   5         ��Name$ 
LastNameTB��5      $��1��6&   $��Stretch=�66    �� TextWrapping$
 Wrap=�6U   $�� ��6i   $	��Top=�6q   $��
10,24,20,0q�6�   �� 5   
   -   5        $ 	FacultyTB��5      $��1��6%   $��Stretch=�65   $
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $��
10,44,20,0q�6�   �� 5   
   -   5        $ 	BTHYearTB��5      $��1��6%   $��Stretch=�65   $
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $��
10,64,20,0q�6�   �� 5   
   $��Отмена��6   $
��Left=�6"   $��Bottom=�6=   $��75��6X   $��	20,0,0,20q�6c   $��0��6v    �� IsCancel . ��6�   Z� 6�   �� 5   
   -   5        $��Добавить��5      $��Right=�6$   $��Bottom=�6@   $��75��6[   $��	0,0,20,20q�6f   $��1��6y   ��6�   Z� 6�   �� 5   
   $��Спорт (опц.):��6   $��Stretch=�6(   $	��Top=�6F   $��0��6^   $��	10,80,0,0q�6n   $��2��6�   �� 5   
   -   5        $ SportTB��5      $��1��6#   $��Stretch=�63   $
 Wrap=�6R   $�� ��6f   $	��Top=�6n   $��
10,84,20,0q�6�   5      5      