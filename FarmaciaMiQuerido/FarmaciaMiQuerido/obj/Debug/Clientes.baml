   M S B A M L   `   `   `  ����L  HFarmaciaMiQuerido, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FarmaciaMiQueridoFarmaciaMiQuerido  5   	        FarmaciaMiQuerido.Clientes   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:FarmaciaMiQuerido     5   	     � Title$  Clientes��5   	   $	��500��6   $	��500��6'   .��5	      � .+�5
   
   � ���	#FF35BBD8 � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $��* �6    .+�5      �� $��30(�6   $��Center=�6"   $��0��6?   .��6L   Mi Querido Enfermito"cliente"6k   � 5      $��1��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $	��120��6   .��6(   Nombre del cliente6<   �� 5      -   5         ��Name$ 	txbNombre��5      $	��200��61   6?   5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��120��6   .��6(   
Apellido62   �� 5      -   5        $ txbApellido��5      $	��200��63   6A   5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��120��6   .��6(   	Direccion63   �� 5!      -   5        $ txbDireccion��5!      $	��200��64   6B   5"      �� 5$      $ 
Horizontal=�6   .+�5%      �� $	��120��6   .��6(   RFC6-   �� 5'      -   5        $ txbRFC��5'      $	��200��6.   6<   5(      �� 5*      $ 
Horizontal=�6   .+�5+      �� $	��120��6   .��6(   
Telefono62   �� 5-      -   5        $ txbTelefono��5-      $	��200��63   6A   5.      �� 50      $ 
Horizontal=�6   .+�51      �� $	��120��6   .��6(   correo electronico6<   �� 53      -   5        $ 	txbCorreo��53      $	��200��61   6?   54      � 55      $��2��6   .+�56      �� -   5         ��Name$ btnNuevo��56   (   $��70��6   .��6R   Nuevo6Y   �� 57      -   5        $ 
btnGuardar��57   (   $��70��6   .��6U   	Guardar6^   �� 58      -	   5        $ 	btnEditar��58   (   $��70��6   .��6S   Editar6[   �� 59      -
   5        $ btnCancelar��59   (   $��70��6   .��6W   
Cancelar6a   �� 5:      -   5        $ btnEliminar��5:   (   $��70��6   .��6W   
Eliminar6a   5<      &   System.Windows.Controls.DataGrid  5=      -   5          Name$ 	dtgTabla1��5=         
IsReadOnly . $��3��6@   5B      5C      5D      5E      