   M S B A M L   `   `   `  ����C  ?AIS_Lab4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AIS_Lab4AIS_Lab4  5   	       AIS_Lab4.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:AIS_Lab4     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��625��6)    � 	Resources 5	       �� 
TargetType �� Property �� Value��%F  '��       '�� H     '�� �     �� 5
   
   " ��6   .�5      ��  � ��$ 14(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 	20 8 20 8q�6'   �� 5       � ��$	 100��6&   �� 5       � ��$ 30��6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ CarsGrid��5   /      AutoGenerateColumns .  ��6A   �� *Cars+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Модель��6?   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 100 6O   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Model+6O     5      $	 Цвет��6?   $	
 100 6M    6%   �� *Color+6M     5      $	 Год выпуска��6>   $	
 170 6S    6%   �� *Year+6S     5       $	 Владелец��6?   $	
 134 6Q    6%   �� *Owner+6Q   4  .System.Windows.Controls.DataGridCheckBoxColumn  5!      $!	 Ручная коробка��6B   $	
 100 6Z    6)   �� *Type+6Z   5$      �� 5%   
   $��Center=�6   $��1��63    �� Orientation$ 
Horizontal=�6@   .+�5&      �� -   5         ��Name$ downloadButton��5&      $��Загрузить��6-   6A   �� 5'      -   5        $ updateButton��5'      $��Сохранить��6+   6?   �� 5(      -   5        $ deleteButton��5(      $��Удалить��6+   6=   5)      5+      5,      