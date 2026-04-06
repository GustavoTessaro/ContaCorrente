# 💰 Sistema de Conta Bancária em C#

## 📌 Descrição

Este projeto é um sistema simples de simulação de contas bancárias
desenvolvido em **C#**. Ele permite realizar operações básicas como:

-   Saque
-   Depósito
-   Consulta de saldo
-   Transferência entre contas

O programa roda no console e utiliza um menu interativo para o usuário
escolher as operações.

------------------------------------------------------------------------

## 🏗️ Estrutura do Projeto

O sistema é composto por duas partes principais:

-   Classe `Conta` → Representa uma conta bancária
-   Classe `Program` → Controla a execução do sistema

------------------------------------------------------------------------

## 👤 Classe `Conta`

### 🔹 Atributos

  Atributo   Tipo     Descrição
  ---------- -------- ------------------------
  titular    string   Nome do dono da conta
  ID         int      Identificador da conta
  saldo      double   Saldo atual da conta

------------------------------------------------------------------------

### 🔹 Construtor

``` csharp
public Conta(string titular, int ID, double saldo)
```

------------------------------------------------------------------------

### 🔹 Métodos

#### 📌 Getters

-   GetTitular()
-   GetID()
-   GetSaldo()

#### 💵 Depositar

Adiciona valor ao saldo.

#### 💸 Sacar

-   Permite saldo até -200
-   Retorna true ou false

#### 🔄 Transferir

-   Saca de uma conta
-   Deposita em outra

------------------------------------------------------------------------

## 🖥️ Classe `Program`

### 📋 Menu

1 - Saque\
2 - Depósito\
3 - Consultar Saldos\
4 - Transferência\
5 - Sair

