   M S B A M L   `   `   `  ����L  HFarmaciaMiQuerido, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FarmaciaMiQueridoFarmaciaMiQuerido  5   	   !    FarmaciaMiQuerido.Productos   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:FarmaciaMiQuerido     5   	     � Title$  	Productos��5   	   $	��500��6   $	��500��6(   .��5	      � ���	#FF35BBD8 � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��30(�6   $��Center=�6   $��0��6;   .��6H   !Mi Querido Enfermito"productos"6i   � 5   
   $��1��6   ���	#FF35BBD8.+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $	��120��6   .��6$   
Producto6/   �� 5      -   5         ��Name$ 	txbNombre��5      $	��200��6*   68   5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��120��6   .��6$   	categoria6/   �� 5      -   5        $ txbCategoria��5      $	��200��60   6>   5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��120��6   .��6$   Descripcion61   �� 5       -   5        $ txbDescripcion��5       $	��200��62   6@   5!      �� 5#      $ 
Horizontal=�6   .+�5$      �� $	��120��6   .��6$   Precio de venta65   �� 5&      -   5        $ 	txbPventa��5&      $	��200��6-   6;   5'      �� 5)      $ 
Horizontal=�6   .+�5*      �� $	��120��6   .��6$   Precio de compra66   �� 5,      -   5        $ 
txbPcompra��5,      $	��200��6.   6<   5-      �� 5/      $ 
Horizontal=�6   .+�50      �� $	��120��6   .��6$   Producto existente68   �� 52      -   5        $ 	txbActual��52      $	��200��6-   6;   53      54      � 56   
   $��2��6   .+�57      �� -   5         ��Name$ btnNuevo��57       $��70��6   .��6J   Nuevo6Q   �� 58      -   5        $ 
btnGuardar��58       $��70��6   .��6M   	Guardar6V   �� 59      -	   5        $ 	btnEditar��59       $��70��6   .��6L   Editar6T   �� 5:      -
   5        $ btnCancelar��5:       $��70��6   .��6O   
Cancelar6Y   �� 5;      -   5        $ btnEliminar��5;       $��70��6   .��6O   
Eliminar6Y   5=      &   System.Windows.Controls.DataGrid  5>   
   -   5          Name$ dtgTabla��5>         
IsReadOnly . $��3��67   ���	#FF35BBD86D   5@      5A      