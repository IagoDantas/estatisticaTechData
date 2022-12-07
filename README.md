# estatisticaTechData
Projeto de software de controle estatístico descritivo para controle da produção.

![image](https://user-images.githubusercontent.com/82843173/206286288-896cc85d-3e66-4fe2-ae3d-df0b13884d4d.png)


## Como rodar?

```bash
# Como clonar o projeto
git clone git@github.com:IagoDantas/estatisticaTechData.git
```

### Como abrir o projeto?

Ao clonar o projeto, abrir o arquivo de solução chamado: estatisticaTechData.SLN

![image](https://user-images.githubusercontent.com/82843173/206286579-e7ae9dfe-67be-4122-a9d2-2c2cb1f2a293.png)

### Como conectar ao banco de dados

Para rodar o projeto é necessário conectar-se ao banco de dados, para isto clique na aba de "Ferramentas", e em seguida, "Conectar-se ao banco de dados".

![image](https://user-images.githubusercontent.com/82843173/206287229-090951ff-0e0f-4f5c-b0e7-7d3b0a1b81c3.png)


Aparecerá uma pequena página chamada "Adicionar Conexão"

![image](https://user-images.githubusercontent.com/82843173/206286975-584845fc-eace-40b8-b72e-b1f1cb6fcb28.png)

Nesta página só alteraremos a parte de "Nome do arquivo do banco de dados", pois o banco que utilizaremos é do Access, e para isso, é so clicar no botão "Procurar" e selecionar o banco de dados "estatisticaTechData" com a extensão "Microsoft Access", localizado na própria pasta do projeto, onde fica a solução e a fonte.

![image](https://user-images.githubusercontent.com/82843173/206288744-a8c2bfb5-76a3-4ceb-a75a-e926d9f09ece.png)

Ao clicar selecionar o banco de dados e clicar em abrir será mostrado um caminho, desde a raiz até o banco de dados.

![image](https://user-images.githubusercontent.com/82843173/206288876-473cea54-a6d5-4d58-9834-47582c72055e.png)
<br/>
![image](https://user-images.githubusercontent.com/82843173/206288921-2c1da3e6-e473-4825-b335-25e64e9a7680.png)

Depois é so testar a conexão com este botão abaixo:

![image](https://user-images.githubusercontent.com/82843173/206289351-eb04a6ef-5aac-435b-a993-88afa30a22f7.png)

Se for bem-sucedida, aparecerá uma MessageBox com este aviso:

![image](https://user-images.githubusercontent.com/82843173/206289193-9aa6cbf0-b855-4258-b4cd-744778a59e0c.png)

Se tudo der certo, só vamos precisar pegar a string de conexão, clicando no botão "Avançado..." e na parte inferior, aparece uma string e copiaremos desde "Provider", até o final.

![image](https://user-images.githubusercontent.com/82843173/206291014-119b2722-e908-437e-9b0b-5088c14054db.png)

Após copiar, é só dar OK e OK, e já estaremos com o banco no projeto.

![image](https://user-images.githubusercontent.com/82843173/206291432-e6e54bca-2591-4631-9da0-0cb5d6dbcc9b.png)

Agora, é alterar as connectionString no arquivo "App.Config"

![image](https://user-images.githubusercontent.com/82843173/206291961-ef5e5a5a-c68e-4139-a34f-40cf9065f328.png)

E no arquivo Cadastro.cs, alterar dentro do click do botão e dentro do else, alterar a stringconn

![image](https://user-images.githubusercontent.com/82843173/206292407-0b8563f4-0564-4415-a283-bc0043ecee6e.png)

Após, é so instalar as fontes Poppins localizada na pasta do projeto, clicando na pasta "POPPINS

![image](https://user-images.githubusercontent.com/82843173/206292582-ba928dd4-1959-4e61-be78-45caf748a6b7.png)

E instalando-as, selecionando, e com o botão direito do mouse, e clicando e Instalar.

 ![image](https://user-images.githubusercontent.com/82843173/206293096-3e1bf312-c482-457d-8cfd-07a6f2813c1f.png)
<br/>
![image](https://user-images.githubusercontent.com/82843173/206293161-17d90e11-bb15-4e43-b245-19adad008f69.png)

Depois disso é so voltar no projeto e apertar F5, e rodar o projeto.
