   M S B A M L   `   `   `  ����  PasswordManager&     PasswordManager.Views.MenuWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	    !  MaterialDesignLightBackground#���   5   	   $��Segoe UI)�5	   	   $��18(�5
   	     � Title$!  Список паролей��5   	   $	��450��5   	   $	��800��5   	   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��8* �6   .+�5   
   o� .@�5      m� $��	_ФАЙЛ��6   .@�5      m� -   5         m�Name$ MenuItemMyData��5      $��Мои данные��5      5      m� 5       -   5        $ MenuItemServices��5!      $��Сервисы��5       5!      m� 5"      -   5        $ MenuItemSignOut��5$      $��
Выйти��5"      5$      5%      5'      � 5)   
   $��1��6   $��10q�5*       � ColumnDefinitions 5,      �� 5.      $��4* �6#   �� 50      $��2* �6#   �� 52      $��2* �6#   �� 54      $��2* �6#   .+�58      �� -   5         ! MaterialDesignOutlinedTextBox#���  58      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Поиск��59      $	��350��5:      $��Center=�5;      $��0��5<      5=      �� 5?      -   5         ��Name$ 	ButtonAdd��5?      $��Добавить��5@      $��1��5A        MaterialDesignFlatButton#���  5B      $��10q�5C      5D      �� 5F      -   5        $ 
ButtonEdit��5F      $ ��Редактировать��5G      $��2��5H      #���  5I      $��10q�5J      ${�False��5K      5L      �� 5N      -   5        $ ButtonMyData��5N      $��Мои данные��5O      $��3��5P      #���  5Q      $��10q�5R      5S      5U      &   System.Windows.Controls.DataGrid  5W   
   -   5          Name$ DataGridPasswords��5W      $��2��5X      $��10q�5Y         
IsReadOnly$
 True��5Z         AutoGenerateColumns$ False��5[      $��Center=�5\      	   Columns	 5_      0  *System.Windows.Controls.DataGridTextColumn  5a      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Сервис��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5b   %   �� *Service.Name+  5d      $
 Ссылка��6%    5e   %   �� *Service.Url+  5g      $%
 Имя пользователя��6%    5h   %   �� *
UserName+4  .System.Windows.Controls.DataGridTemplateColumn  5j      $
 Пароль��6)      CellTemplate 5l      �� 5n      .R�5p      ��  �� Orientation$ 
Horizontal=�6)   .+�5r   "   �� ��6,   �� *
Password+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�5u      5w      5{        5}      $
 Примечание��6%    5~   %   �� *Note+5�      5�      5�      