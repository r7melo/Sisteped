# Sisteped - Sistema de Gestão Pedagógica

Uma ferramenta prática para professores: este projeto oferece um aplicativo que centraliza o gerenciamento de turmas e alunos, permitindo acompanhar notas, desempenho por conteúdo e comportamentos individuais. Com ele, o professor consegue identificar padrões, acompanhar a evolução de cada aluno e tomar decisões pedagógicas mais eficazes, tudo de forma intuitiva, rápida e personalizada. É um sistema que coloca o controle e a clareza nas mãos do professor, facilitando o ensino e fortalecendo o acompanhamento do aprendizado.

---

## 1. Requisitos Funcionais

1. **Cadastro de Alunos**
   - Adicionar, editar e remover alunos.
   - Armazenar informações básicas: nome, idade, turma, contato opcional.

2. **Gerenciamento de Turmas**
   - Criar turmas personalizadas.
   - Adicionar ou remover alunos de cada turma.

3. **Registro de Notas**
   - Lançar notas para cada aluno.
   - Adicionar tags às notas para identificar conteúdos ou competências (ex.: trigonometria, prova prática).
   - Visualizar histórico de notas por aluno ou turma.

4. **Registro de Comportamentos**
   - Criar cards de comportamento com descrição e tipo (ex.: falador, participativo, atrasado).
   - Associar comportamentos a alunos específicos.
   - Gerar histórico de comportamentos por aluno e por turma.

5. **Monitoramento e Análise**
   - Apresentar gráficos ou indicadores do desempenho acadêmico por conteúdo.
   - Permitir análise de frequência de comportamentos por tipo.
   - Comparar evolução dos alunos ao longo do tempo.

6. **Exportação e Relatórios**
   - Gerar relatórios simples para impressão ou compartilhamento com pais.
   - Possibilidade de exportar dados para CSV ou PDF.

7. **Armazenamento Local**
   - Banco de dados local para salvar todas as informações.
   - Funcionamento offline, sem depender de servidor externo.

---

## 2. Requisitos Não Funcionais

1. **Usabilidade**
   - Interface intuitiva e simples, focada no uso rápido pelo professor.
   - Navegação clara entre alunos, turmas e registros.

2. **Performance**
   - Sistema rápido mesmo com várias turmas e dezenas de alunos.
   - Atualização instantânea de notas e comportamentos.

3. **Segurança**
   - Proteção básica dos dados armazenados localmente.
   - Possibilidade de backup manual dos dados.

4. **Portabilidade**
   - Aplicativo desktop ou multiplataforma (Windows, Linux, macOS).
   - Suporte para diferentes resoluções de tela.

5. **Escalabilidade**
   - Estrutura que permita adicionar futuramente módulos como provas, conteúdos ou integração com outros sistemas, sem reescrever tudo.


-- 

## Diagrama de Relacionamento
![](docs/imagens/Diagrama%20de%20Relacionamento%20-%20Sisteped.png)






