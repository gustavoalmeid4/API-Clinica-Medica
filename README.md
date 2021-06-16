
# Medical API

CRUD EntityFramework / SqlServer


## Autor

- [@gustavoalmeid4](https://www.github.com/gustavoalmeid4)

  
## Referencias da API

#### Lista todos Pacientes

```http
  https://localhost:44327/api/Pacientes 
```

#### Busca Paciente por ID

```http
  https://localhost:44327/api/Pacientes/{ID}
```

#### Lista todos Medicos

```http
  https://localhost:44327/api/Medicos
```

#### Busca Medico por ID

```http
  https://localhost:44327/api/Medicos/{ID}
```

#### Cadastrar Medico
```json
{
    "Nome": "NomeAqui",
    "Especialidade": "EspecialidadeAqui",
    "CRM": 123456
}
  ```
#### Cadastrar Paciente
  ```json
{
    "Nome": "SeuNome",
    "Idade": 19,
    "DataNascimento": "2001-08-30",
    "CPF": "1234567898",
    "TipoSanguineo": "A"
}
  ```


  
