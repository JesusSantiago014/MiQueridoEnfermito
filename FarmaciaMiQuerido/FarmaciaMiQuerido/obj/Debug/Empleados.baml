   M S B A M L   `   `   `  ����L  HFarmaciaMiQuerido, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FarmaciaMiQueridoFarmaciaMiQuerido  5   	   !    FarmaciaMiQuerido.Empleados   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:FarmaciaMiQuerido     5   	     � Title$  	Empleados��5   	   $	��400��6   $	��400��6(   .��5	      � ���	#FF35BBD8 � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��30(�6   $��Center=�6   $��0��6;   .��6H   Mi Querido Enfermito6^   � 5   
   $��1��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $	��150��6   .��6$   Nombre de empleado68   �� 5      -   5         ��Name$ txbNombreEmpleado��5      $	��100��65   6C   5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��150��6   .��6$   sexo6*   �� 5      -   5        $ txbSexo��5      $	��100��6+   69   5      5      � 5   
   $��2��6   .+�5      �� -   5         ��Name$ btnNuevo��5       $��70��6   .��6J   Nuevo6Q   �� 5       -   5        $ 
btnGuardar��5        $��70��6   .��6N   	Guardar6W   �� 5!      -   5        $ 	btnEditar��5!       $��70��6   .��6M   Editar6U   �� 5"      -   5        $ btnCancelar��5"       $��70��6   .��6Q   
Cancelar6[   �� 5#      -   5        $ btnEliminar��5#       $��70��6   .��6P   
Eliminar6Z   5&      &   System.Windows.Controls.DataGrid  5(   
   -   5          Name$ dtgTabla��5(         
IsReadOnly . $��5��67   ���	#FF35BBD86D   53      54      