# 💆‍♂️ MassagemPlusApi

**MassagemPlusApi** é uma Web API desenvolvida em **C# com ASP.NET Core**, focada na gestão de agendamentos de massagens. 
A proposta é conectar clientes a massagistas de forma prática e profissional, com suporte a perfis personalizados, 
serviços premium e múltiplas formas de pagamento.

---

## ✨ Funcionalidades

- ✅ Cadastro e autenticação de **massagistas**
- ✅ Cadastro e autenticação de **clientes**
- ✅ Perfil completo do massagista com:
  - Fotos do ambiente e da profissional
  - Descrição das técnicas oferecidas
  - Duração e valor das sessões
  - Serviços premium exclusivos
  - Formas de pagamento aceitas
- ✅ Agendamento de sessões
- ✅ Busca de massagistas por **cidade e estado**

---

## 🧱 Tecnologias Utilizadas

- ASP.NET Core 8
- Entity Framework Core
- SQLite (ou outro banco relacional)
- AutoMapper (para mapeamento de DTOs)
- Swagger (documentação automática)

---

## 📷 Prints
Em breve

---

## 📘 Status do Projeto
Em andamento

---

## ✍️ Autor
- 👨🏾‍💻 Jorge Menezes
- 📧 jorgedimendes@hotmail.com
- 🐙 [github.com/jorgedimendes](https://github.com/JorgeDimendes)

---

## 🚀 Como Executar
1. Clone o repositório:
```
git clone https://github.com/JorgeDimendes/MassagemPlusApi.git
```

2. Acesse a pasta do projeto:
```
cd MassagemPlusApi
```

3. Restaure os pacotes e rode as migrações:
```
dotnet restore
dotnet ef database update
```

4. Execute a aplicação:
```
dotnet run
```

5. Acesse o Swagger:
```
https://localhost:{porta}/swagger
```
