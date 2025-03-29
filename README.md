# Integrantes
 - Cauã Ferrigolli - RM553093
 - Sabrina da Motta Café - RM553568
 - Luís Henrique - RM552692
 - Matheus Duarte - RM554199
   
# Brinquedos API

Este projeto consiste em uma API RESTful desenvolvida com ASP.NET Core para gerenciar brinquedos, clientes e vendedores de uma loja infantil.

## Tecnologias Utilizadas

- ASP.NET Core
- Entity Framework Core
- Oracle Database
- Swagger (para testes de endpoints)
- Postman (para testes manuais)
- HTML (frontend básico)

## Estrutura do Projeto

- Models/
  - Brinquedo.cs
  - Cliente.cs
  - Vendedor.cs
- Controllers/
  - BrinquedosController.cs
  - ClientesController.cs
  - VendedoresController.cs
- Data/
  - AppDbContext.cs
- appsettings.json (configuração de conexão Oracle)
- Program.cs
- launchSettings.json
- Frontend/index.html
- script_oracle.sql (criação das tabelas no banco)

## Configuração da Conexão Oracle

A string de conexão está localizada no arquivo `appsettings.json`:

```
"ConnectionStrings": {
  "OracleDb": "User Id=rm554199;Password=160103;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=oracle.fiap.com.br)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));"
}
```

## Como Executar

1. Configure corretamente a connection string no `appsettings.json`.
2. No terminal, navegue até a pasta `BrinquedosApi/` e execute:

```
dotnet restore
dotnet build
dotnet run
```

## Testes com Postman

Importe a coleção `BrinquedosAPI.postman_collection.json` para testar todos os endpoints.

## Frontend

Para testar visualmente, abra o arquivo `Frontend/index.html` no navegador. Ele faz uma requisição para listar os brinquedos.
