   M S B A M L   `   `   `  ����<  81, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:_1_1  5   	       _1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:_1     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��301* �6   �� 5      $	��18* �6   .+�5   
   �� -   5         ��Name$ listBox��5      $
��Left=�6#   $	��226��6>   $	��Top=�6K   $	��100��6c   $��	10,10,0,0q�6o   .@�5      �� $	��int��6   �� 5      $��Double��6   �� 5      $��Float��6   �� 5      $
��Byte��6   �� 5      $��Decimal��6   �� 5      $
��long��6   �� 5      $��sbyte��6   �� 5      $��short��6   �� 5      $��ulong��6   �� 5      $
��uint��6   �� 5      $��ushort��6   5      �� 5   
   -   5         ��Name$ labelMinValue��5      $��MinValue��6'   $
��Left=�6:   $	��Top=�6U   $��
140,10,0,0q�6m   $��60��6�   $��26��6�   �� 5   
   -   5         ��Name$ textBoxMinValue��5      $
��Left=�6+   $��23��6F    �� TextWrapping$
 Wrap=�6R   $�� ��6f   $	��Top=�6n   $	��200��6�   $��
140,36,0,0q�6�   �� 5   
   -   5        $ 
labelValue��5      $��Value��6$   $
��Left=�64   $��
140,80,0,0q�6O   $	��Top=�6c   �� 5   
   -   5        $ textBoxValue��5      $
��Left=�6(   $��23��6C   $
 Wrap=�6O   $�� ��6c   $	��Top=�6k   $	��200��6�   $��140,106,0,0q�6�   �� 5!   
   -   5        $ labelMaxValue��5!      $��MaxValue��6'   $
��Left=�6:   $��140,150,0,0q�6U   $	��Top=�6j   �� 5"   
   -   5        $ textBoxMaxValue��5"      $
��Left=�6+   $��23��6F   $��140,176,0,0q�6R   $
 Wrap=�6g   $�� ��6{   $	��Top=�6�   $	��200��6�   5#      5$      