   M S B A M L   `   `   `  ����E  AWaterStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WaterStore.PagesWaterStore.Pages  5          WaterStore.Pages.Users   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:WaterStore.Pages     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	         MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5       N� Title$ Users��5      .��5      �  � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $��50 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��100* �6   6.   �� 5      $��5* �6   6,   .+�5   
   �� -   5        $��Search��5    !   $��0��5"   !   $��1��5#   !   $��8 0 0 0q�5$   !   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Поиск��5%   !   .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�5&   !   $��0q�5'   !   $	��200��5(   !   $��Center=�5)   !   �� 5+   
   $��0��5,   	   $��10 0 0 0q�5-   	   $��Center=�5.   	   $��Каталог��5/   	    $  MaterialDesignHeadline5TextBlock#��[ 50   	   �� 51   
   -   5        	 ��Name$	 ListServices��51   5   $��2��6   $��3��6    $��Disabled=�6K   $
��Left=�6�   $��3��6�   ��52      �� 53      .R�54      � 
 � Orientation$
 
Horizontal=�6    $��Center=�69   6X   55      ��57      �� 58      .R�59      #  MaterialDesignThemes.Wpf.Card  $	��300��5:      .��5;      �  5<      �� 5=   "   $	��350 �5>   %   �� 5?   "   $��* �5@   %   �� 5A   "   $
��Auto �5B   %   .+�5E      �� $	��250��5G      $	��200��5H      $
��Fill=�5J      ��5F      �� *Img+5J      �� 5K      $��1��5L   !   $��8 10 8 0q�5M   !   .+�5N   "   ��  $  MaterialDesignHeadline6TextBlock#��[ 5P   !   $
��Bold"�6x   ��5O   !   �� *Name+5Q   #   �� 5R   "    $  MaterialDesignSubtitle1TextBlock#��[ 5S   %   $
��Wrap=�5T   %   $��Center=�5U   %   ��5V   %   �� *Cost+ �� StringFormat$   Стоимость {0}₽���� 5W   "   #��[ 5X   %   $
��Wrap=�5Y   %   $��Center=�5Z   %   ��5[   %   �� *
Duration+$. ( Длительность {0} минут���� 5\   "   $��0 0 0 10q�6.    �� Orientation$ 
Horizontal=�6@   $��Center=�6Y   .+�5]   &   �� $��BtnOrder��6�   -   5        $��ЗАКАЗАТЬ��5]   -   $��0 0 10 0q�6@      MaterialDesignOutlinedButton#��[ 6R   6�   �� 5^   &   $��	AddBasket��5_   -   -   5        $��В КОРЗИНУ��5^   -   5_   >   5`   #   5a      5b      5c      5d      5f      �� 5g   
   $��0��6   $
��Left=�6#   $ Vertical=�6>   $��1��6U   
�������.+�5h      � $��Right=�6   $��10q�6/   .+�5i      %  MaterialDesignThemes.Wpf.Badged  -   5        $��CountService��5i   (      Badge$ 1��6<   .��5j      �� -   5        $��	BtnBascet��5m   !   $��Center=�5j      $
��Left=�5k   !   $��0 0 0 0q�5l   !     MaterialDesignToolButton#���  5o   !   .��5p      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Basket=�5q   !   $��14��5r   !   5s      5t      5u      � 5v       5w      �� 5x      $
��Auto �5y   &   �� 5z      $��* �5{   %   �� 5|      $
��Auto �5}   &   .+�5      �� $��Center=�5�   !   #���  5�   !   .��5�        $ Search=�5�   !    J� Opacity$	 .56Q�5�   "    J� RenderTransformOrigin$ 0.812,-1.125&�60   $��14��6U   5�      5�      5�      5�      5�      