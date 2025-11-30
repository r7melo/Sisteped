## Atores: 
- Professor

# Pré-condição: 
- Professor logado; as classes Turma e Aluno e a Avaliação (ou seus dados iniciais) estão cadastradas.

## Fluxo Principal:

- Professor seleciona a Turma.

- Professor seleciona ou cria a Avaliação (conteúdo, tipo).

- Professor insere a nota:float para cada Aluno.

- Sistema armazena a nota associada ao Aluno e à Avaliação.

## Pós-condição: 
- Um novo registro de nota é criado ou atualizado na classe Avaliação.

## Fluxos Alternativos:
- O sistema deve rejeitar e solicitar correção se a nota inserida não for um valor numérico (float) ou estiver fora do limite permitido.