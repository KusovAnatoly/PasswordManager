   M S B A M L   `   `   `  ����J  FPasswordManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PasswordManager.ViewsPasswordManager.Views  5   	   (    "PasswordManager.Views.MyDataWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:PasswordManager.Views     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	    !  MaterialDesignLightBackground#���   5   	     MaterialDesignBody#���  5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	   $��Segoe UI)�5   	    � Title$" Редактирование��5   	   $	��450��5   	   $	��600��5   	   .��5      �� $��Center=�6   $��Center=�5      $	��250��5      .+�5   
   �� -   5         ��Name$ TextBoxEmail��5      $��	10,5,10,5q�5       ! MaterialDesignOutlinedTextBox#���  5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$! Адрес эл. почты��5      5      �� 5   
   -   5        $ TextBoxLogin��5      $��
10,10,10,5q�5      #���  5       $ 
Логин��5!      /  )MaterialDesignThemes.Wpf.ValidationAssist   UsePopup$
 True��5"         HasError$
 True��5#         Suppress$ False��5$      5%      G� 5&   
   -   5         G�Name$ PassBoxOldPassword��5&      $��	10,5,10,5q�5'      	 � ToolTip$�	 �Пароль должен содержать Минимум восемь символов, минимум одна заглавная буква, одна строчная буква, одна цифра и один специальный символ.��5(       % !MaterialDesignOutlinedPasswordBox#���  5)      $ Старый пароль��5*      5+      �� 5-   
   $_��YЕсли хотите сменить пароль, введите новый пароль��6   $��10q�5.      G� 50   
   -   5        $ PassBoxPassword��50      $��	10,5,10,5q�51      $�	 �Пароль должен содержать Минимум восемь символов, минимум одна заглавная буква, одна строчная буква, одна цифра и один специальный символ.��52      #���  53      $ Новый пароль��54      55      G� 57   
   -   5        $ PassBoxRepeatPassword��57      $��	10,5,10,5q�58      #���  59      $% Повторите пароль��5:      5;      �� 5>   
   -   5        $ TextBoxFirstName��5>      $��	10,5,10,5q�5?      #���  5@      $ Имя��5A      5B      �� 5D   
   -   5        $ TextBoxLastName��5D      $��	10,5,10,5q�5E      #���  5F      $ Фамилия��5G      5H      (  "System.Windows.Controls.DatePicker  5J   
   -   5        
  Name$
 DatePickerBirthDate��5J      $��	10,5,10,5q�5K       $  MaterialDesignOutlinedDatePicker#���  5L      $ Дата рождения��5M       � Language$ ru-RU�5O      �� 5Q   
   -	   5         ��Name$ TextBlockValidation��5Q      $y�	Collapsed=�5R      $
��Wrap=�5S      $	��300��5T      �� 5V   
   -
   5         ��Name$ 
ButtonSave��5V      $��10q�5W      $��Сохранить��5X        MaterialDesignRaisedButton#���  5Y      5Z      �� 5\   
   -   5        $ ButtonCancel��5\      $��Отменить��5]        MaterialDesignFlatButton#���  5^      5_      5a      5c      