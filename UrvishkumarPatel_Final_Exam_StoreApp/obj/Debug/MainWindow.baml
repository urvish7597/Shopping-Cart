   M S B A M L   `   `   `  ����_  [UrvishkumarPatel_Final_Exam_StoreApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:UrvishkumarPatel_Final_Exam_StoreApp$UrvishkumarPatel_Final_Exam_StoreApp  5   	   5    /UrvishkumarPatel_Final_Exam_StoreApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:UrvishkumarPatel_Final_Exam_StoreApp     5   	     � Title$  Store��5   	   $	��450��6   $	��800��6$   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   .+�5    
   �� -   5        $��forSaleLabel��5       $��For Sale��6$   $��0��68   $��1��6E   &   System.Windows.Controls.DataGrid  5!   
   -   5        $��SaleDataGrid��5!      $��0��6'   $��1��67   $��3��6D   $��5��6X      AutoGenerateColumns .     CanUserDeleteRows .  $
��Bold"�6�      Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$
 Item��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 6Y      
FontWeight$
 Bold"�6d   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 63   �� *Item+
 �� Mode$
 OneWay=�6d     5$      $ Price��6%   $ 1* 6[   $
 Bold"�6f   	 64   �� *Price+$
 OneWay=�6{     5%      $ Serial��6%   $ 2* 6c   $
 Bold"�6n   	 65   �� *SerialNumber+$
 OneWay=�6�   5'      �� 5(   
   -   5        $��shoppingCartLabel��5(      $��Shopping Cart��6)   $��0��6B   $��4��6O     5)   
   -   5        $��shoppingCartDataGrid��5)      $��3��6/   $��1��6?   $��3��6L   $��5��6`    .   .  $
��Bold"�6�    5*        5+      $
 Item��6%   $ 2* 6Y   $
 Bold"�6d   	 63   �� *Item+$
 OneWay=�6d     5,      $ Price��6%   $ 1* 6[   $
 Bold"�6f   	 64   �� *Price+$
 OneWay=�6{     5-      $ Serial��6%   $ 2* 6c   $
 Bold"�6n   	 65   �� *SerialNumber+$
 OneWay=�6�   5/      �� 50   
   -   5        $��placeInCart��50      $��Place In Cart��6$   $��0��6<   $��6��6L   $��3��6Y   6�   �� 51   
   -   5        $��viewItemInfo��51      $��View Item Info��6%   $��0��6>   $��7��6N   $��3��6[   6�   �� 52   
   -   5        $��returnToShelf��52      $��Return To Shelf��6&   $��3��6@   $��6��6P   $��3��6]   6�   �� 54   
   $��Total��6   $��0��6!   $��7��6.   $��2��6>   $��36(�6R   �� 55   
   -   5        $��
totalPrice��55      $��0��6&   $��3��6/   $��6��6<   $��2��6L   $��2��6`   $��72(�6q   �� 56   
   $��$��6   $��3��6   $��2��6*   $��8��6;   $��72(�6K   �� 57   
   -	   5        $��purchaseButton��57      $��Purchase��6'   $��6��6:   $��6��6G   $��3��6W   $��Right=�6k   $��
0,0,-0.4,0q�6�   $	��264��6�   6�   58      59      