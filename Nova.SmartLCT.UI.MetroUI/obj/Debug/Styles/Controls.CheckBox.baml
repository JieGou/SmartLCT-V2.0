   M S B A M L   `   `   `  ����S  ONova.SmartLCT.UI.MetroUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Nova.SmartLCT.UI.MetroUI.Controls!Nova.SmartLCT.UI.MetroUI.Controls  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   MetroCheckBox  �� 
TargetType �� Property  LabelTextBrush �� Value  ContentFontSize  ContentFontFamily  CheckBoxBrush  
WhiteBrush6    0Nova.SmartLCT.UI.MetroUI.Controls.ControlsHelper  HighlightBrush  CheckBoxMouseOverBrush �� 
TargetType'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard g� Duration �� 
TargetName	 �� TargetProperty	
 W� To � ColumnDefinitions ��Name �Name  TransparentWhiteBrush ��Name F�Name J� Opacity �� Stretch � UseLayoutRounding ��Name 	 
GrayBrush3 
 SemiTransparentWhiteBrush ��Name �� Triggers P� Property P� Value �� 
TargetName �� RelativeSource �� Path �� ScaleX:   4Nova.SmartLCT.UI.MetroUI.Controls.ToggleButtonHelper�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      <Controls/clr-namespace:Nova.SmartLCT.UI.MetroUI.Controls  5      1System&clr-namespace:System;assembly=mscorlib  5      %�  &	        �� 5      "  ��6"   .�5	   
   ��  � ��# �  6'   �� 5
   
    � ��# �  6%   �� 5   
    � ��# �  6'   �� 5   
    � ��$
 Left=�67   �� 5   
    � ��$ Center=�65   �� 5   
    � ��$ 6,0,0,0q�6$   �� 5   
    � ��$ 1q�6,   �� 5   
    � ��# �  6(   �� 5   
    � ��# �  6'   �� 5   
    �@  FocusBorderBrush# �  6E   �� 5   
    �@  MouseOverBorderBrush# �  6I   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      �  5        5      CommonStates��. 5   "     
Normal��6.     5   "   Disabled��. 5   &   �� .��5   *   W� $ 0D�6:   $ contentPresenter��5   :   $	 (UIElement.Opacity)�5   :   $	
 .55X�5    :   W� 5!   *   $ 0D�6:   $ disabled��5"   :   $	 (UIElement.Opacity)�5#   :   $
 1X�5$   :   5%   '   5&   #   5'        5(      CheckStates��. 5)   "     Checked��. 5*   &   �� .��5+   *   W� $ 0D�6:   $ checkBox��5,   :   $	 (UIElement.Opacity)�5-   :   $
 1X�5.   :   5/   '   50   #     51   "   	Unchecked��6.     52   "   Indeterminate��. 53   &   �� .��54   *   W� $ 0D�6:   $ IndeterminateCheck��55   :   $	 (UIElement.Opacity)�56   :   $
 1X�57   :   58   '   59   #   5:       5<      �� 5=      $ LeftCol��6/   $��18 �6@   �� 5>      $ RightCol��6/   $��* �6A   .+�5@      � $ PART_CHECKBOX��6   .+�5A      �� $��-6, 0q�6(   #���  67   �� 5B      $ normal��6%   $��18��5C   %   $��18��5D   %   #��z��5E   %   #��z��5F   %   #��z��5G   %   F� 5H      $ checkBox��6#   $��12��5I   #   $��10��5J   #   �����   �m�@�G��   �m�@�G�   ��Ց@   �<1{@   ��Ց@   �<1{@   ��Ց@   �<1{@   ��̑@   ��{@   ��̑@   ��{@   ��̑@   ��{@���C   ��({@���C   ��({@S���C   ��({@   ��Ց@�Y   ��Ց@�Y�   ��Ց@�YnD\enD\e�nD\e��]D    ��z@��]D    ��z@S��]D    ��z@   �m�@�G�   �m�@�G�	#���  5L   #   $ 0Q�5M   #   $
 Fill=�5N   #    .  5O   #   �� 5P      $ IndeterminateCheck��6(   $��8��5Q   (   $��3��5R   (   #��� 	 5S   (   $ 0Q�5T   (   �� 5U      $ disabled��6%   $��18��5V   %   $��18��5W   %   #��� 
 5X   %   #��z��5Y   %   $ 0Q�5Z   %   5[      �� 5\      $ contentPresenter��6+   $��1��5]   +   #��z��5^   +   #��z��5_   +   #��z��5`   +   #��z��5a   +   #��z��5b   +   ��. 5c   +   5d       5e      P� 5f       �@J�IsMouseOver . . �5g      �� $ normal��6%    6P   ��  �� *TemplatedParent+$4 .(Controls:ControlsHelper.MouseOverBorderBrush)� � ��5h      P� 5i       � �� . . �5j      �� $ normal��6%   # �  6P    � ��5k      P� 5l       �@J�	IsFocused . . �5m      �� $ normal��6%    6P   ��  �� *TemplatedParent+$0 *(Controls:ControlsHelper.FocusBorderBrush)� � ��5n      P� 5o       � ��$ RightToLeft=�6;   . �5p      �� $ checkBox��6%    �@�LayoutTransform 5q   "   �� 5r   &   $ -1Q�65   5t      5u      P� 5v       �@ ContentDirection$ RightToLeft=�6Z   . �5w      ��  � ��$ 0,0,6,0q�68   �� 5x      $ LeftCol��6%    � ��$ * �6K   �� 5y      $ RightCol��6%    � ��$ 18 �6L   �� 5z      $ PART_CHECKBOX��6%    � ��$ 1��6W   �� 5{      $ contentPresenter��6%    � ��$ 0��6Z   5|      5~      5�      5�      5�      