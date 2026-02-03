# 🃏 CardManager

**CardManager** é uma aplicação web feita em **Blazor** para gerenciamento de cartas de um **card game fictício**.
O projeto utiliza **.NET, C#, SQL Server e Entity Framework Core**, com **renderização no servidor** e **interatividade em tempo real**.

Ele permite criar, visualizar e gerenciar cartas de forma dinâmica, simulando o backend de um jogo de cartas.

---

## 🧰 Tecnologias utilizadas

* .NET
* C#
* Blazor (Server / Interativo)
* Entity Framework Core
* SQL Server

---

## ⚙️ Configuração do projeto

Para rodar o projeto localmente, siga os passos abaixo.

### 1️⃣ Configure o banco de dados

No arquivo `appsettings.json`, ajuste a string de conexão para o seu SQL Server:

```json
"ConnectionStrings": {
  "SqlServerConnection": "Server=localhost;Database=SeuBancoDeDados;User Id=sa;Password=SuaSenha;Trusted_Connection=true;TrustServerCertificate=true"
}
```

---

### 2️⃣ Crie o banco com as migrations

No terminal, dentro da pasta do projeto, execute:

```bash
dotnet ef database update
```

> Caso não tenha o EF instalado:

```bash
dotnet tool install --global dotnet-ef
```

Ou instale o pacote:

```
Microsoft.EntityFrameworkCore.Tools
```

---

### 3️⃣ Build do projeto

Antes de executar, gere os arquivos da aplicação:

```bash
dotnet build
```

---

### 4️⃣ Rodar a aplicação

```bash
dotnet run
```

Depois disso, o projeto estará disponível no navegador.

---

## 🧪 Debug no VS Code

Se você estiver usando **VS Code**, é recomendado instalar a extensão:

**C# Dev Kit**

Ela fornece:

* Debug
* IntelliSense
* Build e execução integrados

---

## 📌 Observações

Este projeto foi desenvolvido com foco em:

* Arquitetura backend com EF Core
* Blazor Server
* Persistência de dados
* Organização de entidades e contexto
