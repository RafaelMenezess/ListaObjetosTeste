# ListaObjetos

# Apple Devices Filter

Este projeto em C# faz uma chamada a uma API REST para obter uma lista de dispositivos eletrônicos, filtra os dispositivos da marca Apple e salva os atributos em um arquivo CSV.

## Pré-requisitos

- .NET 6.0 SDK
- Biblioteca CsvHelper

## Instalação

1. Clone este repositório:

    ```bash
    git clone <https://github.com/RafaelMenezess/ListaObjetosTeste/tree/master>
    cd <https://github.com/RafaelMenezess/ListaObjetosTeste/tree/master>
    ```

2. Instale as dependências:

    ```bash
    dotnet add package CsvHelper
    ```

## Uso

1. Execute o programa:

    ```bash
    dotnet run
    ```

2. O arquivo `apple_eletronicos.csv` será gerado no diretório de execução.

## Estrutura do Projeto

- **Program.cs**: Contém a lógica principal do programa.
- **Device.cs**: Define as classes `Eletronicos` e `Data`.
- **apple_devices.csv**: Arquivo gerado com os dispositivos da Apple.

## Contribuição

Sinta-se à vontade para abrir issues e enviar pull requests. Todas as contribuições são bem-vindas!

## Licença

Este projeto está licenciado sob os termos da licença MIT.
