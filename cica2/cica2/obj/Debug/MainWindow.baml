   M S B A M L   `   `   `  ????@  <cica2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:cica2cica2  5   	       cica2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:cica2     5   	   -   5          ?Name$  Window1??5   	    ? Title$ Robbanó Cicák??5   	   $
??1080??6   $
??1920??6-    ? WindowStyle$
 None=?6Q    ? WindowState$ 	Maximized=?6d    ? 
ResizeMode$ NoResize=?6|    ? WindowStartupLocation$ CenterScreen=?6?    ? Icon$ /cicaikon.png??6?   ??5	      ?? 5
   
    ?? EndPoint$ 0.5,1&?6    ?? 
StartPoint$ 0.5,0&?6/   .??5      ? 	 ? Color$	 Black??6   
 ? Offset$
 0Q?6)   ? 5      $	 	#FFE67149??6   ? 5      $	 	#FFE66549??6   ? 5      $	 	#FFE64F49??6   $
 0.726Q?6-   5      .??5      ? .+?5   
   ?? -   5         ??Name$ 	current1L??5      $??Utolsó felvett kártya??6#   $
??Left=?6C   $??
76,338,0,0q?6^   $	??Top=?6r   $??60??6?   $	??340??6?   $??32(?6?   $??Center=?6?   $??Center=?6?   $??MV Boli)?6?   ?? 5   
   -   5         ??Name$ down1B??5      $??Lerak??6!   $
??Left=?61   $??
77,407,0,0q?6L   $	??Top=?6`   $??60??6x   $	??340??6?   $??30(?6?   $??MV Boli)?6?    J? RenderTransformOrigin$ 0.166,0.398&?6?   ?? 5   
   -   5        $
 up1B??5      $??Felhúz??6   $
??Left=?60   $??
77,496,0,0q?6K   $	??Top=?6_   $	??100??6w   $	??340??6?   $??30(?6?   $??MV Boli)?6?   ?? 5   
   -   5         ??Name$ 	player1Li??5      $??839,114,0,0q?6P   $
??Left=?6e   $	??300??6?   $??Center=?6?   $??MV Boli)?6?   $	??730??6?   $	??Top=?6?   $??20(?6?   6?   ?? 5   
   -   5        $ 	player2Li??5      $??1184,114,0,0q?6P   $
??Left=?6f   $	??300??6?   $??Center=?6?   $??MV Boli)?6?   $	??730??6?   $	??Top=?6?   $??20(?6?   6?   ?? 5   
   -   5        $ player1L??5      $
??Left=?6"   $??
966,68,0,0q?6=   $	??Top=?6Q   $??46??6i   $??46??6u   $??Kristen ITC)?6?   $??30(?6?   $??1??6?   $??Center=?6?   ?? 5   
   -   5        $ deckL??5      $
??Left=?6   $??1133,37,0,0q?6:   $	??Top=?6O   $??46??6g   $??60??6s   $??Kristen ITC)?6~   $??30(?6?   $??2??6?   $??Center=?6?   ?? 5   
   -	   5        $ player2L??5      $
??Left=?6"   $??1312,68,0,0q?6=   $	??Top=?6R   $??46??6j   $??44??6v   $??Kristen ITC)?6?   $??30(?6?   $??3??6?   $??Center=?6?   ?? 5   
   -
   5        $ textL??5      $
??Info??6   $
??Left=?6.   $??
77,775,0,0q?6I   $	??Top=?6]   $??64??6u   $	??691??6?   $??Arial)?6?   $??20(?6?   
??????????	#FFDC0808$??Center=?6?   $??Center=?6?   6=  ?? 5   
   -   5        $ titleL??5      $??Robbanó Cicák??6    $
??Left=?68   $??
116,45,0,0q?6S   $	??Top=?6g   $	??183??6   $	??626??6?   $??Center=?6?   $??Center=?6?   $??Kristen ITC)?6?   $??80(?6?   ???	#FF0900006  ?? 5   
   -   5        $ meowL??5      $
??Meow??6   $
??Left=?6.   $??146,177,0,0q?6I   $	??Top=?6^   $??Kristen ITC)?6v   $??30(?6?   ???	#FF0900006?   ?? 5   
   -   5        $ selectedItem1L??5      $??Kiválasztott kártya??6(   $
??Left=?6F   $??
77,278,0,0q?6a   $	??Top=?6u   $??60??6?   $	??340??6?   $??32(?6?   $??Center=?6?   $??Center=?6?   $??MV Boli)?6?   ?? 5   
   -   5        $
 up2B??5      $??Felhúz??6   $
??Left=?60   $??428,496,0,0q?6K   $	??Top=?6`   $	??100??6x   $	??340??6?   $??30(?6?   $??MV Boli)?6?   ?? 5   
   -   5        $
 p1TL??5      $??Pakliban a kártya:??6   $
??Left=?6;   $??
879,36,0,0q?6V   $	??Top=?6j   $??MV Boli)?6?   $??17(?6?   $??36??6?   $??Center=?6?   $	??220??6?   $??Center=?6?   ?? 5    
   $??Pakliban a kártya:??6   $
??Left=?6-   $??
1073,0,0,0q?6H   $	??Top=?6\   $??Center=?6t   $??MV Boli)?6?   $??17(?6?   $??46??6?   $??Center=?6?   $	??160??6?   ?? 5!   
   -   5        $
 p2TL??5!      $??Pakliban a kártya:??6   $
??Left=?6;   $??1224,36,0,0q?6V   $	??Top=?6k   $??MV Boli)?6?   $??17(?6?   $??36??6?   $??Center=?6?   $	??220??6?   $??Center=?6?   ?? 5"   
   -   5        $ down2B??5"      $??Lerak??6!   $
??Left=?61   $??428,407,0,0q?6L   $	??Top=?6a   $??60??6y   $	??340??6?   $??30(?6?   $??MV Boli)?6?   $ 0.166,0.398&?6?   ?? 5#   
   -   5        $ 	current2L??5#      $??Utolsó felvett kártya??6#   $
??Left=?6C   $??423,338,0,0q?6^   $	??Top=?6s   $??60??6?   $	??340??6?   $??32(?6?   $??Center=?6?   $??Center=?6?   $??MV Boli)?6?   ?? 5$   
   -   5        $ selectedItem2L??5$      $??Kiválasztott kártya??6(   $
??Left=?6F   $??428,278,0,0q?6a   $	??Top=?6v   $??60??6?   $	??340??6?   $??32(?6?   $??Center=?6?   $??Center=?6?   $??MV Boli)?6?   ?? 5%   
   -   5         ??Name$	 p1T??5%      $
??Left=?6   $??
76,640,0,0q?6:    ?? TextWrapping$
 Wrap=?6N   $??Player 1??6b   $	??Top=?6r   $	??320??6?   $??90??6?   ???	#FFF06464$??Center=?6?   $??Center=?6?   $??MV Boli)?6?   $??30(?6  6@  ?? 5&   
   -   5        $	 p2T??5&      $
??Left=?6   $??448,640,0,0q?6:   $
 Wrap=?6O   $??Player 2??6c   $	??Top=?6s   $	??320??6?   $??90??6?   ???	#FFF06464$??Center=?6?   $??Center=?6?   $??MV Boli)?6   $??30(?6  6A  ?? 5'   
   -   5        $ xL??5'      $??X??6   $
??Left=?6(   $??
1483,6,0,0q?6C   $	??Top=?6W   $??Comic Sans MS)?6o   $??30(?6?   6?   ?? 5(   
   -   5        $ namesL??5(      $??Adjatok nevet megatoknak!??6    $
??Left=?6D   $??	8,507,0,0q?6_   $	??Top=?6r   $??89??6?   $	??830??6?   $??Center=?6?   $??Center=?6?   $??Kristen ITC)?6?   $??56(?6  ???	#FF0900006  ?? 5)   
   -   5        $ startL??5)      $??Kezdjen a fiatalabb! :)??6    $
??Left=?6B   $??	8,349,0,0q?6]   $	??Top=?6p   $??88??6?   $	??830??6?   $??Center=?6?   $??Center=?6?   $??Kristen ITC)?6?   $??60(?6?   ???	#FF0900006  5+      5,      