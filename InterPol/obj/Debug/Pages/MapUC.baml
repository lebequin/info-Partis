   M S B A M L   `   `   `  ����C  ?InterPol, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:InterPol.ConverterInterPol.Converter  5      A =AppLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/$clr-namespace:AppLib;assembly=AppLibAppLib 5      #clr-namespace:InterPolInterPol  5	          InterPol.MapUC   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1conv clr-namespace:InterPol.Converter     5      7AppLib$clr-namespace:AppLib;assembly=AppLib     5      (localclr-namespace:InterPol     5	      -   5          >�Name$
  root��5       � 	Resources 5      &    InterPol.Converter.DateConverter   DateConverter 
 Margin  ResultatMap   InterPol.ResultatMap   ImgRes �� Mode��%�   &	        &	      &	 6       5   
   6   u�5   
   10,10,10,10q�60   �� 5   
   .R�5         6    �� *
ImgCarte+$ OneWay=�5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��65* �6   �� 5      $	��35* �6   .+�5   
   �� .+�5      � #��[ 6    5      �� 5      �� 5       �� 5!      .+�5#      �� $��center=�6=   $ �� IsSynchronizedWithCurrentItem$
 TrueY�5$      ��5#      �� *	LesDates2+ �� SelectedItem 5%      �� *AnneeSelectionnee+ �� ElementName$
 root��$ TwoWay=���5&      �� 5'      .R�5(      �  � Orientation$ 
Horizontal=�6(   .+�5)   "   �� ��6,   �� *Date+	 �� 	Converter#	 [  5*      5+      5-      5.      (� 5/      
 (� Stretch$
 UniformToFill=�6   $��Center=�6.   $��10q�6K   .��50      �� $	��500��6   $	��380��6%   .+�51      �� $)��#../images/cartes/France-regions.jpg��6   $	��380��6I   $	��500��6V   �� 52      $
 TrueY�53      ��52      �� *
LesRegions+ 54      �� *RegionSelectionnee+$
 root��$ TwoWay=���55      �� 56      .R�57   "   �� $	��500��6)   $	��380��65   58      ��5:      �� 5;      .R�5<   "   ��   MapStyle#��[ 6A   ��6,   �� *Nom+6A   5=      ��5?      �� 5@      .�5A   "   ��  �� Property �@��Top �� Value 6?   �� *Top+�� 5B   "    �@��Left 6@   �� *Left+5C      5E      5F      5G      5H      � 5I   
   $��1��6    � RowDefinitions 5J      �� 5K      $	��30* �6    �� 5L      $	��70* �6    .+�5N      �  5O      �� 5P      $��40 �6$   �� 5Q      .+�5S      �� $��Description��6   $��Center=�6/   $��24(�6L   �� 5T      $
��Wrap=�6   $��1��60   $��14(�6=   $����Vous pouvez accéder aux résultats des élections des années précédentes en cliquant sur la date et la région que vous souhaitez.��5U      5V      �� 5X      -   5        $��ResMap��5Y   Y   #��[ 6   $��1��6L   $��Right=�6g   ��5X      �� 5Y   g   5[      5\      5]      