   M S B A M L   `   `   `  ����G  CCashRegister, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:CashRegisterCashRegister  5          CashRegister.RefreshBD   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:CashRegister     5        N� Title$  	RefreshBD��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��251* �6   6/   �� 5      $
��549* �6   6.    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� -   5         ��Name$ TextBox1��5      $��1��6$   $��0��64   $��100,20,100,20q�6A   �� 5   
   -   5        $ TextBox2��5      $��1��6$   $��1��64   $��100,20,100,20q�6A   �� 5   
   -   5        $ TextBox3��5      $��1��6$   $��2��64   $��100,20,100,20q�6A   �� 5   
   -   5        $ TextBox4��5      $��1��6$   $��3��64   $��100,20,100,20q�6A   �� 5   
   -   5        $ TextBox5��5      $��1��6$   $��4��64   $��100,20,100,20q�6A   �� 5   
   $��0��6   $��ProductName��6   $��Center=�64   $��Right=�6V   $��20(�6y   6�   �� 5   
   $��1��6   $��Price��6   $��Center=�6-   $��Right=�6O   $��20(�6r   6�   �� 5    
   $��2��6   $��Quantity��6   $��Center=�60   $��Right=�6R   $��20(�6u   6�   �� 5!   
   $��3��6   $��ProductType��6   $��Center=�63   $��Right=�6U   $��20(�6x   6�   �� 5"   
   $��4��6   $��ProductSubType��6   $��Center=�66   $��Right=�6X   $��20(�6{   6�   �� 5#   
   -   5        $��1��5#      $��5��6!   $
��Left=�6.   $��50��6I   $	��100��6X   $��10q�6g   $��Go��6s   6�   5$      5%      