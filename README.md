# Classificação de candidatos aprovados em concursos públicos

Aplicação de console que realiza a classificação automática de candidatos aprovados em concursos públicos.

A lista de aprovados geralmente é divulgada no site da instituição que realiza o concurso e/ou no site da banca examinadora.

Essa lista, além de poder ser extensa, segue, em geral, o padrão: nº de inscrição do candidato, nome do candidato, acertos e pontuações em cada seção da prova realizada, sendo o último número a representação da nota final do candidato. Por exemplo:

- 99999999, Neymar da Silva Santos Júnior 30.00 32 45.00 50 18.00 25 60.00 11 13.00

Neste caso, temos:

- Nº de inscrição do candidato: 99999999
- Nome do candidato: Neymar da Silva Santos Júnior
- Pontuação final: 13.00

A partir das 3 informações anteriores, pode-se ranquear cada candidato. Portanto, faça os seguintes procedimentos para executar a aplicação:

1. Edite o arquivo *Aprovados.txt* com os dados referentes aos aprovados que você deseja obter a classificação no concurso.
2. Troque o valor da variável *CAMINHO_ARQUIVO_ENTRADA* para o caminho em disco do arquivo *Aprovados.txt*.
3. Execute a aplicação e obtenha a classificação correspondente de cada candidato da lista de aprovados.

Veja o arquivo *ExemploExecucao.png* para um exemplo da aplicação em execução.
