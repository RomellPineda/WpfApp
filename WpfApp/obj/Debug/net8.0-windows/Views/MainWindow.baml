   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp  5          WpfApp.MainWindow   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:WpfApp     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  
MainWindow��5      $	��800��5	      $	��450��5
      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ FilterTextBoxx��5      $��0��5      $
��20pxq�5       �� TextWrapping$
 Wrap=�5      " �� VerticalScrollBarVisibility$
 Auto=�5      $ �� HorizontalScrollBarVisibility$
 Auto=�5       �� AcceptsReturn$
 True��5       �� MinLines$ 1��5       �� MaxLines$ 1��5      $
��16px(�5      $	��5pxq�5      $	��1pxq�5      
���   �5       �� 5"   
   -   5        	 ��Name$	 MainListView��5#      $��1��5%      $
��20pxq�5&      ��5$      �� *Jobs+
 �� View
 5'      �� 5(      .P�5)      �� $��	Job Title��6L    �� DisplayMemberBinding 6%   �� *Title+6L   �� 5*      $��Location��6O    6%   �� *
Location+6O   �� 5+      $��Description��6R    6%   �� *Description+6R   �� 5,      $��Date Posted��6Q    6%   �� *
DatePosted+6Q   �� 5-       �� CellTemplate 5.      �� 5/      .R�50   "   �� -   5        $��Apply��51   %   52   %   54      56      57      59      5:      5;      