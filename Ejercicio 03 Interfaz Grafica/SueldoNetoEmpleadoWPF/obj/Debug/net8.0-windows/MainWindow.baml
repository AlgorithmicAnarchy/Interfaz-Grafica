   M S B A M L   `   `   `  ����P  LSueldoNetoEmpleadoWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SueldoNetoEmpleadoWPFSueldoNetoEmpleadoWPF  5   	   &     SueldoNetoEmpleadoWPF.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:SueldoNetoEmpleadoWPF     5   	   -   5          � Title$  	LoginView��5   	   $	��550��6   $	��800��6(    � WindowStyle$
 none=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency$
 True��5   	   .��5      ��  �� CornerRadius$ 12��6   ._�5   
   �� $ 10��6   $��1q�5       J� Opacity$
 0.95Q�5      ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5      � 	 � Color$	 #B0C4D6��6#   
 � Offset$
 0Q�63   � 5      $	 #4DD0E1��6#   $

 0.75Q�63   � 5      $	 #F0F4F8��6#   $
 1Q�63   5      ��5       �� 5!      $	 0,1&�6&   $	 1,0&�67   .��5"      � $	 #003B5C��6#   $
 0Q�63   � 5#      $	 #007B99��6#   $

 0.75Q�63   5$      ._�5(      �  � ColumnDefinitions 5)      �� 5*      �� 5+      �� 5,      �� 5-      $
��30px �6'    � RowDefinitions 51      �� 52      $
��30px �6$   �� 53      �� 54      �� 55      .+�58      �� $+��%Bienvenido de nuevo a ToDaKi's Center��6   
�������$��1��5:      $��1��5;      $��24(�5<      $
��Wrap=�5=       �� TextAlignment$ Center=�5>      $��Medium"�5?      �� 5A      $��1��6   $��2��5B      .+�5D      �� $#��Ingresa cuanto ganas por hora��6    
�������$
��14px(�5F   !   $��0,0,0,10q�5G   !   �� 5I      -   5         ��Name$ txtGananciasH��5I      $��13(�5J      $��Medium"�5K      $��
Montserrat)�5L      
�������
������  �� 
CaretBrush
 �����
�������$��0,0,0,1q�5Q      $��28��5R      $��30,0,0,0q�5S      �� 5W      $&�� Ingresa cuantas horas trabajaste��6    
�������$
��14px(�5Y   !   $��	0,40,0,10q�5Z   !   �� 5\      -   5        $ txtPagoH��5\      $��13(�5]      $��Medium"�5^      $��
Montserrat)�5_      
�������
������ 
 �����
�������$��0,0,0,1q�5d      $��28��5e      $��30,0,0,0q�5f      5h      �� 5k      $!��El sueldo neto del empleado��6   
�������$��0,50,0,0q�5m      $ Center=�5n      $��14(�5o      $��1��5p      $��3��5q      �� 5t      -   5         ��Name$ netoyatusabe��5u      $�� ��5t      
�������$��24(�5w       $��1��5x      $��3��5y      $ Center=�5z      $��center=�5{      �� 5~      -   5        $��0q�5      $��ENVIAR��5�      
�������$��12(�5�      $��
Montserrat)�5�       � Cursor$
 Hand��5�      $��2��5�      $��2��5�      ��5�      �� 5�       �� 
TargetType" ��6    .�5�      ��  �� Property � �� �� Value �#28AEED6;    �� Triggers 5�      P� 5�   "    P� Property �@J�IsMouseOver P� Value$
 True��6A   . �5�   &   ��  � �� �#462AD86C   5�   #   5�      ��5�      �� 5�       �� 
TargetType" ��6*   .R�5�      �� $��92��6%   $��30��60   $ 12��5�   %   #��z��5�   %   ._�5�   "   �� $��Center=�63   $��Center=�5�   %   5�      5�      5�      5�      5�      5�      5�      