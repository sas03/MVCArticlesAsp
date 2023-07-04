namespace ArticlesCRUD.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Contenu { get; set; }
        public Article(int id, string titre, string contenu)
        {
            Id = id;
            Titre = titre;
            Contenu = contenu;
        }
    }
}
