   M S B A M L   `   `   `  ????B  >FIO_Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WpfAppAuthInterfaceWpfAppAuthInterface  5   	       WpfAppAuthInterface.FIO   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WpfAppAuthInterface     5   	     ? Title$  ФИО??5   	   $	??450??6   $	??500??6"   $??24(?6.   
?????d? ? WindowStartupLocation$ CenterScreen=?6X   .??5	      ? .+?5
   
   ?  ? RowDefinitions 5      ?? 5      $
??0.5* ?6    ?? 5      ?? 5      $
??0.5* ?6    .+?5      ? $??0??6    ? ColumnDefinitions 5      ?? 5      ?? 5      ?? 5      .+?5      ? $??0??6   .+?5      ?? $??Фамилия??6    $??30,10,30,60q?6/   ?? 5      -   5         ??Name$ 
SurnameBox??5      $??10,50,10,20q?62   
????ح?6G   5      ? 5      $??1??6   .+?5      ?? $??Имя??6    $??55,10,55,60q?6+   ?? 5      -   5        $ NameBox??5      $??10,50,10,20q?6/   
????ح?6D   5      ? 5      $??2??6   .+?5      ?? $??Отчество??6    $??30,10,30,60q?60   ?? 5       -   5        $ PatronymicBox??5       $??10,50,10,20q?65   
????ح?6J   5!      5"      ? 5#      $??1??6   .+?5$      ?? -   5         ??Name$ FIO_List??5$      $??120,20,120,20q?6,   
????ح?6C   5%      ? 5&      $??2??6   .+?5'      ?? -   5         ??Name$ 
ShowButton??5'      $??Отобразить??6-   $??150,30,150,30q?6B   
????İ?6u   5(      5)      5*      5+      