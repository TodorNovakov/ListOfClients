   M S B A M L   `   `   `  ����F  BClientsList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ClientsListClientsList  5   	       ClientsList.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   )vmsclr-namespace:ClientsList     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��950��6)    � DataContext 5      "   ClientsList.ClientsViewModel  5   
   6!   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��75 �6    � ColumnDefinitions 5   
   �� 5      $	��350��6   $��2* �6/   �� 5      $
��Auto �6   �� 5      $	��250��6    $��* �6/   .+�5   
   �� $��1��6   $��2��6'   $
��Left=�68   $��Stretch=�6S    �� ResizeBehavior$ PreviousAndNext=�5      $��2��68   
���   �6B   &   System.Windows.Controls.DataGrid  5   
   -   5        $��TableOfClients��5      $��0��6*   $��0��67   
�������   AutoGenerateColumns .     RowBackground
 �������5      �� *	Clients+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   MinWidth$	 120Q�6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 Auto 64   
   Header$

 Name��6A      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6O   �� *Name+6h     5!      $	 100Q�6%   $
	 Auto 64   $

 City��6A    .  6O   �� *City+6h     5"      $	 250Q�6%   $	 * 64   $

 Note��6>    .  6L   �� *Note+6e     5#      $	 145Q�6%   $	 * 64   $
 ContractDate��6>    .  6T   �� *Date+6m   5&      �� 5(   
   $��2��6   $��2��6(   
���/��� 5)      ��  �� ElementName$ TableOfClients�� �� Path$ SelectedItem�.+�5+      �� $��22(�6.   $��Italic$�6<   $��Medium"�6O   ��6   �� *Name+6O   �� 5,      $��22(�6.   $��Italic$�6=   $��Medium"�6P   ��6   �� *City+6P   �� 5-      $��15(�6.   ��6   �� *Note+6.   �� 5.      $��15(�6.   ��6   �� *Date+6.   �� 5/      $	��200��50      $	��200��51      $��Center=�52      ��5/      �� *	ImagePath+52      53      ]� 5:   
   -   5        $��PanelButtons��5:      $��2��6)   .+�5;      �� $��25��6   $	��Top=�6$   ��69   �� *AddNew+.��6T   Add6Y   �� 5<      $��25��6   $	��Top=�6$   .��69   Update6A   �� 5=      $��25��6   $��Bottom=�6$   ��5>      �� *DeleteCommand+��5?      �� $ TableOfClients��$ SelectedItem�.��6_   Delete6g   5@      5B      5C      