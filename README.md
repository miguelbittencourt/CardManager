# CardManager
Um app blazor de gerenciamento de cartas de um card game fictício, feito com .NET, C#, Blazor, SQL Server e Entity Framework Core, usando Interatividade e renderização de servidor.

Para que o app funcione você precisa criar seu banco de dados com SQL Server, voce consegue fazer isso mudando a connection string em appsettings.json para o seu contexto de banco de dados:

"ConnectionStrings": { "SqlServerConnection": "Server=localhost;Database=SeuBancoDeDados;User Id=SeuUsuario(padrão=sa);Password=SuaSenha;Trusted_Connection=true;TrustServerCertificate=true" }

Depois disso é necessário rodar as migrações e atualizações de banco de dados, voce pode usar o dotnet-ef para fazer tais coisas ou instalar o package Microsoft.EntityFrameworkCore.Tools para usar os comandos desse package para fazer as migrações e atualizar o banco de dados.

Lembre-se de rodar um dotnet build para criar os arquivos para execução do projeto, também para poder debugar o projeto caso queira
Se for usar o vs code assim como usei e quiser debugar a aplicação é pertinente instalar a extensão C# DevKit que traz tudo que você precisa para executar e testar a aplicação
