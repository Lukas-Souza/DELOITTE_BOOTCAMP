# SISTEMA DE GERENCIAMENTO DE EQUIPAMENTOS PESADO


## Crontrolles/Routes

### EQUIPAMENTOS
#### GET
````bash
http://localhost:5132/equipamentos/
````
#### GET BY ID 
```bash
http://localhost:5132/equipamentos/{id}
```

#### CREATE EQUIPAMENTO
##### HTTP URL
````bash
http://localhost:5132/equipamentos/
````
##### JSON REQUIRE
````json
{
  "Tipo": "Escavadeira",
  "Codigo": "EQP001",
  "Modelo": "X1000",
  "Horimetro": 1.5,
  "StatusOperacional": "OPERACIONAL",
  "DataAquisicao": "2026-02-19T17:55:00Z",
  "LocalizacaoAtual": "Mineração Norte"
}
````
#### UPDATE EQUIPAMENTO 
##### HTTP URL

````bash
http://localhost:5132/equipamentos/{id}
````
##### JSON REQUIRE
````json
{
  "Tipo": "Escavadeira",
  "Codigo": "EQP001",
  "Modelo": "X1000",
  "Horimetro": 1.5,
  "StatusOperacional": "OPERACIONAL",
  "DataAquisicao": "2026-02-19T17:55:00Z",
  "LocalizacaoAtual": "Mineração Norte"
}
````

### DELETE 
````bash
http://localhost:5132/equipamentos/{id}
````

## GET START
#### GIT CLONE 
````bash
 git clone https://github.com/Lukas-Souza/DELOITTE_BOOTCAMP.git
 cd 
````

#### RUN PROJECT
````bash

````