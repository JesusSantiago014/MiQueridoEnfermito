   M S B A M L   `   `   `  ����L  HFarmaciaMiQuerido, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FarmaciaMiQueridoFarmaciaMiQuerido  5   	       FarmaciaMiQuerido.Venta   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:FarmaciaMiQuerido     5   	     � Title$  Venta��5   	   $	��500��6   $	��500��6$   .��5	      � ���	#FF35BBD8 � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��30(�6   $��Center=�6   $��0��6;   .��6H   Mi Querido Enfermito"venta"6e   � 5   
   $��1��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $	��120��6   .��6$   Nombre del cliente68   �� 5      -   5         ��Name$ cmbNombreCliente��5   '   $	��200��6   6C   5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��120��6   .��6$   
Producto6.   �� 5      -   5        $ cmbProducto��5   '   $	��200��6   6>   5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��120��6   .��6$   cantidad del product.6;   �� 5       -   5         ��Name$ txbDireccion��5       $	��200��60   6>   5!      �� 5#      $ 
Horizontal=�6   .+�5$      �� $	��120��6   .��6$   
Empleado6.   �� 5%      -   5        $ cmbEmpleado��5%   '   $	��200��6   6>   5&      � 5'      $��2��6   .+�5(      �� -   5         ��Name$ btnNuevo��5(   $   $��70��6   .��6N   Nuevo6U   �� 5)      -   5        $ 
btnAgregar��5)   $   $��70��6   .��6R   	Agregar6[   �� 5*      -   5        $ btnCancelar��5*   $   $��70��6   .��6T   
Cancelar6^   �� 5+      -   5        $ 
btnComprar��5+   $   $��70��6   .��6Q   	Comprar6Z   5-      &   System.Windows.Controls.DataGrid  5.      -	   5          Name$ dtgTabla��5.         
IsReadOnly . $��3��6;   53      55      56      