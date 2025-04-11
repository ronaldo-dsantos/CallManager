```markdown
# CallManager 📞

**CallManager** é uma API REST desenvolvida com ASP.NET Core que tem como objetivo gerenciar chamados internos de um setor de planejamento. A aplicação permite o cadastro, consulta, atualização e remoção de chamados, com controle de permissões entre gestores e analistas.

## 🚀 Funcionalidades

- ✅ Cadastro de chamados com validação utilizando FluentValidation
- ✅ Mapeamento de dados com AutoMapper
- ✅ Estrutura em camadas (Api, Application e Infrastructure)
- ✅ Controle de notificações e respostas padronizadas
- ✅ Validação via DataAnnotations e ModelState
- 🔜 Autenticação e Autorização
- 🔜 Testes
- 🔜 Deploy em ambiente de produção

## 🛠️ Tecnologias Utilizadas

- ASP.NET Core
- Entity Framework Core
- AutoMapper
- FluentValidation
- Swagger (Swashbuckle)
- SQL Server (com EF Migrations)
- Visual Studio 2022

## 📦 Organização do Projeto

- `API` – Endpoints, configurações, middlewares
- `Application` – Entidades, enums, regras de negócio, serviços, DTOs, validações
- `Infra` – Persistência de dados e repositórios

## 📌 Status do Projeto

🚧 Em desenvolvimento  
Atualmente o projeto está passando pela implementação dos endpoints principais com validações customizadas e estruturação de respostas padronizadas.

## 📂 Como executar

1. Clone o repositório:
    ```bash
    git clone https://github.com/seu-usuario/CallManager.git
    ```
2. Abra o projeto no Visual Studio.

3. Atualize a string de conexão em `appsettings.Development.json`.

4. Execute as migrations:
    ```bash
    dotnet ef database update
    ```

5. Rode a aplicação (F5) e acesse o Swagger em:
    ```
    https://localhost:<porta>/swagger
    ```

## 📅 Commits

Este projeto está sendo versionado com commits representando cada etapa do desenvolvimento, para fins de documentação e revisão.

## ✍️ Autor

Ronaldo Domingues  
[LinkedIn](https://www.linkedin.com/in/ronaldo-domingues/) | [GitHub](https://github.com/ronaldo-dsantos)
```