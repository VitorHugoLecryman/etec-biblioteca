--Inserir um livro no banco, com as suas respectiva informacoes na tabela tb_livros  
INSERT INTO tb_livros(
    nr_tombo, 
    nr_isbn, 
    ds_nomelivro, 
    id_autorlivro, 
    nr_anolivro,
    id_generolivro,
    id_editoralivro,
    id_exemplares,
    status_livro) 
VALUES (
    '"+tombo+"', 
    '" + txtISBN.Text + "',
    '" + txtNmLivro.Text + "', 
    '" + id_autor + "',
    '" + txtAno.Text + "',
    '" + generoid + "',
    '" + editoraid + "',
    '"+exemplar+"',
    '" + status + "');

--Inserir dentro da tabela tb_emp_devol que um usuario acabou pegando um livro emprestado, colocando o id do livro, id do usuario e a data atual 

INSERT INTO tb_emp_devol( id_livro, id_usuario, dt_emprest) VALUES( '" + idlivro + "', '" + userid + "', current_date());
--ira trazer o id do usuario de acordo com o seu rm
SELECT id_usuario from TB_USUARIOS WHERE NR_RM_RA  = " + "'" + txtRm.Text + "'" + ";

--Inner join com as tabelas tb_livros,tb_emp_devol e TB_USUARIOS. E então puxando os seguintes valores de acordo com o RM do usuario para mostrar se existe algo pedente 
SELECT  
    LI.nr_Tombo   AS 'Nº Tombo',
    AU.nr_rm_ra   AS 'RM do Usuario', 
    MO.dt_Emprest AS 'Data de Empréstimo',
    MO.dt_devol   AS 'Data de devolução'
FROM tb_emp_devol AS MO
INNER JOIN tb_livros AS LI ON (LI.id_livro = MO.id_livro)inner
JOIN tb_usuarios AS AU  ON (AU.id_usuario = MO.id_usuario)
WHERE AU.nr_RM_RA = "+txtRm.Text+" AND Isnull(dt_Devol);

--Caso o usuario tenha um livro emprestado e já tenha devolvido o livro, ira atualizar na tabela tb_emp_devol o dia que foi retornado o livro
update tb_emp_devol
SET dt_devol = current_date()
WHERE id_Usuario = " + userid + "
AND id_livro =" + idlivro + ";

--Ira atualizar a quantidade de exemplares disponiveis em caso de devolucao
update tb_exemplares set QT_DISP = QT_DISP +1 where id_exemplares = " + idexemplar + ";
--Atualiza a tabela tb_livros para disponivel para emprestimo um exemplar especifico
Update tb_livros set Status_Livro ='D' where id_exemplares = " + idexemplar + "


--Inserir o valor da multa em ocasioes onde o usuario tenha atrasado a devolucao do livro
INSERT INTO tb_vrmulta ( dt_inicio, vl_multa) VALUES ( current_date(), '" + txtmulta.Text + "');
--Selecionar a multa onde seja nulo a data final
select vl_multa from tb_vrmulta WHERE(ISNULL(dt_final) or dt_final= '0000-00-00')
--Atualizar a tabela tb_vrmulta onde esteja nulo a data final
UPDATE tb_vrmulta SET dt_final = current_date() WHERE (ISNULL(dt_final) OR dt_final = '0000-00-00');
--Insert dentro da tb_cobranca caso o usuario tenha atrasado a devolucao do livro e cobrando o seguinte valor de acordo com o valor da multa  
INSERT INTO tb_cobrança(id_registro,qt_Qtdias, vl_valorcobrado) VALUES ('" + idregistro + "','" + dias + "','" + valor.Replace(",", ".") + "');

--Inner join com as tabelas tb_livros,tb_autor,tb_genero,tb_editora. Podendo mostrar informações adicionais sobre o livro
SELECT  LI.nr_Tombo     AS 'Nº Tombo'
       ,LI.ds_NomeLivro AS 'Nome do Livro'
       ,LI.nr_AnoLivro  AS 'Ano do Livro'
       ,LI.Status_Livro AS 'Status do Livro'
       ,AU.ds_NomeAutor AS 'Nome do Autor'
       ,GE.ds_Genero    AS 'Gênero'
       ,ED.ds_NomeEditora 'Editora'
FROM tb_livros AS LI
INNER JOIN tb_autor AS AU
ON (AU.id_Autor = LI.id_AutorLivro)
INNER JOIN tb_genero AS GE
ON (GE.id_Genero = LI.id_GeneroLivro)
INNER JOIN tb_editora AS ED
ON (ED.id_Editora = LI.id_EditoraLivro)
ORDER BY LI.ds_NomeLivro;
        
--Este inner join é o mesmo que o anterior, entretanto ele faz uma filtragem utilizando o comando like, podendo mostrar os livros de um autor especifico
SELECT  LI.nr_Tombo       AS 'Nº Tombo'
       ,LI.ds_NomeLivro   AS 'Nome do Livro'
       ,LI.nr_AnoLivro    AS 'Ano do Livro'
       ,LI.Status_Livro   AS 'Status do Livro'
       ,AU.ds_NomeAutor   AS 'Nome do Autor'
       ,GE.ds_Genero      AS 'Gênero'
       ,ED.ds_NomeEditora AS 'Editora'
    FROM tb_livros AS LI
    INNER JOIN tb_autor AS AU ON (AU.id_Autor = LI.id_AutorLivro)
    INNER JOIN tb_genero AS GE ON (GE.id_Genero = LI.id_GeneroLivro)
    INNER JOIN tb_editora AS ED ON (ED.id_Editora = LI.id_EditoraLivro)
    WHERE AU.ds_nomeautor like'" + Usuario + "%'
    ORDER BY LI.ds_NomeLivro ASC;


