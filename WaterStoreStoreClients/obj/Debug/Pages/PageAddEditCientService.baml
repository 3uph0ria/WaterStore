   M S B A M L   `   `   `  ����@  <Renty, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Renty.PagesRenty.Pages  5      )    #Renty.Pages.PageAddEditCientService   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Renty.Pages     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  PageAddEditCientService��5
      .��5      � $��15q�6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Center=�6   $��0��60   $F��@Добавление/редактирование продажи��5   	    $   MaterialDesignHeadline5TextBlock#��[  5      �� 5   
   -   5         ��Name$ CBoxServices��5       )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Товар��5      $	��600��5      $��0 0 20 0q�5      $��Center=�5      $��1��5       �� DisplayMemberPath$
 Name��5!       �� SelectedItem 5      �� *Services.Id+5!      �� 5$   
   -   5        $ CBoxClients��5+      $ Клиент��5%      $	��600��5&      $��0 0 20 0q�5'      $��Center=�5(      $��2��5)      $ Fullname��5,       5*      �� *
Clients.Id+5,      �� 5/   
   -   5        $	��Img��51      $��3��50      $	��600��53        MaterialDesignFilledTextBox#��[ 54      $��Center=�55       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�57      $ Дата��58      $��0 0 20 0q�59      ��52      �� *Date+{�5:      ��  �� Path$ 	IsChecked�	 �� ElementName$0	 *MaterialDesignFilledTextBoxEnabledComboBox���� 5<   
   $��Center=�6   $��5��60   $��Center=�6>   
 �� Orientation$
 
Horizontal=�6[   .+�5=      �� -   5        $��BtnAddservice��5=      $��Сохранить��6F   6]   5>      5?      5@      