   M S B A M L   `   `   `  ����D  @Transport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Transport	Transport  5   	   9!clr-namespace:Transport.ViewModelTransport.ViewModel  5   	       Transport.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Transport     5   	   7	viewModel!clr-namespace:Transport.ViewModel     5   	     � Title$  
MainWindow��5	   	   $��887.5��6   $
��3500��6+    � DataContext 5      %   Transport.ViewModel.MyViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5!   
   �� $��0��6   $��0��6$   $��2��61   $��4q�6E   $��Center=�6P   $
��Bold"�6m   Hello World5#      �� 5%   
   $��0��6   $��1��6    $��4q�6-   $��
Latitude :��68   $��Right=�6M   �� 5'   
   -   5        $��1��5'   Q   $��1��6a   $��4q�6n   $
��Left=�6y   $	��200��6�   ��6   �� *
Latitude+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5)   
   $��0��6   $��2��6    $��4q�6-   $��Longitude :��68   $��Right=�6N   �� 5*   
   $��1��6R   $��2��6b   $��4q�6o   $
��Left=�6z   $	��200��6�   ��6   �� *	Longitude+$ PropertyChanged=�6�   �� 5,   
   $��0��6   $��3��6    $��4q�6-   $��
Distance :��68   $��Right=�6M   �� 5-   
   $��1��6Q   $��3��6a   $��4q�6n   $
��Left=�6y   $	��200��6�   ��6   �� *
Distance+$ PropertyChanged=�6�   �� 5/   
   $��0��6   $��4��6    $��4q�6-   $��Result :��68   $��Right=�6K   �� 50   
   $��1��6O   $��4��6_   $��4q�6l   $
��Left=�6w   $	��200��6�   ��6   �� *Result+$ PropertyChanged=�6�   �� 52   
   $��1��6   $��4��6$   $��2��61   $��4q�6E   $��Center=�6j   $
��Bold"�6�   ��6P   �� *
Latitude+6�   �� 53   
   $��1��6   $��5��6$   $��2��61   $��4q�6E   $��Center=�6k   $
��Bold"�6�   ��6P   �� *	Longitude+6�   �� 54   
   $��1��6   $��6��6$   $��2��61   $��4q�6E   $��Center=�6j   $
��Bold"�6�   ��6P   �� *
Distance+6�   �� 55   
   $��1��6   $��6��6$   $��20q�61   $��Center=�6U   $
��Bold"�6r   ��6=   �� *Result+6r   �� 57   
   ��6   �� *
ModifyData+��58      �� 59      Dire bonjour6*   5;      5<      5=      