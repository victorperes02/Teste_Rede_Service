--============================================================================================
--============================================================================================
--NOME: João Victor dos Santos Peres
--DATA: 03/12/2022
--============================================================================================
--============================================================================================

--============================================================================================
--QUESTÃO 1 - Criar um select para listar todas as descrições (campo [descrição]) da tabela "Tabela" que estejam duplicadas, mostrando no select a descrição e a quantidade de registros duplicados
--============================================================================================

select descricao, count(*) as linhas_duplicadas from Tabela 
group by descricao
HAVING Count(*) > 1

--============================================================================================
--QUESTÃO 2 - Criar um select para listar os campos da tabela "Tabela" de todos os registros que estão na tabela “Tabela”, porém não estão na tabela "Tabela_esp" utilizando o campo [código] como chave
--============================================================================================

select codigo from Tabela t
WHERE NOT EXISTS (SELECT codigo FROM Tabela_esp te WHERE t.codigo = te.codigo) 

--============================================================================================
--QUESTÃO 3 - Criar um update para atualizar o campo OBS da tabela "Tabela" com o conteúdo "S" se o registro existir na tabela "Tabela_esp"
--============================================================================================
update Tabela set obs = 'S' FROM Tabela t WHERE EXISTS (SELECT codigo FROM Tabela_esp te WHERE t.codigo = te.codigo) 

--============================================================================================
--QUESTÃO 4 - Criar uma procedure de nome tst_sp_descricoes_duplicadas como dbo, que deverá receber um parâmetro chamado @descricao. Essa procedure deverá incluir em uma tabela temporária de nome Registros_duplicados todos os registros duplicados de uma determinada descrição e logo em seguida visualizá-los 
--============================================================================================
USE db_teste_sqlserver
GO
CREATE TABLE #resultados_procedure (descricao varchar(1))
GO
CREATE PROCEDURE tst_sp_descricoes_duplicadas 
@descricao varchar(10)
AS
SELECT count(*) as descricao
FROM Tabela 
WHERE  descricao = @descricao
group by descricao
HAVING Count(*) > 1
insert into #resultados_procedure(descricao)
select descricao FROM Tabela WHERE descricao = @descricao
GO
EXECUTE [tst_sp_descricoes_duplicadas] 'descricao'

--drop procedure [tst_sp_descricoes_duplicadas]

--============================================================================================
--QUESTÃO 5 - Criar uma trigger na tabela "Tabela" que inclua a situação anterior na tabela "Tabela_hist" toda vez que a tabela "Tabela" sofrer uma alteração ou exclusão 
--============================================================================================

--============================================================================================
--QUESTÃO 6 - Criar uma function de nome tst_fn_existecodigo que receba um parâmetro chamado @codigo. Essa função deverá ter um retorno do tipo bit e retornar 1 quando existir o código na tabela "Tabela" e 0 quando não existir 
--============================================================================================


--============================================================================================
--QUESTÃO 7 - Criar um script que crie uma tabela idêntica a tabela "Tabela" de nome "Tabela_espelho" caso ela não exista. Inclua nessa tabela o conteúdo da tabela "Tabela" de 1 em 1 registro (utilizando cursor) e executando um commit a cada 100 registros
--============================================================================================


--============================================================================================
--QUESTÃO 8 - Criar uma procedure de nome tst_sp_importa_arquivo como dbo, que deverá receber um parâmetro chamado @arquivo. Essa procedure deverá incluir na tabela ARQUIVO_TESTE o conteúdo do arquivo “arquivo_teste.txt”, localizado na sua pasta de teste, pelo comando bulk insert e logo depois visualizá-lo
--============================================================================================
USE db_teste_sqlserver
GO
CREATE PROCEDURE dbo.tst_sp_importa_arquivo --- Declarando o nome da procedure
@arquivo varchar(20)
AS
BULK INSERT ARQUIVO_TESTE
FROM 'C:\Users\victor.santos\Downloads\SQL Server\teste.txt' --Mudar local de busca do arquivo
SELECT linha_arquivo FROM ARQUIVO_TESTE
WHERE  linha_arquivo = @arquivo
GO
EXECUTE tst_sp_importa_arquivo 'testando'--Dado da variavel global @arquivos
