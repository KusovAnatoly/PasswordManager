   M S B A M L   `   `   `  ����J  FPasswordManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PasswordManager.ViewsPasswordManager.Views  5   	   (    "PasswordManager.Views.SignUpWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   /local#clr-namespace:PasswordManager.Views  5   	    !  MaterialDesignLightBackground#���   5	   	     MaterialDesignBody#���  5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	   $��Segoe UI)�5   	    � Title$ Регистрация��5   	   $	��450��5   	   $	��600��5   	   .��5      �� $��Center=�6   $��Center=�5      $	��250��5      .+�5   
   �� -   5         ��Name$ TextBoxEmail��5      $��	10,5,10,5q�5       ! MaterialDesignOutlinedTextBox#���  5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$! Адрес эл. почты��5      5      �� 5   
   -   5        $ TextBoxLogin��5      $��
10,10,10,5q�5       #���  5!      $ 
Логин��5"      /  )MaterialDesignThemes.Wpf.ValidationAssist   UsePopup$
 True��5#         HasError$
 True��5$         Suppress$ False��5%      5&      G� 5(   
   -   5         G�Name$ PassBoxPassword��5(      $��	10,5,10,5q�5)      	 � ToolTip$�	 �Пароль должен содержать Минимум восемь символов, минимум одна заглавная буква, одна строчная буква, одна цифра и один специальный символ.��5*       % !MaterialDesignOutlinedPasswordBox#���  5+      $ Пароль��5,      5.      G� 50   
   -   5        $ PassBoxRepeatPassword��50      $��	10,5,10,5q�51      #���  52      $% Повторите пароль��53      54      �� 56   
   -   5        $ TextBoxFirstName��56      $��	10,5,10,5q�57      #���  58      $ Имя��59      5:      �� 5<   
   -   5        $ TextBoxLastName��5<      $��	10,5,10,5q�5=      #���  5>      $ Фамилия��5?      5@      (  "System.Windows.Controls.DatePicker  5B   
   -   5        
  Name$
 DatePickerBirthDate��5B      $��	10,5,10,5q�5C       $  MaterialDesignOutlinedDatePicker#���  5D      $ Дата рождения��5E       � Language$ ru-RU�5G      �� 5I   
   -   5         ��Name$ TextBlockValidation��5I      $y�	Collapsed=�5J      $
��Wrap=�5K      $	��300��5L      �� 5N   
   -	   5         ��Name$ CheckBoxAgree��5N      $P��JЯ принимаю условия пользования сервисом��5O      $
��Left=�5P      5R      �� 5T   
   -
   5         ��Name$ ButtonSignUp��5T      $��10q�5U      $*��$Зарегистрироваться��5V        MaterialDesignRaisedButton#���  5W      5X      �� 5Z   
   -   5        $ ButtonCancel��5Z      $��Отменить��5[        MaterialDesignFlatButton#���  5\      5]      5_      5a      