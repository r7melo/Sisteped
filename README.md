# Sisteped - Sistema de Gestão Pedagógica

Uma ferramenta prática para professores: este projeto oferece um aplicativo que centraliza o gerenciamento de turmas e alunos, permitindo acompanhar notas, desempenho por conteúdo e comportamentos individuais. Com ele, o professor consegue identificar padrões, acompanhar a evolução de cada aluno e tomar decisões pedagógicas mais eficazes, tudo de forma intuitiva, rápida e personalizada. É um sistema que coloca o controle e a clareza nas mãos do professor, facilitando o ensino e fortalecendo o acompanhamento do aprendizado.

---

## 1. Requisitos Funcionais (por Módulo)

### **Módulo ALU – Alunos**
**ALU-01 – Cadastro de Alunos**  
- Adicionar, editar e remover alunos.  
- Armazenar informações básicas: nome, idade, turma, contato opcional.

**ALU-02 – Histórico do Aluno**  
- Visualizar histórico consolidado de notas e comportamentos por aluno.

**ALU-03 – Busca e Filtros de Alunos**  
- Buscar alunos por nome, turma ou tags de comportamento/desempenho.

---

### **Módulo TUR – Turmas**
**TUR-01 – Gerenciamento de Turmas**  
- Criar turmas personalizadas.  
- Adicionar ou remover alunos de cada turma.

**TUR-02 – Visão Geral da Turma**  
- Exibir resumo de desempenho médio da turma (notas e comportamentos).

---

### **Módulo NOT – Notas**
**NOT-01 – Registro de Notas**  
- Lançar notas para cada aluno.  
- Adicionar tags às notas para identificar conteúdos ou competências.  
- Visualizar histórico de notas por aluno ou turma.

**NOT-02 – Média e Estatísticas**  
- Calcular média automática por conteúdo, aluno e turma.

**NOT-03 – Notas por Conteúdo**  
- Filtrar notas por matéria, conteúdo ou competência específica.

---

### **Módulo COM – Comportamentos**
**COM-01 – Registro de Comportamentos**  
- Criar cards de comportamento com descrição e tipo.  
- Associar comportamentos a alunos.  
- Registrar histórico por aluno e turma.

**COM-02 – Métricas de Frequência**  
- Analisar padrões de comportamentos positivos/negativos por período.

---

### **Módulo MON – Monitoramento e Análises**
**MON-01 – Análises Acadêmicas**  
- Gráficos e indicadores de desempenho por conteúdo.

**MON-02 – Análises Comportamentais**  
- Frequência por tipo de comportamento.

**MON-03 – Comparação Temporal**  
- Comparar evolução de alunos ao longo do tempo.

**MON-04 – Painel Geral do Professor**  
- Dashboard com visão agregada do semestre, turmas e alertas.

---

### **Módulo REL – Relatórios**
**REL-01 – Exportação e Relatórios**  
- Gerar relatórios para impressão ou compartilhamento.  
- Exportar dados para CSV ou PDF.

**REL-02 – Relatório Consolidado da Turma**  
- Documento com notas, médias, estatísticas e análises de comportamento.

---

### **Módulo SYS – Sistema / Infraestrutura**
**SYS-01 – Armazenamento Local**  
- Banco de dados local para salvar todas as informações.  
- Funcionamento offline.

**SYS-02 – Backup Local Manual**  
- Exportar e importar backups do banco local.

**SYS-03 – Tema Claro/Escuro**  
- Alternar entre dois temas para melhorar a usabilidade.

---

## 2. Requisitos Não Funcionais (Metrificados)

1. **Usabilidade**
   - Tempo médio para realizar ações comuns (ex.: lançar nota) ≤ **5 segundos**.
   - Usuário deve conseguir localizar qualquer função principal em até **3 cliques**.

2. **Performance**
   - Operações de cadastro, edição e remoção devem responder em **< 200 ms**.  
   - Consultas com filtros devem carregar em até **1 segundo**, mesmo com 300+ alunos.

3. **Segurança**
   - Dados locais devem estar armazenados com criptografia AES-256 ou equivalente.  
   - Processo de backup deve gerar arquivo íntegro em **100%** das tentativas.

4. **Portabilidade**
   - Compatível com Windows, Linux e macOS.  
   - Interface deve se adaptar corretamente a telas entre **768px e 4K**.

5. **Escalabilidade**
   - Arquitetura deve permitir adicionar novos módulos sem refatorações extensas, com impacto máximo de **< 10%** sobre módulos já existentes.  
   - Banco local deve suportar crescimento até **10 mil registros** sem perda de performance significativa.

---
## Diagrama de Relacionamento
![](docs/imagens/Diagram%20de%20Classes%20-%20Sisteped.png)

## Casos de Uso
Pasta: `/docs/casos de uso/`

![](docs/imagens/use%20cases.png)
