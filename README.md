# admistrator

Visão Geral

A Administrator API é uma API desenvolvida em .NET para gerenciamento de tarefas. Esta API permite criar, atualizar, deletar e consultar tarefas.

Tecnologias Utilizadas

.NET 8

ASP.NET Core

C#

Arquitetura em Camadas (Application, Communication, Controller)

Estrutura do Projeto

O projeto segue uma arquitetura em camadas, onde:

Administrator.Application.UseCase.Task contém os casos de uso (Create, Update, Delete, GetById, GetAll)

Admistrator.Communication.Requests contém os objetos de requisição

Admistrator.Communication.Responses contém os objetos de resposta

Administrator.Api.Controllers contém os controladores da API
