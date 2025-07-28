# Projeto de Programação Orientada a Objetos em C#

Este projeto foi desenvolvido como parte da atividade **T2 – Explorando POO em Diferentes Linguagens**, cujo objetivo é demonstrar como os principais conceitos da Programação Orientada a Objetos (POO) são implementados na linguagem **C#**.

## 🎯 Objetivo da Atividade

- Compreender e aplicar os conceitos fundamentais da Programação Orientada a Objetos.
- Explorar como esses conceitos se comportam em uma linguagem moderna, no caso, o **C#**.
- Demonstrar de forma prática o uso desses conceitos por meio de um mini jogo de batalha por turnos no terminal.

---

## ⚙️ Conceitos Utilizados

O projeto demonstra os seguintes conceitos de POO:

| Conceito              | Descrição                                                                 |
|-----------------------|---------------------------------------------------------------------------|
| **Classe**            | Representa a estrutura de um personagem com propriedades e comportamentos. |
| **Atributos**         | `Nome`, `Vida`, `Ataque`, `Defesa`.                                       |
| **Instância**         | Criação de objetos a partir da classe `Personagem` e suas subclasses.      |
| **Construtor**        | Inicializa os valores dos atributos ao instanciar os objetos.              |
| **Herança**           | A classe `Mago` herda da classe `Personagem`.                              |
| **Polimorfismo**      | Método `Atacar()` sobrescrito na subclasse `Mago`.                         |
| **Tratamento de Exceções** | Uso de `try/catch` para capturar possíveis erros na execução.             |

---

## 🧪 Como Executar o Projeto

### Pré-requisitos:
- Ter o [.NET SDK](https://dotnet.microsoft.com/en-us/download) instalado
- VS Code ou qualquer editor de texto com suporte a C#

### Passos:

```bash
# 1. Clonar ou baixar o repositório
# 2. Navegar até a pasta do projeto
cd POO_CSharp

# 3. Rodar o projeto
dotnet run
```

---

## 🗂️ Estrutura do Projeto

POO_CSharp/
├── Program.cs
├── Models/
│   ├── Personagem.cs
│   ├── Mago.cs
│   └── Guerreiro.cs
└── README.md


---

## 👥 Desenvolvedores

- [Bruno Matheus Fridrich](https://github.com/Bruno-fridrich)
- [Eduarda Guimarães](https://github.com/eduarda-guimaraes)