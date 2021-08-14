# Status

[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=laikha_PorExtenso&metric=alert_status)](https://sonarcloud.io/dashboard?id=laikha_PorExtenso)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=laikha_PorExtenso&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=laikha_PorExtenso) [![Bugs](https://sonarcloud.io/api/project_badges/measure?project=laikha_PorExtenso&metric=bugs)](https://sonarcloud.io/dashboard?id=laikha_PorExtenso) [![Duplicated Lines (%)](https://sonarcloud.io/api/project_badges/measure?project=laikha_PorExtenso&metric=duplicated_lines_density)](https://sonarcloud.io/dashboard?id=laikha_PorExtenso) [![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=laikha_PorExtenso&metric=ncloc)](https://sonarcloud.io/dashboard?id=laikha_PorExtenso) [![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=laikha_PorExtenso&metric=code_smells)](https://sonarcloud.io/dashboard?id=laikha_PorExtenso)
<h1>PorExtenso</h1>
Código para retornar o extenso de um número inteiro informado


<h4>Para o uso deve ser feito o envio da seguinte forma</h4>
http://localhost:5000/1397

<h4>O retorno esperado é</h4>
{"extenso":"Mil e Trezentos e Noventa e Sete","erro":null}

<h4>Caso ocorra algum erro ou o campo fique vazio o campo de erro será preenchido o extenso tera seu valor anulado</h4>
{"extenso":null, "erro":"é necessário informar um número entre -99999 e 99999"}


<h2>Doxygen</h2>
Para gerar a documentção a partir do código eu costumo utilizar o http://www.doxygen.nl/
