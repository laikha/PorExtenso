•
gE:\Projetos\GitHub\CSharp\PorExtenso\src\ExtensoSuporte\obj\Debug\net6.0\ExtensoSuporte.AssemblyInfo.cs
[ 
assembly 	
:	 

System 
. 

Reflection 
. $
AssemblyCompanyAttribute 5
(5 6
$str6 F
)F G
]G H
[ 
assembly 	
:	 

System 
. 

Reflection 
. *
AssemblyConfigurationAttribute ;
(; <
$str< C
)C D
]D E
[ 
assembly 	
:	 

System 
. 

Reflection 
. (
AssemblyFileVersionAttribute 9
(9 :
$str: C
)C D
]D E
[ 
assembly 	
:	 

System 
. 

Reflection 
. 1
%AssemblyInformationalVersionAttribute B
(B C
$strC s
)s t
]t u
[ 
assembly 	
:	 

System 
. 

Reflection 
. $
AssemblyProductAttribute 5
(5 6
$str6 F
)F G
]G H
[ 
assembly 	
:	 

System 
. 

Reflection 
. "
AssemblyTitleAttribute 3
(3 4
$str4 D
)D E
]E F
[ 
assembly 	
:	 

System 
. 

Reflection 
. $
AssemblyVersionAttribute 5
(5 6
$str6 ?
)? @
]@ A˘
wE:\Projetos\GitHub\CSharp\PorExtenso\src\ExtensoSuporte\obj\Debug\net6.0\.NETCoreApp,Version=v6.0.AssemblyAttributes.cs
[ 
assembly 	
:	 

global 
:: 
System 
. 
Runtime !
.! "

Versioning" ,
., -$
TargetFrameworkAttribute- E
(E F
$strF `
,` a 
FrameworkDisplayNameb v
=w x
$str	y É
)
É Ñ
]
Ñ Ö˛X
BE:\Projetos\GitHub\CSharp\PorExtenso\src\ExtensoSuporte\Suporte.cs
	namespace 	
ExtensoSuporte
 
{ 
public 

class 
Suporte 
< 
T 
> 
where !
T" #
:$ %
new& )
() *
)* +
{ 
public 
bool 
TemNegativo 
;  
readonly 
int 
Zero 
= 
$num 
; 
readonly 
List 
< 
String 
> 
Unidade %
=& '
new( +
List, 0
<0 1
String1 7
>7 8
{9 :
$str; ?
,? @
$strA G
,G H
$strI O
,O P
$strQ Y
,Y Z
$str[ b
,b c
$strd j
,j k
$strl r
,r s
$strt z
,z {
$str	| Ç
}
É Ñ
;
Ñ Ö
readonly 
List 
< 
String 
> 
Dezena $
=% &
new' *
List+ /
</ 0
String0 6
>6 7
{8 9
$str: ?
,? @
$strA H
,H I
$strJ R
,R S
$strT ^
,^ _
$str` k
,k l
$strm w
,w x
$str	y Ç
,
Ç É
$str
Ñ ç
,
ç é
$str
è ò
}
ô ö
;
ö õ
readonly 
List 
< 
String 
> 
DezenaComplementar 0
=1 2
new3 6
List7 ;
<; <
String< B
>B C
{D E
$strF L
,L M
$strN T
,T U
$strV ]
,] ^
$str_ i
,i j
$strk s
,s t
$str	u Ä
,
Ä Å
$str
Ç å
,
å ç
$str
é ó
,
ó ò
$str
ô £
}
§ •
;
• ¶
readonly 
List 
< 
String 
> 
Centena %
=& '
new( +
List, 0
<0 1
String1 7
>7 8
{9 :
$str; @
,@ A
$strB L
,L M
$strN Y
,Y Z
$str[ j
,j k
$strl x
,x y
$str	z Ü
,
Ü á
$str
à î
,
î ï
$str
ñ ¢
,
¢ £
$str
§ ∞
}
± ≤
;
≤ ≥
readonly 
List 
< 
String 
> 
CentenaAglutinada /
=0 1
new2 5
List6 :
<: ;
String; A
>A B
{C D
$strD K
}K L
;L M
readonly 
List 
< 
String 
> 
Milhar $
=% &
new' *
List+ /
</ 0
String0 6
>6 7
{8 9
$str: ?
}@ A
;A B
readonly 
List 
< 
String 
> 
Milhao $
=% &
new' *
List+ /
</ 0
String0 6
>6 7
{8 9
$str: B
,B C
$strC L
}M N
;N O
readonly 
T 
tipo 
= 
new 
T 
(  
)  !
;! "
public 
T 
GetDI 
( 
) 
{ 	
return 
tipo 
; 
}   	
public'' 
string'' 
GetCardinal'' !
(''! "
int''" %
valorParaConverter''& 8
)''8 9
{(( 	
string)) 
ret)) 
;)) 
if++ 
(++ 
valorParaConverter++ "
==++# %
Zero++& *
)++* +
{,, 
ret-- 
=-- 
$str-- 
;-- 
return.. 
ret.. 
;.. 
}// 
int11 %
tamanhoParaReduzirDoValor11 )
=11* +
$num11, -
;11- .
TemNegativo22 
=22 
valorParaConverter22 ,
<22- .
$num22/ 0
;220 1
if44 
(44 
TemNegativo44 
)44 
{55 
valorParaConverter66 "
*=66# %
-66& '
$num66' (
;66( )
}77 
int99 )
quantidadeDeCaracteresDoValor99 -
=99. /
valorParaConverter990 B
.99B C
ToString99C K
(99K L
)99L M
.99M N
Length99N T
;99T U
int:: 
posicaoNalista:: 
=::  )
quantidadeDeCaracteresDoValor::! >
;::> ?
if<< 
(<< )
quantidadeDeCaracteresDoValor<< -
><<. /
$num<<0 1
)<<1 2
{== 
if>> 
(>> )
quantidadeDeCaracteresDoValor>> 1
==>>1 3
$num>>4 5
)>>5 6
{?? 
if@@ 
(@@ '
VerificaDecimalComplamentar@@ 3
(@@3 4
valorParaConverter@@4 F
)@@F G
)@@G H
{AA 
retBB 
=BB 
DezenaComplementarBB 0
[BB0 1
(BB1 2
valorParaConverterBB2 D
%BBE F
$numBBG I
)BBI J
-BBJ K
$numBBK L
]BBL M
;BBM N
}CC 
elseDD 
{EE 
retFF 
=FF 
DezenaFF $
[FF$ %
(FF% &
valorParaConverterFF& 8
/FF9 :
ConstroiDivisorFF; J
(FFJ K)
quantidadeDeCaracteresDoValorFFK h
)FFh i
)FFi j
-FFk l
$numFFm n
]FFn o
;FFo p
}GG 
}HH 
elseII 
ifII 
(II )
quantidadeDeCaracteresDoValorII 6
==II7 9
$numII9 :
)II: ;
{JJ 
ifKK 
(KK 
valorParaConverterKK *
>KK+ ,
$numKK- 0
&&KK1 3
valorParaConverterKK4 F
<=KKG I
$numKKJ M
)KKM N
{LL 
retMM 
=MM 
CentenaAglutinadaMM /
[MM/ 0
(MM0 1
valorParaConverterMM1 C
/MMD E
ConstroiDivisorMMF U
(MMU V)
quantidadeDeCaracteresDoValorMMV s
)MMs t
)MMt u
-MMv w
$numMMx y
]MMy z
;MMz {
}NN 
elseOO 
{PP 
retQQ 
=QQ 
CentenaQQ %
[QQ% &
(QQ& '
valorParaConverterQQ' 9
/QQ: ;
ConstroiDivisorQQ< K
(QQK L)
quantidadeDeCaracteresDoValorQQL i
)QQi j
)QQj k
-QQl m
$numQQn o
]QQo p
;QQp q
}RR 
}SS 
elseTT 
{UU 
ifVV 
(VV 
valorParaConverterVV *
>=VV+ -
$numVV. 2
)VV2 3
{WW %
tamanhoParaReduzirDoValorXX 1
=XX2 3
(XX4 5
valorParaConverterXX5 G
/XXH I
ConstroiDivisorXXJ Y
(XXY Z)
quantidadeDeCaracteresDoValorXXZ w
)XXw x
)XXx y
.XXy z
ToString	XXz Ç
(
XXÇ É
)
XXÉ Ñ
.
XXÑ Ö
Length
XXÖ ã
;
XXã å
retYY 
=YY 
$"YY  
{YY  !
GetCardinalYY! ,
(YY, -
valorParaConverterYY- ?
/YY@ A
ConstroiDivisorYYB Q
(YYQ R)
quantidadeDeCaracteresDoValorYYR o
)YYo p
)YYp q
}YYq r
$strYYr s
{YYs t
MilharYYt z
[YYz {
$numYY{ |
]YY| }
}YY} ~
"YY~ 
;	YY Ä
}ZZ 
else[[ 
{\\ 
ret]] 
=]] 
Milhar]] $
[]]$ %
$num]]% &
]]]& '
;]]' (
}^^ 
}`` 
valorParaConverterbb "
=bb# $
(bb% &'
VerificaDecimalComplamentarbb& A
(bbA B
valorParaConverterbbB T
)bbT U
?bbU V
$numbbV W
:bbW X
intbbX [
.bb[ \
Parsebb\ a
(bba b
valorParaConverterbbb t
.bbt u
ToStringbbu }
(bb} ~
)bb~ 
.	bb Ä
Remove
bbÄ Ü
(
bbÜ á
$num
bbá à
,
bbà â'
tamanhoParaReduzirDoValor
bbä £
)
bb£ §
)
bb§ •
)
bb• ¶
;
bb¶ ß
ifdd 
(dd )
quantidadeDeCaracteresDoValordd 1
>dd2 3
$numdd4 5
&&dd6 8
valorParaConverterdd9 K
!=ddL N
$numddN O
)ddO P
{ee 
retff 
+=ff 
(ff )
quantidadeDeCaracteresDoValorff 9
>=ff9 ;
$numff; <
?ff< =
$strff= @
:ff@ A
$strffA F
)ffF G
+ffH I
GetCardinalffJ U
(ffU V
valorParaConverterffV h
)ffh i
;ffi j
}gg 
elsehh 
ifhh 
(hh 
valorParaConverterhh *
!=hh+ -
$numhh. /
)hh/ 0
{ii 
retjj 
=jj 
GetCardinaljj %
(jj% &
valorParaConverterjj& 8
)jj8 9
;jj9 :
}kk 
}mm 
elsenn 
{oo 
retpp 
=pp 
Unidadepp 
[pp 
valorParaConverterpp 0
-pp1 2
$numpp3 4
]pp4 5
;pp5 6
}qq 
returnrr 
$"rr 
{rr 
(rr 
TemNegativorr "
?rr" #
$strrr# +
:rr, -
$strrr. 0
)rr0 1
}rr1 2
{rr2 3
retrr3 6
}rr6 7
"rr7 8
;rr8 9
}ss 	
privatezz 
staticzz 
boolzz '
VerificaDecimalComplamentarzz 7
(zz7 8
intzz8 ;
valorzz< A
)zzA B
{{{ 	
return|| 
(|| 
valor|| 
>|| 
$num|| 
&&|| !
valor||" '
<||( )
$num||* ,
)||, -
;||- .
}}} 	
private
àà 
static
àà 
int
àà 
ConstroiDivisor
àà *
(
àà* +
int
àà+ .
tamanhoDivisor
àà/ =
)
àà= >
{
ââ 	
return
ãã 
int
ãã 
.
ãã 
Parse
ãã 
(
ãã 
$"
ãã 
$str
ãã  
{
ãã  !
new
ãã! $
String
ãã% +
(
ãã+ ,
$char
ãã, /
,
ãã/ 0
tamanhoDivisor
ãã0 >
-
ãã> ?
$num
ãã? @
)
ãã@ A
}
ããA B
"
ããB C
)
ããC D
;
ããD E
}
åå 	
}
çç 
}éé â
HE:\Projetos\GitHub\CSharp\PorExtenso\src\ExtensoSuporte\Model\Numeral.cs
	namespace 	
ExtensoSuporte
 
. 
Model 
{ 
public 

class 
Numeral 
: 
	BaseModel $
<$ %
Numeral% ,
>, -
{ 
[ 	
NonSerialized	 
] 
private 
int 
numero 
; 
private 
string 
extenso 
; 
private 
string 
erro 
; 
public 
int 
Numero 
{ 
get 
=>  "
numero# )
;) *
set+ .
=>/ 1
numero2 8
=9 :
value; @
;@ A
}B C
public 
string 
Extenso 
{ 
get  #
=>$ &
extenso' .
;. /
set0 3
=>4 6
extenso7 >
=? @
valueA F
;F G
}H I
public 
string 
Erro 
{ 
get  
=>! #
erro$ (
;( )
set* -
=>. 0
erro1 5
=6 7
value8 =
;= >
}? @
} 
} ä
KE:\Projetos\GitHub\CSharp\PorExtenso\src\ExtensoSuporte\Model\IBaseModel.cs
	namespace 	
ExtensoSuporte
 
{ 
public 

	interface 

IBaseModel 
<  
out  #
T$ %
>% &
{ 
string 
ToJson 
( 
) 
; 
T 	
FromJson
 
( 
String 

jsonString $
)$ %
;% &
} 
} Ã	
JE:\Projetos\GitHub\CSharp\PorExtenso\src\ExtensoSuporte\Model\BaseModel.cs
	namespace 	
ExtensoSuporte
 
. 
Model 
{ 
[ 
Serializable 
] 
public 

class 
	BaseModel 
< 
T 
> 
: 

IBaseModel  *
<* +
T+ ,
>, -
{ 
public 
virtual 
T 
FromJson !
(! "
string" (

jsonString) 3
)3 4
{ 	
return 
JsonConvert 
. 
DeserializeObject 0
<0 1
T1 2
>2 3
(3 4

jsonString4 >
)> ?
;? @
} 	
public 
virtual 
string 
ToJson $
($ %
)% &
{ 	
string   
ret   
=   
JsonConvert   $
.  $ %
SerializeObject  % 4
(  4 5
this  5 9
)  9 :
;  : ;
return!! 
ret!! 
;!! 
}"" 	
}$$ 
}$$ 