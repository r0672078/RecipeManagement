   M S B A M L   `   `   `  ����K  GRecipeManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:RecipeManagement.ViewsRecipeManagement.Views  5   	   -    'RecipeManagement.Views.ManageRecipeView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:RecipeManagement.Views     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  6R     � Title$  ManageRecipeView��5   	   $	��450��6"   $	��800��6/   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5    
   �� )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Search��5!      $��Center=�5"      $��5q�5#      $
��Bold"�5$      $
��20px(�5%      ��5       �� *UpdateOrAdd+5%      �� 5'   
   $��Name:��6   $��1��5(      $ Search��5)      $��5q�5*      $
��Bold"�5+      $
��18px(�5,      $��Right=�5-      �� 5/   
   $��Chef:��6   $��2��50      $ Search��51      $��5q�52      $
��Bold"�53      $
��18px(�54      $��Right=�55      �� 57   
   $��Preparation Time:��6   $��3��58      $ Search��59      $��5q�5:      $
��Bold"�5;      $
��18px(�5<      $��Right=�5=      �� 5?   
   $��Cooking Time:��6   $��4��5@      $ Search��5A      $��5q�5B      $
��Bold"�5C      $
��18px(�5D      $��Right=�5E      �� 5G   
   $��	Servings:��6   $��5��5H      $ Search��5I      $��5q�5J      $
��Bold"�5K      $
��18px(�5L      $��Right=�5M      �� 5O   
   $��Origin:��6   $��6��5P      $ Search��5Q      $��5q�5R      $
��Bold"�5S      $
��18px(�5T      $��Right=�5U      �� 5W   
   $��Instructions:��6   $��7��5X      $ Search��5Y      $��5q�5Z      $
��Bold"�5[      $
��18px(�5\      $��Right=�5]      �� 5_   
   $��1��6   $��1��5`      $��5q�5a      $��18(�5b      4  .System.Windows.Automation.AutomationProperties   AutomationId$
 Name��5d      ��5c      �� *Recipe.Name+5d      �� 5f   
   $��1��6   $��2��5g      $��5q�5h      $��18(�5i       �� SelectedValuePath$ Id��5l      $ �� IsSynchronizedWithCurrentItem$
 TrueY�5m      $
 Chef��5n      ��5j      �� *	Recipes+	 �� SelectedValue	 5k      �� *Chef.ChefId+5n      �� 5p   
   $��1��6   $��3��5q      $��5q�5r      $��18(�5s      $ PreparationTime��5u      ��5t      �� *Recipe.PreparationTime+5u      �� 5w   
   $��1��6   $��4��5x      $��5q�5y      $��18(�5z      $ CookingTime��5|      ��5{      �� *Recipe.CookingTime+5|      �� 5~   
   $��1��6   $��5��5      $��5q�5�      $��18(�5�      $ Servings��5�      ��5�      �� *Recipe.Servings+5�      �� 5�   
   $��1��6   $��6��5�      $��5q�5�      $��18(�5�      $ Origin��5�      ��5�      �� *Recipe.Origin+5�      �� 5�   
   $��1��6   $��7��5�      $��5q�5�      $��18(�5�      $ Instructions��5�      ��5�      �� *Recipe.Instructions+5�      �� 5�   
   $��2��6   $��9��5�      
 � ToolTip$4
 .Resource name: MaterialDesignRaisedLightButton��5�      $��15q�5�      $ Confirm��5�      ��5�      �� *UpdateOrAddButton+��5�      �� ��6%   �� *UpdateOrAddButton+5�      �� 5�   
   $��2��6   $��10��5�      
���  ����5�      �� *ErrorMessage+5�      5�      5�      