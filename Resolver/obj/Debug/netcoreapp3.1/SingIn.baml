   M S B A M L   `   `   `  ����C  ?Resolver, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ResolverResolver  5   	       Resolver.SingIn   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Resolver     5   	     � Title$  SingIn��5   	   $	��500��5	   	   $	��500��5
   	    � 
ResizeMode$ NoResize=�5   	   .��5      � .+�5   
   �� -   5         ��Name$ label_Singin��5      $��Авторизация��5      $��Center=�5      $	��110��5      $��0,10,0,0q�5      $	��Top=�5      $	��420��5      $��67(�5      �� 5   
   -   5         ��Name$ label_Login��5      $��
Логин��5      $
��Left=�5      $��
40,141,0,0q�5      $
��Wrap=�5      $	��Top=�5      $��18(�5      �� 5   
   -   5         ��Name$ input_Login��5      $��Center=�5      $��	0,176,0,0q�5       �� TextWrapping$
 Wrap=�5      $	��Top=�5       $	��420��5!      $��1,1,1,1q�5"      
���   �$��36��5$      �� 5%   
   -   5        $ label_Password��5%      $��Пароль��5&      $
��Left=�5'      $��
40,217,0,0q�5(      $
��Wrap=�5)      $	��Top=�5*      $��18(�5+      G� 5,   
   -   5         G�Name$ input_Password��5,      $��Center=�5-      $��	0,248,0,0q�5.      $	��Top=�5/      $	��420��50      $��1,1,1,1q�51      
���   �$��36��53      �� 54   
   -   5         ��Name$ button_Authorization��54      $"��Авторизоваться��55      $
��Left=�56      $��
40,317,0,0q�57      $	��Top=�58       J� RenderTransformOrigin$ 0.535,0.539&�59      $	��131��5:      $��29��5;      $��16(�5<      5=      �� 5>   
   -   5        $ button_Clear��5>      $��Очистить��5?      $
��Left=�5@      $��259,317,0,0q�5A      $	��Top=�5B      $	��110��5C      $��29��6   $��18(�5D      5E      �� 5F   
   -   5        $ button_Cancel��5F      $��Отмена��5G      $
��Left=�5H      $��374,317,0,0q�5I      $	��Top=�5J      $��86��5K      $��29��5L      $��18(�5M      5N      �� 5O   
   -	   5        $ label_RestorePassword��5O      $
��Left=�5P      $��348,382,0,0q�5Q      $
��Wrap=�5R      $	��Top=�5S      $��16(�5T      �� 5U      -
   5        	 ��Name$	 hyper_RestorePassword��5U      .�5V   <   Забыли пароль6K   5W      �� 5X   
   -   5        $ label_SingUp��5X      $
��Left=�5Y      $��
40,382,0,0q�5Z      $
��Wrap=�5[      $	��Top=�5\      $��16(�5]      �� 5^      -   5        $	 hyper_SignUp��5^      .�5_   4   Регистрация6A   5`      5a      5b      