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
### Status do Lote

| Ordem  | Status        | Descrição                                                |
|--------| ------------- | -------------------------------------------------------- |
|    1º   | PLANEJADO     | Lote registrado no sistema, ainda não iniciado.          |
|       2º | EXTRACAO      | Minério está sendo extraído da mina.                     |
|        3º| EXTRAIDO      | Minério já foi retirado, aguardando processamento.       |
|      4º  | PROCESSAMENTO | Está passando por beneficiamento.                        |
|       5º | PROCESSADO    | Já foi beneficiado tecnicamente.                         |
|       6º| ESTOQUE       | Armazenado no pátio ou silo.                             |
|       7º | RESERVADO     | Vinculado a uma venda ou cliente.                        |
|       8º | CARREGAMENTO  | Em processo de embarque.                                 |
|       9º | TRANSPORTE    | Em deslocamento até o destino.                           |
|       10º | ENTREGUE      | Recebido pelo cliente.                                   |
|        11º| FATURADO      | Nota fiscal emitida.                                     |
|        12º| ENCERRADO     | Processo totalmente finalizado.                          |
|    ***    | BLOQUEADO     | Impedido por problemas técnicos, legais ou de qualidade. |
|    ***    | CANCELADO     | Lote ou operação cancelada.                              |

</br>

# Operações do sistema
## Consultar 
#### GET
````bash 
# Retornar todos os registros
https://localhost:5167/lot-minerio/   
````
## Consultar by id

````bash 
# Retornar todos os registros
https://localhost:5167/lot-minerio/{number}    
````
## Consultar lote pelo status
`````python 
# Retorna todos os registros que tenha o status iguais a query
https://localhost:5167/lot-minerio/status={status_text}
`````
## Adicionar um novo lote
### Json Body
````Json
{
    
}
````
## Atualizar um lote por id
## Remover um lote por id

## Regra de validação 


````Javascript
int  
````
