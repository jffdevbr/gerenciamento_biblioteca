# gerenciamento_biblioteca
<b>Trabalho escolar</b>
Este programa serve para gerenciar bibliotecas. Tanto os alunos, quanto bibliotecários podem acessar o sistema.
Do lado dos alunos e professores, é possível visualizar os livros disponíveis e fazer uma reserva.
O bibliotecário pode inserir, alterar ou excluir dados dos livros, leitores e empréstimos.

Para a realização do programa, foi necessário criar um banco de dados (no caso foi no SQL Server) de nome "Biblioteca", com as tabelas:
- Usuario - id_usuario, usuário_login, senha, atrasos;
- Administrador - id_administrador, id_usuario, nome;
- Leitor - id_leitor, id_usuario, ocupacao, endereço, telefone, registro; 
- Livro - id_livro, tombo, título, autor, editora, categoria;
- Emprestimo - id_reserva, id_usuario, id_livro, data_empréstimo, data_previsão_devolução, data_devolução; 
- Reserva - id_usuario, id_livro, data_reserva;
