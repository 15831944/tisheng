   M S B A M L   `   `   `  ����I  ERepositoryOfXA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:RepositoryOfXA.ViewModelsRepositoryOfXA.ViewModels  5   
   ;"clr-namespace:RepositoryOfXA.ViewsRepositoryOfXA.Views  5   	   *    $RepositoryOfXA.Views.AddOrEditWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =	viewModel'clr-namespace:RepositoryOfXA.ViewModels     5   
   4local"clr-namespace:RepositoryOfXA.Views     5   	     � Title$  AddOrEditWindow��5	   	   $	��280��6!   $	��300��6.    � WindowStartupLocation$ CenterScreen=�6:    � Topmost .  � 
ResizeMode$ NoResize=�6n    � DataContext 5
      2   ,RepositoryOfXA.ViewModels.AddOrEditViewModel  5      6%   .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $	��100 �6   6-   �� 5      $��* �6   6+   .+�5   
   �� $��0��6   $��0��6   $��用户姓名:��6-   $��Right=�6=   $��Center=�6Y   $��0,0,10,0q�6t   6�   �� 5   
   $��1��6   $��0��6   $��用户账号:��6-   $��Right=�6=   $��Center=�6Y   $��0,0,10,0q�6t   6�   �� 5   
   $��2��6   $��0��6   $��是否启用:��6-   $��Right=�6=   $��Center=�6Y   $��0,0,10,0q�6t   6�   �� 5   
   $��3��6   $��0��6   $��用户密码:��6-   $��Right=�6=   $��Center=�6Y   $��0,0,10,0q�6t   6�   �� 5   
   $��0��6   $��1��6   $	��160��6/   $��25��6;   ��6G   �� * CurrentOperatorEntity.Ope_Name+ �� Mode$ TwoWay=�6�   �� 5   
   $��1��6   $��1��6   $	��160��6/   $��25��6;   ��6G   �� *#!CurrentOperatorEntity.Ope_Account+$ TwoWay=�6�   �� 5    
    �� Orientation$ 
Horizontal=�6   $��2��6.   $��1��6;   $��20,0,0,0q�6K   .+�5!      	� 	 	� 	GroupName$		 sex��6   $��启用��6,   $��Center=�69   
 d� 	IsChecked
 6T   �� *	IsChecked+$ TwoWay=�6�   	� 5"      $		 sex��6   $��	未启用��6-   $��Center=�6;   $��20,0,0,0q�6W   6k   5#      �� 5%   
   $��3��6   $��1��6   $	��160��6/   $��25��6;   ��6G   �� *$"CurrentOperatorEntity.Ope_PassWord+$ TwoWay=�6�   �� 5'   
   $��3��6   $��0��6!   $��2��61   
���   �$��1��6R   $��Bottom=�6]   6z   �� 5)   
   $��保存��6   $��80��6   $��30��6)   $��4��65   $��1��6B   ��6R   �� *SaveCommand+6t   5+      5,      