## Atorres: 
 - Professor
 - Administrador

## Pré-Condição:

- O Ator deve ter um registro de acesso (email e senha) válido no sistema.

## Fluxo Principal:

- O Ator acessa a página de login do sistema.
- O Sistema exibe os campos para inserção de credenciais.
- O Ator insere o email e a senha.
- O Ator clica em "Entrar".
- O Sistema valida as credenciais com as informações armazenadas na entidade Professor (ou outra entidade de usuário, se houver um Administrador dedicado).
- Se as credenciais forem válidas, o Sistema concede acesso e direciona o Ator para a tela inicial (dashboard) correspondente ao seu perfil.

## Pós-Condição:

- O Ator está autenticado e tem acesso às funcionalidades do sistema de acordo com seu perfil.

## Fluxo Alternativo:

- Se o Sistema não encontrar a combinação de email e senha, ele exibe uma mensagem de erro ("Credenciais inválidas.") e o Ator permanece na tela de login.