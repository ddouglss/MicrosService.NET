# GeekShopping - Microsserviços com .NET 8
![.NET](https://img.shields.io/badge/.NET-8-blue)
![C#](https://img.shields.io/badge/C%23-8.0-green)
![License](https://img.shields.io/badge/license-MIT-blue)

## Sobre

Projeto de microsserviços desenvolvido com ASP.NET Core 8, implementando conceitos modernos de arquitetura distribuída, segurança, mensageria e orquestração.  
Esse sistema simula um e-commerce com serviços independentes para Produtos, Carrinho, Cupons e Autenticação (Identity Server).

Baseado no curso de microsserviços com .NET 8, OAuth2, OpenID, Identity Server, RabbitMQ, Ocelot, Swagger e muito mais.

## Tecnologias utilizadas

- .NET 6 / ASP.NET Core
- C#
- Duende Identity Server (OAuth2, OpenID Connect)
- RabbitMQ (mensageria)
- Ocelot API Gateway
- Swagger / Swashbuckle (documentação API)
- JWT (JSON Web Tokens)
- MongoDB / SQL Server (banco de dados)
- Docker (opcional)

## Microsserviços

- **ProductAPI** — Serviço de gerenciamento de produtos
- **CartAPI** — Serviço de gerenciamento de carrinho de compras
- **CouponAPI** — Serviço de cupons de desconto
- **IdentityServer** — Serviço de autenticação e autorização baseado em OAuth2/OpenID Connect
- **API Gateway** — Usando Ocelot para roteamento e segurança

## Funcionalidades principais

- APIs REST para cada microsserviço, desacoplados e independentes
- Segurança via OAuth2 com tokens JWT e Identity Server
- Comunicação síncrona via HTTP e assíncrona via RabbitMQ
- Aplicação de cupons de desconto no carrinho
- Documentação automática com Swagger para todas APIs
- Suporte para deploy local e em containers Docker

## Como rodar localmente

1. Clone o repositório:

```bash
git clone https://github.com/seu-usuario/seu-repositorio.git
cd seu-repositorio
```

- Configure as variáveis de ambiente e os arquivos appsettings.json em cada microsserviço.
## Inicie o RabbitMQ (local ou via Docker):

```bash
docker run -d --hostname rabbitmq --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:3-management
```
## Execute os microsserviços na ordem recomendada:

- IdentityServer
- ProductAPI
- CouponAPI
- CartAPI
- API Gateway (Ocelot)

 <b>Acesse a documentação Swagger em cada serviço via navegador (ex: https://localhost:4440/swagger)<b/>

## Rodando com Docker Compose 
```bash
docker-compose up --build
```
## Contribuição

Contribuições são bem-vindas! Faça um fork do projeto, crie sua branch com feature/bugfix e envie um pull request.

## Licença
Este projeto está licenciado sob a licença MIT. Veja o arquivo LICENSE para mais detalhes.

## ✍️ Autor

**Douglas Muniz**  
Estudante e desenvolvedor Java em constante aprendizado.  
[LinkedIn](https://www.linkedin.com/) • [GitHub](https://github.com/seu-usuario)

---
> _Este repositório acompanha a evolução prática do conteúdo abordado no curso, com foco em aprendizado sólido e aplicação no mundo real._

