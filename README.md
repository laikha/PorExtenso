# PorExtenso

[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=laikha_PorExtenso&metric=alert_status)](https://sonarcloud.io/dashboard?id=laikha_PorExtenso)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=laikha_PorExtenso&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=laikha_PorExtenso)
[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=laikha_PorExtenso&metric=bugs)](https://sonarcloud.io/dashboard?id=laikha_PorExtenso)

API REST em ASP.NET Core que converte números inteiros em sua representação por extenso em português. Aceita valores de **-999999 a 999999**.

## Requisitos

- .NET SDK 10.0

## Executar a API

Na raiz do repositório, execute:

```bash
dotnet run --project src/PorExtenso/PorExtenso.csproj
```

O perfil de desenvolvimento disponibiliza a API em `http://localhost:5000`.

## Endpoint

```http
GET /api/values/{numero}
```

Exemplo:

```bash
curl http://localhost:5000/api/values/1397
```

Resposta:

```json
{"Numero":1397,"Extenso":"Mil Trezentos e Noventa e Sete","Erro":null}
```

O endpoint exige um número dentro do intervalo permitido. Uma entrada ausente ou fora desse intervalo retorna HTTP `400 Bad Request`; em caso de erro, a propriedade `Erro` contém a mensagem e `Extenso` fica nula.

## Testes

Para executar os testes da solução:

```bash
dotnet test src/PorExtenso.sln --configuration Release
```

## Estrutura

- `src/PorExtenso`: API ASP.NET Core e controlador HTTP.
- `src/ExtensoSuporte`: conversão dos números e modelos de resposta.
- `src/TestPorExtenso`: testes automatizados.

O GitHub Actions valida os testes com .NET 10 e automatiza o fluxo de pull requests entre as branches de desenvolvimento e release.
