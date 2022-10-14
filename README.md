# Como acessar o swagger
- No terminal, na pasta do projeto rodar
```csharp
dotnet watch run
```
- Acessar a URL
- https://localhost:5001/swagger/index.html


# Estando post via curl
```shell
curl -d '{"Id":"1", "Nome":"Danilo", "Telefone": "(11)11111-11111"}' -H "Content-Type: application/json" -X POST https://localhost:5001/
```
- Doc Curl
- https://gist.github.com/subfuzion/08c5d85437d5d4f00e58