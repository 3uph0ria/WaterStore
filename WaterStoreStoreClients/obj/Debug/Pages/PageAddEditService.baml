   M S B A M L   `   `   `  ����@  <Renty, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Renty.PagesRenty.Pages  5      $    Renty.Pages.PageAddEditService   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Renty.Pages     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     N� Title$  PageAddEditService��5
      .��5      � $��15q�6    � RowDefinitions 5      �� 5   
   $��* �6   �� 5   
   $��* �6   �� 5   
   $��* �6   �� 5   
   $��* �6   �� 5   
   $��* �6   �� 5   
   $��* �6   .+�5      �� $��Center=�6   $��0��6,   $D��>Добавление/редактирование товара��5   	    $   MaterialDesignHeadline5TextBlock#��[  5      �� 5   
   -   5        $
��Name��5      $��1��5      $	��600��5        MaterialDesignFilledTextBox#��[ 5      $��Center=�5       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5       )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Наименование��5!      $��0 0 20 0q�5"      ��5      �� *Name+{�5#      ��  �� Path$ 	IsChecked� �� ElementName$0 *MaterialDesignFilledTextBoxEnabledComboBox���� 5&   
   -   5        $
��Cost��5(      $��2��5'      $	��600��5*      #��[ 5+      $��Center=�5,       . $
 Wrap=�5.      $ Стоимость��5/      $��0 0 20 0q�50      ��5)      �� *Cost+{�51      �� $ 	IsChecked�$0 *MaterialDesignFilledTextBoxEnabledComboBox���� 53   
   -   5         ��Name$ CBoxServices��5:      $ Категория��54      $	��600��55      $��0 0 20 0q�56      $��Center=�57      $��3��58       �� DisplayMemberPath$
 Name��5;      	 �� SelectedItem	 59      �� *Categoris.Id+5;      �� 5>   
   -   5        $	��Img��5@      $��4��5?      $	��600��5B      #��[ 5C      $��Center=�5D       . $
 Wrap=�5F      $ Картинка��5G      $��0 0 20 0q�5H      ��5A      �� *Img+{�5I      �� $ 	IsChecked�$0 *MaterialDesignFilledTextBoxEnabledComboBox���� 5K   
   $��Center=�6   $��5��60   $��Center=�6>   
 �� Orientation$
 
Horizontal=�6[   .+�5L   
   �� -   5        $��BtnAddservice��5L      $��Добавить��6B   6X   5M      5N      5O      