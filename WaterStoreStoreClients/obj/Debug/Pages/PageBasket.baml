   M S B A M L   `   `   `  ����E  AWaterStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WaterStore.PagesWaterStore.Pages  5      !    WaterStore.Pages.PageBasket   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:WaterStore.Pages     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     N� Title$  
PageBasket��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��70 �6   �� 5      $��50 �6   .+�5   
   �  � ColumnDefinitions 5      �� 5      $
��100* �6#   62   �� 5      $	��15* �6#   61   .+�5      �� $��0��5   	   $��10 0 0 0q�5   	   $��Center=�5   	   $��Корзина��5   	    $   MaterialDesignHeadline5TextBlock#��[  5   	   �� 5!      -   5        $��BtnBack2��5!   0   $��1��6   $��5q�6%   .��6X   
Назад6_   5"      �� 5%   
   -   5         ��Name$ ListServices��5%       $��1��6   $��Disabled=�66   $
��Left=�6l   ��5&      �� 5'      .R�5(      �  � Orientation$ 
Horizontal=�6    $��Center=�69   6X   5)      ��5+      �� 5,      .R�5-      #  MaterialDesignThemes.Wpf.Card  $	��350��5.      .��5/      �  50      �� 51   "   $	��250 �52   %   �� 53   "   $��* �54   %   �� 55   "   $
��Auto �56   %   .+�58      �� $	��250��5:      $	��266��5;      $��UniformToFill=�5<      ��59      �� *Img+5<      �� 5=      $��1��5>   !   $��8 10 8 0q�5?   !   .+�5@   "   ��  $  MaterialDesignHeadline6TextBlock#��[ 5B   !   $
��Bold"�6x   ��5A   !   �� *Name+5C   #   �� 5D   "    $  MaterialDesignSubtitle1TextBlock#��[ 5E   %   $
��Wrap=�5F   %   $��Center=�5G   %   ��5H   %   �� *Cost+ �� StringFormat$   Стоимость {0}₽���� 5J   "    �� Orientation$ 
Horizontal=�6-   .+�5K   &   �� #��[ 5L   %   $
��Wrap=�5M   %   $��Center=�5N   %   ��5O   %   �� *
quantity+$$  количество {0}шт.���� 5P   &   $��BtnAddQuantity��68   -   5        $��5q�5P   -   .��6k   +6n   �� 5Q   &   $��BtnDelQuantity��68   -   5        $��5q�5Q   -   .��6k   -6n   5R   #   �� 5S   "   $��BtnDelService��6�   -   5        $��УДАЛИТЬ��5S   )   $��0 0 0 10q�6;      MaterialDesignOutlinedButton#��[ 6M   6�   5V      5W      5X      5Y      5[      �� 5\   
   $��2��6   $ 
Horizontal=�6#   .+�5]      �� -   5        $��FullName��5^        MaterialDesignFilledTextBox#��[ 5_      $��Center=�5`      $	��250��5a      $��	10 0 10 0q�5b      $��Center=�5c       �� 	MaxLength$ 50��5d      /  )MaterialDesignThemes.Wpf.TransitionAssist   DisableTransitions . 	 �� AcceptsReturn	 . 
 �� TextWrapping$

 Wrap=�5g      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ ФИО��5h      {�5i      ��  �� Path$ 	IsChecked� �� ElementName$0 *MaterialDesignFilledTextBoxEnabledComboBox���� 5j      -   5        $��Phone��5k      #��[ 5l      $��Center=�5m      $	��250��5n      $��	10 0 20 0q�5o      	 . $

 Wrap=�5q      $ Телефон��5r      $ 11��5s      $��Center=�5t       . {�5v      �� $ 	IsChecked�$0 *MaterialDesignFilledTextBoxEnabledComboBox���� 5w      -   5        $��Adress��5x      #��[ 5y      $��Center=�5z      $��Center=�5{      $	��250��5|      $	 200��5}       . $��	10 0 20 0q�5      	 . $

 Wrap=�5�      $ 
Адрес��5�      {�5�      �� $ 	IsChecked�$0 *MaterialDesignFilledTextBoxEnabledComboBox��5�      �� 5�   
   $��4��6   $ 
Horizontal=�6#   .+�5�      �� -	   5        $��currentCost��5�      $��Center=�5�      $��	10 0 20 0q�5�      $��
Итого��5�      #��[  5�      �� 5�      -
   5        $��AddOrder��5�   (   $��Заказать��6   6Q   5�      5�      5�      