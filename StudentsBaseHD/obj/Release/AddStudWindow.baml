   M S B A M L   `   `   `  ���� I  EStudentsBaseHD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:StudentsBaseHDStudentsBaseHD  "    StudentsBaseHD.AddStudWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:StudentsBaseHD       � Title$  Добавить��$	��200��$	��250�� � 
ResizeMode$ NoResize=�.���  � ColumnDefinitions �� $	��100 ��� .+��� $��Фамилия:��$��Stretch=�$	��Top=�$��0��$��	10,20,0,0q��� $��Факультет:��$��Stretch=�$	��Top=�$��0��$��	10,40,0,0q��� $��Год рождения:��$��Stretch=�$	��Top=�$��0��$��	10,60,0,0q��� -    ��Name$ 
LastNameTB��$��1��$��Stretch=� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$��
10,24,20,0q��� -   $ 	FacultyTB��$��1��$��Stretch=�$
 Wrap=�$�� ��$	��Top=�$��
10,44,20,0q��� -   $ 	BTHYearTB��$��1��$��Stretch=�$
 Wrap=�$�� ��$	��Top=�$��
10,64,20,0q��� $��Отмена��$
��Left=�$��Bottom=�$��75��$��	20,0,0,20q�$��0�� �� IsCancel . ��Z� �� -   $��Добавить��$��Right=�$��Bottom=�$��75��$��	0,0,20,20q�$��1����Z� �� $��Спорт (опц.):��$��Stretch=�$	��Top=�$��0��$��	10,80,0,0q�$��2���� -   $ SportTB��$��1��$��Stretch=�$
 Wrap=�$�� ��$	��Top=�$��
10,84,20,0q�