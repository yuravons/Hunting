   M S B A M L   `   `   `  ����B  >Hunting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:HuntingHunting  5   	       Hunting.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Hunting     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5
      � ��5   
   �� 5       �� ImageSource$ images/1.jpg��6   66    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   &   System.Windows.Controls.DataGrid  $��2��6   $��1��6#      AutoGenerateColumns . $
��Left=�5   (   $��45��6C   $	��Top=�6O   $	��175��5   6   $��	68,15,0,0q�6B   ��6   ��  �� Path$ Tasks�6B   �� 5   
   
�������$��2��6,   $��0��6<   $��	53,0,10,0q�6I   .+�5      �� .��6   Login:6   �� 5      
�������61   �� 5      .��6   
Password6   �� 5      
�������61   �� 5       $��10q�6   $	��100��6"   $��Sign In��6.   5!      �� 5"   
   
�������$��0��6,   $��3��69   $��
0,10,0,130q�6J   .+�5#      �� $��30��6   $��10q�6"   $��New Game��6/   6D   �� 5$      $��30��6   $��10q�6"   $��	Load Game��6/   6E   �� 5%      $��30��6   $��10q�6"   $��	Save Game��6/   6E   �� 5&      $��30��6   $��10q�6"   $
��Exit��6/   6@   5'      �� 5(   
   $��Results:��6   $��2��6#   $
��Left=�63   $��
68,129,0,0q�6N   $	��Top=�6b   $��2��6z   $��92��6�   5)      5+      