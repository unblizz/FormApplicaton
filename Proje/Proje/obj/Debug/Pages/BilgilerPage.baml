   M S B A M L   `   `   `  ����@  <Proje, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ProjeProje  5          Proje.Pages.BilgilerPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      A =Wpf.Ui, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null/ui&http://schemas.lepo.co/wpfui/2022/xaml  5   	   localclr-namespace:Proje  5        N� Title$  BilgilerPage��5
      .��5      � $��Stretch=�6   $��Stretch=�6'   .+�5   
   �� $��60,90,20,20q�6   .+�5      � $
��Left=�6   .+�5        Wpf.Ui.Controls.TextBox  -   5          Name$ txtIsim��5         PlaceholderText$ Ad��6.   $	��200��6C   $	��300��6R   $y�Visible=�6a     5      -   5        $ 
txtSoyisim��5      $��10,0,0,0q�61   $ Soyad��6C    �� CharacterCasing$ Upper=�6[   $	��200��6s   $	��300��6�   5        Wpf.Ui.Controls.TextBlock  5      $��Cinsiyet��6   
�������$
��Left=�6>   $��0,10,0,0q�6Y   � 5      $��0,5,0,0q�6   $
��Left=�6)   .+�5      	� $	��Bay��6   $��60��6,   $��60��6:   	� 5      $��Bayan��6   $��70��6.   $��70��6<   $��10,0,0,0q�6G   5      � 5      $��0,10,0,0q�6   $
��Left=�6*   .+�5        -   5        $��txtDate��5      $��Center=�6/   
�������$
��Left=�6]    �� Padding$ 0,0,20,0q�6x   ��5      �� 5       �� ElementName$ CalendarDatePicker��6"    �� Path$
 Date�6D    �� StringFormat$" Doğum Tarihi {0:dd/MM/yyyy}��6P   5      (  "Wpf.Ui.Controls.CalendarDatePicker  5      -   5          Name$ CalendarDatePicker��5   =   $��
Tarih Seç��6)   	   IsTodayHighlighted	 . $��Center=�6s   $��40,0,0,0q�6�   5      � 5      $��0,10,0,0q�6   $
��Left=�6*   .+�5         $��Medeni Durum��6   
�������63   "  Wpf.Ui.Controls.ToggleSwitch  5!      
   
OffContent$
 Bekar��6"      	OnContent$
 Evli��65   $��50,0,0,0q�6F   5"      � 5#      $��0,10,0,0q�6   $
��Left=�6*   .+�5$        $��Center=�6   $��Varsa Çocuk Sayısı��6:   
�������6T     Wpf.Ui.Controls.NumberBox  5%      $	��100��6   $��34,0,0,0q�6/   5&      � 5'      $��0,10,0,0q�6   $
��Left=�6*   .+�5(        $��Center=�6   $��Adres��6:   
�������6G   !  Wpf.Ui.Controls.RichTextBox  5)      $	��200��6!   $	��200��60   $��60��6?   $��60��6N   $��	100,0,0,0q�6]   5*      � 5+      $��0,10,0,0q�6   $
��Left=�6*   .+�5,        $��Center=�6   $��Cep Telefonu��6:   
�������6N     5-      $	��200��6   $��60,0,0,0q�6,   5.      � 5/      $��0,10,0,0q�6   $
��Left=�6*   .+�50        $��Center=�6   $!��Mesleği ve İş Tecrübesi��6:   
�������6Y     51      $	��200��6!   $	��200��60   $��60��6?   $��60��6N   $��10,0,0,0q�6]   52      53        Wpf.Ui.Controls.Button  54   
   -   5        $��btnNext��54   $   $��İleri��6   $��Bottom=�6I   $��Right=�6d   $��30q�6�   55      56      