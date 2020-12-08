CREATE DATABASE AUE_SOFTWARE;

CREATE TABLE TB_AUE_SOFTWARE
(NOME VARCHAR(40),
SEXO VARCHAR(10),
DATA_ DATE,
CIDADE VARCHAR(40),
CODCONTATO int auto_increment,
PRIMARY KEY(CODCONTATO));

SELECT * FROM tb_aue_software;

select CIDADE, count(CODCONTATO) as'quantidade de contatos por cidade' from tb_aue_software group by CIDADE;

select CIDADE, DATE_FORMAT(Data_, '%m-%Y') as 'mês e ano', COUNT(CODCONTATO) as 'contatos por mês'from tb_aue_software 
GROUP BY  CIDADE, monthname(Data_), year(data_) order by DATA_;

select count(CODCONTATO) as 'quantidade total de contatos' from tb_aue_software;
