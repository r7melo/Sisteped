## Atores: 
- Aluno

## Pré-condição: 
- Aluno logado
- Registros de Avaliação e Comportamento existem para o Aluno.

## Fluxo Principal:

- Aluno solicita a consulta do seu histórico.
- Sistema recupera todos os objetos de Avaliação e Comportamento ligados ao Aluno.
- Sistema exibe as notas, datas, tipos de avaliação e os registros de comportamento (tag, observação).

## Pós-condição:
- O Aluno visualiza seu histórico acadêmico e comportamental completo de forma organizada.

## Fluxos Alternativos: 
- O sistema deve exibir uma mensagem "Nenhum registro encontrado" se não houver dados de Avaliação ou Comportamento ligados ao Aluno.