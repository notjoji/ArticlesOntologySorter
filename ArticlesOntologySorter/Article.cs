using System.Collections.Generic;

namespace ArticlesOntologySorter
{
    public class Article
    {
        public int id;
        public double score;
        public string authors, title, annotation, source, year, keyWords, connSentences;

        public Article(int id, string authors, string title, string annotation, string source, string year, string keyWords)
        {
            this.id = id;
            this.authors = authors;
            this.title = title;
            this.annotation = annotation;
            this.source = source;
            this.year = year;
            this.keyWords = keyWords;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setScore(double score)
        {
            this.score = score;
        }

        public void setConnSentences(List<string> connSentencesList)
        {
            string connSentences = "";
            foreach (string cs in connSentencesList)
            {
                connSentences += cs + ". ";
            }
            this.connSentences = connSentences;
        }
    }
}
