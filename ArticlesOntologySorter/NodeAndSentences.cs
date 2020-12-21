using System.Collections.Generic;

namespace ArticlesOntologySorter
{
    public class NodeAndSentences
    {
        public string node;
        public List<(string, string, int)> sentences;

        public NodeAndSentences(string node)
        {
            this.node = node;
            this.sentences = new List<(string, string, int)>();
        }

        public void addSentence(string old_value, string new_value, int source)
        {
            this.sentences.Add((old_value, new_value, source));
        }

        public List<(string, string, int)> sortedSentences()
        {
            List<(string, string, int)> sorted = sentences;
            sorted.Sort((x, y) => {
                int result = y.Item3.CompareTo(x.Item3);
                return result == 0 ? y.Item2.CompareTo(x.Item2) : result;
            });
            return sorted;
        }
    }
}
