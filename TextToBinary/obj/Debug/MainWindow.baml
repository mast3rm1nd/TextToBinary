   M S B A M L   `   `   `  ����  TextToBinary    TextToBinary.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          �Name$  ___No_Name_��5   	    � Title$ ASCI (De)coder��5   	   $��332.09��6    $��527.985��60    � WindowStartupLocation$ CenterScreen=�6@    � 
ResizeMode$ CanMinimize=�6e   .��5      � .+�5   
   �� -   5         ��Name$ TextBox_Plaintext��5      $
��Left=�6-   $	��111��6H   $��	77,10,0,0q�6U    �� TextWrapping$
 Wrap=�6h   $	��Top=�6|   $	��430��6�   $��	abcABC123��6�   �� 5   
   -   5        $ TextBox_Binary��5      $
��Left=�6*   $	��111��6E   $��
77,165,0,0q�6R   $
 Wrap=�6f   $	��Top=�6z   $	��430��6�   $7��11110100110010111100111110100010000001010000111101��6�   �� 5   
   $��
Plaintext:��6   $
��Left=�6%   $��10,6,0,0q�6@   $	��Top=�6R   $��61��6j   �� 5	   
   $��
In binary:��6   $
��Left=�6%   $��
10,161,0,0q�6@   $	��Top=�6T   $��62��6l   �� 5
   
   -   5         ��Name$ Button_ToBinary��5
      $��	To Binary��6*   $
��Left=�6>   $��141,126,0,0q�6Y   $	��Top=�6n   $��90��6�   $��34��6�   6�   �� 5   
   -   5        $ Button_ToPlain��5      $��To Plain��6)   $
��Left=�6<   $��335,126,0,0q�6W   $	��Top=�6l   $��90��6�   $��34��6�   6�   5      5      