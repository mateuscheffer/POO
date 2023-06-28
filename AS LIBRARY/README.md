#POO
NOMES: MATEUS SCHEFFER RODRIGUES E LEONARDO MATOS DE SOUZA

instruções para instalação e execução do projeto
dotnet ef add initialMigration(nome da migration)
dotnet ef database update
dotnet build
dotnet run

A estrutura da API segue o padrão RESTful, onde cada controlador é responsável por manipular as operações CRUD relacionadas a cada entidade específica (autor, livro e usuário). O AutoMapper é usado para mapear entre os modelos de domínio (Author, Book, User) e os objetos de transferência de dados (DTOs) correspondentes (AuthorDTO, BookDTO, UserDTO).

A API interage com o banco de dados usando a classe DataContext, que herda da classe DbContext do Entity Framework Core. O banco de dados possui três conjuntos de entidades: Books, Authors e Users, que são mapeados para suas respectivas tabelas no banco de dados.

Funcionalidades:
GET: Retorna todos os usuários em formato de DTO (UserDTO) usando o método GetAll().
GET com um parâmetro de ID: Retorna um usuário específico em formato de DTO usando o método GetById(id).
POST: Cria um novo usuário usando um objeto UserDTO fornecido no corpo da solicitação.
PUT com um parâmetro de ID: Atualiza um usuário existente com base no ID fornecido e no objeto UserDTO fornecido no corpo da solicitação.
DELETE com um parâmetro de ID: Exclui um usuário com base no ID fornecido.

Solicitações HTTP
http://localhost:5016(essa foi a porta utilizada no nosso projeto)

Metodo GET: 
http://localhost/api/author
Retorna uma lista de todos os autores.

http://localhost/api/author/{id}
Retorna os detalhes do autor correspondente ao id informado.

Metodo POST:
http://localhost/api/author
Exemplo de como se popula(formato JSON):
{
  "name": "Nome do Autor"
}
Retorna os detalhes do autor recém-criado em formato JSON.

Metodo PUT:
http://localhost/api/author/{id}
Exemplo de como se popula(formato JSON):
{
  "name": "Novo Nome do Autor"
}
Retorna uma resposta vazia indicando que a atualização foi bem-sucedida.

Metodo DELETE:
http://localhost/api/author/{id}
Retorna uma resposta vazia indicando que a exclusão foi bem-sucedida.

