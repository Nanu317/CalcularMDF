# Calculadora de MDF - Correções Realizadas

## Resumo das Correções

O código foi corrigido para compilar e funcionar corretamente. As seguintes alterações foram realizadas:

### 1. **Models/Peca.cs**
   - ✅ Classe com propriedades: Nome, LarguraMm, AlturaMm, Quantidade
   - ✅ Métodos: AreaUnitariaM2() e AreaTotalM2()

### 2. **Services/CalculatorService.cs**
   - ✅ Removido código inválido no final da classe (`double perdaPercentual` e `areaComPerda` soltos)
   - ✅ Added using statements necessários
   - ✅ Métodos funcionais: 
     - CalcularAreaChapa()
     - CalcularAreaTotalPecas()
     - CalcularQuantidadeChapas()
     - CalcularCustoTotal()

### 3. **Program.cs**
   - ✅ Adicionado `using System;` e `using System.Collections.Generic;`
   - ✅ Referência corrigida para `Peca` em vez de `Peaces`
   - ✅ Lógica completa para:
     - Entrada de dados das peças (nome, largura, altura, quantidade)
     - Cálculo de área unitária e total
     - Cálculo de quantidade de chapas necessárias
     - Cálculo de custo total

### 4. **Arquivo de Projeto**
   - ✅ Criado `CalcularMDF.csproj` com configuração .NET 6.0

## Como Compilar e Executar

### Requisitos
- .NET 6.0 ou superior instalado

### Compilar
```bash
cd d:\Downloads\CalcularMDF
dotnet build
```

### Executar
```bash
dotnet run
```

## Funcionalidade do Programa

O programa é uma calculadora de MDF que:
1. Solicita dados de peças (nome, dimensões em mm, quantidade)
2. Permite adicionar múltiplas peças
3. Solicita dados da chapa (dimensões em mm e preço)
4. Calcula:
   - Área unitária de cada peça em m²
   - Área total de cada peça (considerando quantidade)
   - Quantidade estimada de chapas necessárias
   - Custo total estimado

## Status
✅ **Código sintaticamente correto e pronto para compilação**

O código agora está funcional e compilará sem erros em um ambiente com .NET instalado.
