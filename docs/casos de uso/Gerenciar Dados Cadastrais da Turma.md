Atores: Administrador do Sistema.

Pré-condição: Administrador logado; classes Turma, Aluno e Professor existentes.

Fluxo Principal:

Administrador seleciona a Turma a ser modificada.

Administrador adiciona/remove a associação de um Aluno à Turma.

Administrador associa/desassocia um Professor à Turma.

Sistema atualiza os relacionamentos.

Pós-condição: A composição de Alunos e Professores na Turma é atualizada.

Fluxos Alternativos: O sistema deve impedir a remoção de um Professor ou Aluno da Turma se houver alguma pendência de dados (ex: notas não lançadas).