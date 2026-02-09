# Sistema de gerenciamento de lote de minerio (back-end)
lorreeeeeeee

# Entidades do negiocio
## Lote de minerio
Loremmmmmmm
### Propriedades

- **IdLote** – Identificador único do lote.  
- **IdMineradora** – Identificador da mineradora responsável.  
- **Teor** – Grau de pureza do minério.  
- **PesoQuantidade** – Quantidade total em peso do lote.  
- **ValorPKilo** – Valor monetário por quilo do minério.  
- **UnidadeDeMedidaPeso** – Unidade de medida utilizada (kg, t, etc).  
- **TipoMinerio** – Tipo de minério (ferro, ouro, cobre, etc).  
- **Status** – Status atual do lote no processo operacional.  
- **DataExtracao** – Data em que o minério foi extraído.

## Fluxo de operação do status do lote
## Status do Lote

| Ordem  | Status        | Descrição                                                |
|--------| ------------- | -------------------------------------------------------- |
|        | PLANEJADO     | Lote registrado no sistema, ainda não iniciado.          |
|        | EXTRACAO      | Minério está sendo extraído da mina.                     |
|        | EXTRAIDO      | Minério já foi retirado, aguardando processamento.       |
|        | PROCESSAMENTO | Está passando por beneficiamento.                        |
|        | PROCESSADO    | Já foi beneficiado tecnicamente.                         |
|        | ESTOQUE       | Armazenado no pátio ou silo.                             |
|        | RESERVADO     | Vinculado a uma venda ou cliente.                        |
|        | CARREGAMENTO  | Em processo de embarque.                                 |
|        | TRANSPORTE    | Em deslocamento até o destino.                           |
|        | ENTREGUE      | Recebido pelo cliente.                                   |
|        | FATURADO      | Nota fiscal emitida.                                     |
|        | ENCERRADO     | Processo totalmente finalizado.                          |
|        | BLOQUEADO     | Impedido por problemas técnicos, legais ou de qualidade. |
|        | CANCELADO     | Lote ou operação cancelada.                              |

</br>

# Operações do sistema
## Consultar 
## Consultar by id
## Consultar lote pelo status
## Adicionar um novo lote
## Atualizar um lote por id
## Remover um lote por id

## Regra de validação 





