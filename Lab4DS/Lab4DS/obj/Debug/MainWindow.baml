   M S B A M L   `   `   `  ����A  =Lab4DS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab4DSLab4DS  5   	       Lab4DS.MainWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Lab4DS     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      .+�5   
   �  � ColumnDefinitions 5      �� 5      $��4* �6#   �� 5      .+�5      �� -   5         ��Name$ 	SearchTxt��5      �� 5      -   5        $��1��5      $��
Поиск��6%   65   5      � 5   
   $��1��6    5      �� 5      $��4* �6#   �� 5      .+�5      �� -   5         ��Name$ 
AuthorsCbx��5   0    �� DisplayMemberPath$
 Name��6   6D   �� 5      -   5        $��Очистить��5      $��1��6(   68   5      &   System.Windows.Controls.DataGrid  5    
   -   5          Name$ BooksDrg��5       $��2��6%   5!      5"      