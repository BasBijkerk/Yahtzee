   M S B A M L   `   `   `  ���� B  >Yahtzee, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:YahtzeeYahtzee      Yahtzee.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Yahtzee       � Title$  Yahtzee��$��650.322��$��315.362��
������� � 
ResizeMode$ NoResize=�.��� -    �Name$ YaGrid��$��0,0,2,0q�.+��� -    ��Name$ DiceS1��$
��Left=�$��32��$��	84,75,0,0q�$	��Top=�$��32��
�����������  �� Color$ Black�� �� Opacity$ 0Q��� -   $ DiceS2��$
��Left=�$��32��$��
120,75,0,0q�$	��Top=�$��32��
����������� $ Black��$ 0Q��� -   $ DiceS3��$
��Left=�$��32��$��
156,75,0,0q�$	��Top=�$��32��
����������� $ Black��$ 0Q��� -   $ DiceS4��$
��Left=�$��32��$��
192,75,0,0q�$	��Top=�$��32��
����������� $ Black��$ 0Q��� -   $ DiceS5��$
��Left=�$��32��$��
228,75,0,0q�$	��Top=�$��32��
����������� $ Black��$ 0Q��� -   $ P4Bord��$
��Left=�$	��474��$��251,127,0,0q�$	��Top=�$��36������ $ Black��$ 0Q����� $ 	AliceBlue��$	 0.1Q��� -   $ P3Bord��$
��Left=�$	��474��$��215,127,0,0q�$	��Top=�$��36������ $ Black��$ 0Q����� $ 	AliceBlue��$	 0.1Q��� -	   $ P2Bord��$
��Left=�$	��474��$��179,127,0,0q�$	��Top=�$��36������ $ Black��$ 0Q����� $ 	AliceBlue��$	 0.1Q��� -
   $ P1Bord��$
��Left=�$	��474��$��143,127,0,0q�$	��Top=�$��36������ $ Black��$ 0Q����� $ 	AliceBlue��$	 0.1Q��� 
���   �$��1q�$
��Left=�$��23��$��143,257,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��179,257,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��215,257,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��251,257,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��287,257,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��323,257,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��359,257,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��395,257,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��143,231,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��179,231,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��215,231,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��251,231,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��287,231,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��323,231,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��359,231,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��395,231,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��143,257,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��179,257,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��215,257,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��251,257,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��287,257,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��323,257,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��359,257,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��395,257,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��143,205,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��179,205,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��215,205,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��251,205,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��287,205,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��323,205,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��359,205,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��395,205,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��143,179,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��179,179,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��215,179,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��251,179,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��287,179,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��323,179,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��359,179,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��395,179,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��143,153,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��179,153,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��215,153,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��251,153,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��287,153,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��323,153,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��359,153,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��395,153,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��143,127,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��179,127,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��215,127,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��251,127,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��287,127,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��323,127,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��359,127,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��395,127,0,0q�$	��Top=�$��36���� 
���   �
�������$��1q�$
��Left=�$��23��$��	9,366,0,0q�$	��Top=�$	��279���� 
���   �$��1q�$
��Left=�$��23��$��143,340,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��179,340,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��215,340,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��251,340,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��287,340,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��323,340,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��359,340,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��395,340,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��143,314,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��179,314,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��215,314,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��251,314,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��287,314,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��323,314,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��359,314,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��395,314,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��143,288,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��179,288,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��215,288,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��251,288,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��287,288,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��323,288,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��359,288,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��395,288,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��	9,340,0,0q�$	��Top=�$	��421���� 
���   �$��1q�$
��Left=�$��23��$��	9,314,0,0q�$	��Top=�$	��421���� 
���   �$��1q�$
��Left=�$��23��$��	9,288,0,0q�$	��Top=�$	��421���� 
���   �$��1q�$
��Left=�$��23��$��	9,257,0,0q�$	��Top=�$	��421���� 
���   �$��1q�$
��Left=�$��23��$��	9,231,0,0q�$	��Top=�$	��421���� 
���   �$��1q�$
��Left=�$��23��$��	9,205,0,0q�$	��Top=�$	��421���� 
���   �$��1q�$
��Left=�$��23��$��	9,179,0,0q�$	��Top=�$	��421���� 
���   �$��1q�$
��Left=�$��23��$��	9,153,0,0q�$	��Top=�$	��421���� 
���   �$��1q�$
��Left=�$��23��$��	9,127,0,0q�$	��Top=�$	��421���� 
���   �$��1q�$
��Left=�$��22��$��143,419,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��179,419,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��215,419,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��251,419,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��287,419,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��323,419,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��359,419,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��395,419,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��143,393,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��179,393,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��215,393,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��251,393,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��287,393,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��323,393,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��359,393,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��395,393,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��	9,419,0,0q�$	��Top=�$	��421���� 
���   �$��1q�$
��Left=�$��22��$��	9,393,0,0q�$	��Top=�$	��421���� 
���   �$��1q�$
��Left=�$��22��$��143,471,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��179,471,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��215,471,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��251,471,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��287,471,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��323,471,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��359,471,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��395,471,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��143,445,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��179,445,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��215,445,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��251,445,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��287,445,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��323,445,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��359,445,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��395,445,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��	9,471,0,0q�$	��Top=�$	��421���� 
���   �$��1q�$
��Left=�$��22��$��	9,445,0,0q�$	��Top=�$	��421���� 
���   �$��1q�$
��Left=�$��22��$��143,497,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��179,497,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��215,497,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��251,497,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��287,497,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��323,497,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��359,497,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��395,497,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��	9,497,0,0q�$	��Top=�$	��421���� 
���   �$��1q�$
��Left=�$��22��$��143,551,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��179,551,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��215,551,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��251,551,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��287,551,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��323,551,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��359,551,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��395,551,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��22��$��	9,551,0,0q�$	��Top=�$	��421���� 
���   �$��1q�$
��Left=�$��23��$��143,578,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��179,578,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��215,578,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��251,578,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��287,578,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��323,578,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��359,578,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��395,578,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��	9,578,0,0q�$	��Top=�$	��421���� 
���   �$��1q�$
��Left=�$��23��$��143,523,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��179,523,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��215,523,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��251,523,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��287,523,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��323,523,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��359,523,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��395,523,0,0q�$	��Top=�$��36���� 
���   �$��1q�$
��Left=�$��23��$��	9,523,0,0q�$	��Top=�$	��421���� -    ��Name$ P1Border��
���   �$��1q�$
��Left=�$��22��$��72,6,0,0q�$	��Top=�$	��100���� -   $ P2Border��
���   �$��1q�$
��Left=�$��22��$��	177,6,0,0q�$	��Top=�$	��100���� -   $ P3Border��
���   �$��1q�$
��Left=�$��22��$��	73,31,0,0q�$	��Top=�$	��100���� -   $ P4Border��
���   �$��1q�$
��Left=�$��22��$��
178,31,0,0q�$	��Top=�$	��100���� -    ��Name$ Total_Points��$��Total Points:��$
��Left=�$��	9,288,0,0q�$	��Top=�$
��Bold"��� -   $ Dice1��$��D0��$
��Left=�$��348,15,-67,0q�$	��Top=�$��34��$
��Bold"��� -   $ Dice2��$��D0��$
��Left=�$��378,15,-99,0q�$	��Top=�$��34��$
��Bold"�$��28���� -   $ Dice3��$��D0��$
��Left=�$��406,15,-125,0q�$	��Top=�$��34��$
��Bold"��� -   $ Dice4��$��D0��$
��Left=�$��436,15,-157,0q�$	��Top=�$��34��$
��Bold"�$��28���� -   $ Dice5��$��D0��$
��Left=�$��464,15,-187,0q�$	��Top=�$��34��$
��Bold"�$��30���� -    ��Name$
 Roll��$
��Roll��$
��Left=�$��9,74,0,0q�$	��Top=�$��42��$��34��$
��Bold"��� -   $ Start��$��Start��$
��Left=�$��9,6,0,0q�$	��Top=�$��42��$��34��$
��Bold"��� $��Ones:��$
��Left=�$��
10,127,0,0q�$	��Top=�$
��Bold"��� $��Twos:��$
��Left=�$��
10,153,0,0q�$	��Top=�$
��Bold"��� $��Threes:��$
��Left=�$��
10,179,0,0q�$	��Top=�$
��Bold"��� $��Fours:��$
��Left=�$��
10,205,0,0q�$	��Top=�$
��Bold"��� $��Fives:��$
��Left=�$��
10,231,0,0q�$	��Top=�$
��Bold"��� $��Sixes:��$
��Left=�$��
10,257,0,0q�$	��Top=�$
��Bold"��� $��Bonus Points [35]:��$
��Left=�$��	9,314,0,0q�$	��Top=�$
��Bold"�	 � ToolTip$-	 'if total points 63 or more in top half.���� $��Total Points Top Half:��$
��Left=�$��	9,340,0,0q�$	��Top=�$
��Bold"��� $��Three of a kind:��$
��Left=�$��
10,393,0,0q�$	��Top=�$
��Bold"��� $��Four of a kind:��$
��Left=�$��
10,419,0,0q�$	��Top=�$
��Bold"��� $��
Full House��$
��Left=�$��
10,445,0,0q�$	��Top=�$
��Bold"��� $��Small Straight:��$
��Left=�$��
10,471,0,0q�$	��Top=�$
��Bold"�$	 Sequence of four.���� $��Large Straight:��$
��Left=�$��
10,497,0,0q�$	��Top=�$
��Bold"�$	 Sequence of five.���� $��Chance:��$
��Left=�$��
10,551,0,0q�$	��Top=�$
��Bold"��� $��Yahtzee:��$
��Left=�$��	9,523,0,0q�$	��Top=�$
��Bold"�$	 Five of a kind.���� $��Total Top and Bottom:��$
��Left=�$��	9,578,0,0q�$	��Top=�$
��Bold"��� -   
 ��Name$
 P1Name��$
��Left=�$��18��$��73,8,0,0q� �� TextWrapping$
 Wrap=�$��Player1��$	��Top=�$��98��
��������� -   $
 P2Name��$
��Left=�$��18��$��	178,8,0,0q�$
 Wrap=�$��Player2��$	��Top=�$��98���� -   $
 P3Name��$
��Left=�$��18��$��	74,33,0,0q�$
 Wrap=�$��Player3��$	��Top=�$��98���� -   $
 P4Name��$
��Left=�$��18��$��
179,33,0,0q�$
 Wrap=�$��Player4��$	��Top=�$��98���� -   $	 P11��$�� ��$
��Left=�$��144,127,0,0q�$	��Top=�$��23��$��34���� -   $	 P21��$�� ��$
��Left=�$��180,127,0,0q�$	��Top=�$��23��$��34���� -   $	 P31��$�� ��$
��Left=�$��216,127,0,0q�$	��Top=�$��23��$��34���� -   $	 P41��$�� ��$
��Left=�$��252,127,0,0q�$	��Top=�$��23��$��34���� -   $	 P12��$�� ��$
��Left=�$��144,153,0,0q�$	��Top=�$��23��$��34���� -    $	 P22��$�� ��$
��Left=�$��180,153,0,0q�$	��Top=�$��23��$��34���� -!   $	 P32��$�� ��$
��Left=�$��216,153,0,0q�$	��Top=�$��23��$��34���� -"   $	 P42��$�� ��$
��Left=�$��252,153,0,0q�$	��Top=�$��23��$��34���� -#   $	 P13��$�� ��$
��Left=�$��144,179,0,0q�$	��Top=�$��23��$��34���� -$   $	 P23��$�� ��$
��Left=�$��180,179,0,0q�$	��Top=�$��23��$��34���� -%   $	 P33��$�� ��$
��Left=�$��216,179,0,0q�$	��Top=�$��23��$��34���� -&   $	 P43��$�� ��$
��Left=�$��252,179,0,0q�$	��Top=�$��23��$��34���� -'   $	 P14��$�� ��$
��Left=�$��144,205,0,0q�$	��Top=�$��23��$��34���� -(   $	 P24��$�� ��$
��Left=�$��180,205,0,0q�$	��Top=�$��23��$��34���� -)   $	 P34��$�� ��$
��Left=�$��216,205,0,0q�$	��Top=�$��23��$��34���� -*   $	 P44��$�� ��$
��Left=�$��252,205,0,0q�$	��Top=�$��23��$��34���� -+   $	 P15��$�� ��$
��Left=�$��144,231,0,0q�$	��Top=�$��23��$��34���� -,   $	 P25��$�� ��$
��Left=�$��180,231,0,0q�$	��Top=�$��23��$��34���� --   $	 P35��$�� ��$
��Left=�$��216,231,0,0q�$	��Top=�$��23��$��34���� -.   $	 P45��$�� ��$
��Left=�$��252,231,0,0q�$	��Top=�$��23��$��34���� -/   $	 P16��$�� ��$
��Left=�$��144,257,0,0q�$	��Top=�$��23��$��34���� -0   $	 P26��$�� ��$
��Left=�$��180,257,0,0q�$	��Top=�$��23��$��34���� -1   $	 P36��$�� ��$
��Left=�$��216,257,0,0q�$	��Top=�$��23��$��34���� -2   $	 P46��$�� ��$
��Left=�$��252,257,0,0q�$	��Top=�$��23��$��34���� -3   $ P1Tot��$��0��$
��Left=�$��144,288,0,0q�$	��Top=�$��23��$��34���� -4   $ P2Tot��$��0��$
��Left=�$��180,288,0,0q�$	��Top=�$��23��$��34���� -5   $ P3Tot��$��0��$
��Left=�$��216,288,0,0q�$	��Top=�$��23��$��34���� -6   $ P4Tot��$��0��$
��Left=�$��252,288,0,0q�$	��Top=�$��23��$��34���� -7   $ P1Bon��$�� ��$
��Left=�$��144,314,0,0q�$	��Top=�$��23��$��34���� -8   $ P2Bon��$�� ��$
��Left=�$��180,314,0,0q�$	��Top=�$��23��$��34���� -9   $ P3Bon��$�� ��$
��Left=�$��216,314,0,0q�$	��Top=�$��23��$��34���� -:   $ P4Bon��$�� ��$
��Left=�$��252,314,0,0q�$	��Top=�$��23��$��34���� -;   $ P1Total��$��0��$
��Left=�$��144,340,0,0q�$	��Top=�$��23��$��34���� -<   $ P2Total��$��0��$
��Left=�$��180,340,0,0q�$	��Top=�$��23��$��34���� -=   $ P3Total��$��0��$
��Left=�$��216,340,0,0q�$	��Top=�$��23��$��34���� ->   $ P4Total��$��0��$
��Left=�$��252,340,0,0q�$	��Top=�$��23��$��34���� -?   $
 P13K��$�� ��$
��Left=�$��144,392,0,0q�$	��Top=�$��23��$��34���� -@   $
 P23K��$�� ��$
��Left=�$��180,392,0,0q�$	��Top=�$��23��$��34���� -A   $
 P33K��$�� ��$
��Left=�$��216,392,0,0q�$	��Top=�$��23��$��34���� -B   $
 P43K��$�� ��$
��Left=�$��252,392,0,0q�$	��Top=�$��23��$��34���� -C   $
 P14K��$�� ��$
��Left=�$��144,418,0,0q�$	��Top=�$��23��$��34���� -D   $
 P24K��$�� ��$
��Left=�$��180,418,0,0q�$	��Top=�$��23��$��34���� -E   $
 P34K��$�� ��$
��Left=�$��216,418,0,0q�$	��Top=�$��23��$��34���� -F   $
 P44K��$�� ��$
��Left=�$��252,418,0,0q�$	��Top=�$��23��$��34���� -G   $
 P1FH��$�� ��$
��Left=�$��144,444,0,0q�$	��Top=�$��23��$��34���� -H   $
 P2FH��$�� ��$
��Left=�$��180,444,0,0q�$	��Top=�$��23��$��34���� -I   $
 P3FH��$�� ��$
��Left=�$��216,444,0,0q�$	��Top=�$��23��$��34���� -J   $
 P4FH��$�� ��$
��Left=�$��252,444,0,0q�$	��Top=�$��23��$��34���� -K   $ P1SST��$�� ��$
��Left=�$��144,470,0,0q�$	��Top=�$��23��$��34���� -L   $ P2SST��$�� ��$
��Left=�$��180,470,0,0q�$	��Top=�$��23��$��34���� -M   $ P3SST��$�� ��$
��Left=�$��216,470,0,0q�$	��Top=�$��23��$��34���� -N   $ P4SST��$�� ��$
��Left=�$��252,470,0,0q�$	��Top=�$��23��$��34���� -O   $ P1LST��$�� ��$
��Left=�$��144,496,0,0q�$	��Top=�$��23��$��34���� -P   $ P2LST��$�� ��$
��Left=�$��180,496,0,0q�$	��Top=�$��23��$��34���� -Q   $ P3LST��$�� ��$
��Left=�$��216,496,0,0q�$	��Top=�$��23��$��34���� -R   $ P4LST��$�� ��$
��Left=�$��252,496,0,0q�$	��Top=�$��23��$��34���� -S   $
 P15K��$�� ��$
��Left=�$��144,523,0,0q�$	��Top=�$��23��$��34���� -T   $
 P25K��$�� ��$
��Left=�$��180,523,0,0q�$	��Top=�$��23��$��34���� -U   $
 P35K��$�� ��$
��Left=�$��216,523,0,0q�$	��Top=�$��23��$��34���� -V   $
 P45K��$�� ��$
��Left=�$��252,523,0,0q�$	��Top=�$��23��$��34���� -W   $ P1Any��$�� ��$
��Left=�$��144,550,0,0q�$	��Top=�$��23��$��34���� -X   $ P2Any��$�� ��$
��Left=�$��180,550,0,0q�$	��Top=�$��23��$��34���� -Y   $ P3Any��$�� ��$
��Left=�$��216,550,0,0q�$	��Top=�$��23��$��34���� -Z   $ P4Any��$�� ��$
��Left=�$��252,550,0,0q�$	��Top=�$��23��$��34���� -[   $ 
P1TotalAll��$��0��$
��Left=�$��144,578,0,0q�$	��Top=�$��23��$��34���� -\   $ 
P2TotalAll��$��0��$
��Left=�$��180,578,0,0q�$	��Top=�$��23��$��34���� -]   $ 
P3TotalAll��$��0��$
��Left=�$��216,578,0,0q�$	��Top=�$��23��$��34���� -^   $ 
P4TotalAll��$��0��$
��Left=�$��252,578,0,0q�$	��Top=�$��23��$��34���� 
���   �
�������$��1q�$
��Left=�$��3��$��	9,176,0,0q�$	��Top=�$	��422�� J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~���  �� ScaleY$ -1Q��� �� T� �� 
���   �
�������$��1q�$
��Left=�$��3��$��	9,150,0,0q�$	��Top=�$	��422��$ 0.5,0.5&�z�V� .~��� $ -1Q��� �� T� �� 
���   �
�������$��1q�$
��Left=�$��3��$��	9,202,0,0q�$	��Top=�$	��422��$ 0.5,0.5&�z�V� .~��� $ -1Q��� �� T� �� 
���   �
�������$��1q�$
��Left=�$��3��$��	9,228,0,0q�$	��Top=�$	��422��$ 0.5,0.5&�z�V� .~��� $ -1Q��� �� T� �� 
���   �
�������$��1q�$
��Left=�$��3��$��	9,254,0,0q�$	��Top=�$	��422��$ 0.5,0.5&�z�V� .~��� $ -1Q��� �� T� �� 
���   �
�������$��1q�$
��Left=�$��8��$��	9,280,0,0q�$	��Top=�$	��422��$ 0.5,0.5&�z�V� .~��� $ -1Q��� �� T� �� 
���   �
�������$��1q�$
��Left=�$��3��$��	9,311,0,0q�$	��Top=�$	��422��$ 0.5,0.5&�z�V� .~��� $ -1Q��� �� T� �� 
���   �
�������$��1q�$
��Left=�$��3��$��	9,337,0,0q�$	��Top=�$	��422��$ 0.5,0.5&�z�V� .~��� $ -1Q��� �� T� �� 
���   �
�������$��1q�$
��Left=�$��3��$��	9,363,0,0q�$	��Top=�$	��422��$ 0.5,0.5&�z�V� .~��� $ -1Q��� �� T� �� 
���   �
�������$��1q�$
��Left=�$��4��$��	9,389,0,0q�$	��Top=�$	��422��$ 0.5,0.5&�z�V� .~��� $ -1Q��� �� T� �� 
���   �
�������$��1q�$
��Left=�$��4��$��	9,415,0,0q�$	��Top=�$	��422��$ 0.5,0.5&�z�V� .~��� $ -1Q��� �� T� �� 
���   �
�������$��1q�$
��Left=�$��4��$��	9,441,0,0q�$	��Top=�$	��422��$ 0.5,0.5&�z�V� .~��� $ -1Q��� �� T� �� 
���   �
�������$��1q�$
��Left=�$��4��$��	9,467,0,0q�$	��Top=�$	��422��$ 0.5,0.5&�z�V� .~��� $ -1Q��� �� T� �� 
���   �
�������$��1q�$
��Left=�$��4��$��	9,493,0,0q�$	��Top=�$	��422��$ 0.5,0.5&�z�V� .~��� $ -1Q��� �� T� �� 
���   �
�������$��1q�$
��Left=�$��4��$��	9,519,0,0q�$	��Top=�$	��422��$ 0.5,0.5&�z�V� .~��� $ -1Q��� �� T� �� 
���   �
�������$��1q�$
��Left=�$��5��$��	9,546,0,0q�$	��Top=�$	��422��$ 0.5,0.5&�z�V� .~��� $ -1Q��� �� T� �� 
���   �
�������$��1q�$
��Left=�$��5��$��	9,573,0,0q�$	��Top=�$	��422��$ 0.5,0.5&�z�V� .~��� $ -1Q��� �� T� �� $
��Left=�$	��513��$��287,108,-44,0q�$	��Top=�$��64��
����������� $ 	AliceBlue��$ 0Q��� 
���   �
�������$��1q�$
��Left=�$��23��$��	9,366,0,0q�$	��Top=�$	��278���� -_    ��Name$ zDice1��$
��Left=�$��34��$��	83,74,0,0q�$	��Top=�$��36��$��	Dice1.png���� -`   $ zDice2��$
��Left=�$��34��$��
119,74,0,0q�$	��Top=�$��36��$��	Dice1.png���� -a   $ zDice3��$
��Left=�$��34��$��
155,74,0,0q�$	��Top=�$��36��$��	Dice1.png���� -b   $ zDice4��$
��Left=�$��34��$��
191,74,0,0q�$	��Top=�$��36��$��	Dice1.png���� -c   $ zDice5��$
��Left=�$��34��$��
227,74,0,0q�$	��Top=�$��36��$��	Dice1.png���� -d   $ tDice1��$
��Left=�$��34��$��464,86,-193,0q�$	��Top=�$��36��$��	Dice1.png���� -e   $ tDice2��$
��Left=�$��34��$��423,86,-152,0q�$	��Top=�$��36��$��	Dice2.png���� -f   $ tDice3��$
��Left=�$��34��$��379,86,-108,0q�$	��Top=�$��36��$��	Dice3.png���� -g   $ tDice4��$
��Left=�$��34��$��338,86,-67,0q�$	��Top=�$��36��$��	Dice4.png���� -h   $ tDice5��$
��Left=�$��34��$��379,125,-108,0q�$	��Top=�$��36��$��	Dice5.png���� -i   $ tDice6��$
��Left=�$��34��$��338,125,-67,0q�$	��Top=�$��36��$��	Dice6.png��