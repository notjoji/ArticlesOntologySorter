using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ArticlesOntologySorter
{
    public partial class MainForm : Form
    {
        string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        List<Article> articles = new List<Article>();
        Onto ontology = null;
        int[,] P;

        public MainForm()
        {
            InitializeComponent();
            loadOntologyBtn.Enabled = false;
            arrangeArticlesBtn.Enabled = false;
            openArticle.InitialDirectory = projectDirectory;
            openOntology.InitialDirectory = projectDirectory;
            betaCombo.Items.AddRange(new string[] { "1", "2", "5", "10" });
            betaCombo.SelectedIndex = 0;
            betaCombo.Enabled = false;
            nCombo.Enabled = false;
            connOntosCombo.Items.AddRange(new string[] { "3", "5", "10" });
            connOntosCombo.SelectedIndex = 0;
        }

        private string getBibtexAttribute(string str, string attribute, ref int index)
        {
            string begin = attribute + "={";
            int begin_index = str.IndexOf(begin, index);
            int end_index = str.IndexOf("}", begin_index + begin.Length);
            index = end_index + 1;
            return str.Substring(begin_index + begin.Length, end_index - (begin_index + begin.Length));
        }

        private void updateDataGridView(bool showScores)
        {
            var columns = from article in articles
                          select new
                          {
                              No = article.id,
                              Название = article.title,
                              Авторы = article.authors,
                              Score = article.score.ToString("#.##")
                          };
            articlesDGV.Columns.Clear();
            articlesDGV.DataSource = columns.ToList();
            articlesDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            articlesDGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            articlesDGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            articlesDGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            if (!showScores)
            {
                articlesDGV.Columns[3].Visible = false;
            }
        }

        private void loadArticlesBtn_Click(object sender, EventArgs e)
        {
            if (openArticle.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in openArticle.FileNames)
                {
                    if (Path.GetExtension(filename) != ".bib")
                    {
                        MessageBox.Show("Некорректное расширение одного из файлов (должно быть .bib)!");
                        return;
                    }
                }
                try
                {
                    int id = 1;
                    foreach (string filename in openArticle.FileNames)
                    {
                        using (FileStream fstream = File.OpenRead(filename))
                        {
                            byte[] array = new byte[fstream.Length];
                            fstream.Read(array, 0, array.Length);
                            string text = Encoding.Default.GetString(array);
                            int index = 0;
                            while (true)
                            {
                                string authors = getBibtexAttribute(text, "author", ref index);
                                string annotation = getBibtexAttribute(text, "abstract", ref index);
                                string source = getBibtexAttribute(text, "journal", ref index);
                                string keyWords = getBibtexAttribute(text, "keywords", ref index);
                                string title = getBibtexAttribute(text, "title", ref index);
                                string year = getBibtexAttribute(text, "year", ref index);
                                Article new_article = new Article(id, authors, title, annotation, source, year, keyWords);
                                if (!articles.Contains(new_article))
                                {
                                    articles.Add(new_article);
                                    id++;
                                }
                                if (text.IndexOf("author={", index) == -1)
                                {
                                    break;
                                }
                            }
                        }
                    }
                    updateDataGridView(false);
                    loadOntologyBtn.Enabled = true;
                    loadArticlesBtn.Enabled = false;
                    connOntosCombo.Items.Add(articles.Count);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникла ошибка при считывании файла со статьями!");
                }
            }
        }

        private void countOntologyPMatrix()
        {
            int n = ontology.nodes.Count;
            bool[,] G = new bool[n, n];
            int rn = ontology.relations.Count;
            for (int i = 0; i < rn; i++)
            {
                int s_i = ontology.nodes.FindIndex(x => x.id == ontology.relations[i].source_node_id);
                int d_i = ontology.nodes.FindIndex(x => x.id == ontology.relations[i].destination_node_id);
                G[s_i, d_i] = G[d_i, s_i] = true;
            }
            P = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    P[i, j] = P[j, i] = wayCount(i, j, G, n);
                }
            }
            int max_P = P.Cast<int>().Max();
            for (int i=1; i<=max_P; i++)
            {
                nCombo.Items.Add(i);
            }
            nCombo.SelectedIndex = 0;
        }

        private void loadOntologyBtn_Click(object sender, EventArgs e)
        {
            if (openOntology.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openOntology.FileName) != ".ont")
                {
                    MessageBox.Show("Некорректное расшиерение файла (должно быть .ont)!");
                }
                else
                {
                    try
                    {
                        using (StreamReader file = File.OpenText(openOntology.FileName))
                        {
                            ontology = JsonConvert.DeserializeObject<Onto>(file.ReadToEnd());
                            countOntologyPMatrix();
                            arrangeArticlesBtn.Enabled = true;
                            betaCombo.Enabled = true;
                            nCombo.Enabled = true;
                            loadOntologyBtn.Enabled = false;
                            MessageBox.Show("Онтология успешно загружена!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Возникла ошибка при считывании файла онтологии!");
                    }
                }
            }
        }

        private void articlesDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (articlesDGV.SelectedRows.Count == 0)
                return;
            var row = articlesDGV.SelectedRows[0];
            if (row == null)
                return;
            int id = Convert.ToInt32(row.Cells[0].Value);
            Article a = articles.Find(x => x.id == id);
            authorsRTB.Text = a.authors;
            titleRTB.Text = a.title;
            annotationRTB.Text = a.annotation;
            sourceRTB.Text = a.source;
            yearRTB.Text = a.year;
            keyWordsRTB.Text = a.keyWords;
            connSentencesRTB.Text = a.connSentences;
        }

        private void arrangeArticlesBtn_Click(object sender, EventArgs e)
        {
            arrangeArticlesBtn.Enabled = false;
            int n = ontology.nodes.Count;
            int an = articles.Count;
            if (an == 0 || n == 0 || ontology.relations.Count == 0)
            {
                arrangeArticlesBtn.Enabled = false;
                betaCombo.Enabled = false;
                nCombo.Enabled = false;
                loadOntologyBtn.Enabled = true;
                MessageBox.Show("Реранжирование статей невозможно!");
                return;
            }
            NodeAndSentences[] sentences_including_node = new NodeAndSentences[n];
            for (int i=0; i<n; i++)
            {
                sentences_including_node[i] = new NodeAndSentences(ontology.nodes[i].name);
            }
            for (int i=0; i<an; i++) 
            {
                Article a = articles[i];
                string common = a.title + (!String.IsNullOrEmpty(a.keyWords) ? (". " + a.keyWords) : "") +
                                          (!String.IsNullOrEmpty(a.annotation) ? (". " + a.annotation) : "");
                List<string> sentences = Regex.Split(common, @"[.!?]").ToList().ConvertAll(x => x.Trim());
                List<string> new_sentences = sentences.ConvertAll(s => s.ToLower()).ConvertAll(s => Regex.Replace(s, @"[,:;()]", " ")).ConvertAll(s => " " + s + " ");
                for (int m=0; m<sentences.Count; m++)
                {
                    for (int j=0; j<n; j++)
                    {
                        if (new_sentences[m].Contains(" " + ontology.nodes[j].name + " ") || new_sentences[m].Contains(" " + ontology.nodes[j].name + "s "))
                        {
                            sentences_including_node[j].addSentence(sentences[m], new_sentences[m], i);
                        }
                    }
                }
            }
            int[,] E = new int[n, n];
            for (int i=0; i<n; i++)
            {
                for (int j=0; j<i+1; j++)
                {
                    if (i == j)
                    {
                        continue;
                    } else
                    {
                        if (sentences_including_node[i].sentences.Count == 0 || sentences_including_node[j].sentences.Count == 0)
                        {
                            continue;
                        } else
                        {
                            List<(string, string, int)> s_i = sentences_including_node[i].sortedSentences();
                            List<(string, string, int)> s_j = sentences_including_node[j].sortedSentences();
                            if (s_j.Count > s_i.Count)
                            {
                                List<(string, string, int)> temp = s_i;
                                s_i = s_j;
                                s_j = temp;
                            }
                            int y = 0;
                            for (int m=0; m<s_i.Count; m++)
                            {
                                if (s_i[m].Item3 > s_j[y].Item3)
                                {
                                    continue;
                                }
                                else if (s_i[m].Item3 < s_j[y].Item3)
                                {
                                    while (y != s_j.Count && s_i[m].Item3 < s_j[y].Item3)
                                    {
                                        y++;
                                    }
                                    if (s_j.Count == y)
                                    {
                                        break;
                                    }
                                }
                                if (s_i[m].Item1.Equals(s_j[y].Item1))
                                {
                                    E[i, j] += 1;
                                    E[j, i] += 1;
                                    y += 1;
                                    if (s_j.Count == y)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            int beta = Convert.ToInt32(betaCombo.SelectedItem);
            int[] b_x = new int[n];
            for (int i=0; i<n; i++)
            {
                for (int j=0; j<n; j++)
                {
                    if (E[i, j] >= beta)
                    {
                        b_x[i] += 1;
                    }
                }
            }
            int n_value = Convert.ToInt32(nCombo.SelectedItem);
            double[,] S = new double[n, n];
            for (int i=0; i<n; i++)
            {
                for (int j=0; j<n; j++)
                {
                    int divider = b_x[i] + b_x[j];
                    if (divider != 0)
                    {
                        double m = P[i, j] <= n_value ? Math.Sqrt(P[i, j]) : 1;
                        S[i, j] = m * (2 * (b_x[i] / (double)an) * E[i, j]) / divider;
                    }
                }
            }
            double min_S = S.Cast<double>().Min();
            double max_s = S.Cast<double>().Max();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    S[i, j] = (S[i, j] - min_S) / max_s;
                }
            }
            double[] node_weights = new double[n];
            for (int i=0; i<n; i++)
            {
                for (int j=0; j<n; j++)
                {
                    node_weights[i] += S[i, j];
                }
            }
            // index, score, connSentences, nodeIds
            (int, double, List<string>, List<string>)[] article_info = new (int, double, List<string>, List<string>)[an];
            for (int i = 0; i < an; i++)
            {
                article_info[i] = ((i + 1), 0, new List<string>(), new List<string>());
            }
            for (int j = 0; j < n; j++)
            {
                foreach ((string, string, int) tuple in sentences_including_node[j].sentences)
                {
                    article_info[tuple.Item3].Item2 += node_weights[j];
                    if (!article_info[tuple.Item3].Item3.Contains(tuple.Item1))
                        article_info[tuple.Item3].Item3.Add(tuple.Item1);
                    if (!article_info[tuple.Item3].Item4.Contains(ontology.nodes[j].id))
                        article_info[tuple.Item3].Item4.Add(ontology.nodes[j].id);
                }
            }
            List<(int, double, List<string>, List<string>) > aw_list = new List<(int, double, List<string>, List<string>)>(article_info);
            aw_list.Sort((x, y) => y.Item2.CompareTo(x.Item2));
            List<Article> new_articles = new List<Article>();
            for (int i=0; i<an; i++)
            {
                new_articles.Add(articles.Find(x => x.id == aw_list[i].Item1));
            }
            for (int i = 0; i < an; i++)
            {
                new_articles[i].setId(i + 1);
                new_articles[i].setScore(aw_list[i].Item2);
                new_articles[i].setConnSentences(aw_list[i].Item3);
            }
            List<string>[] nodeIds = aw_list.ConvertAll(x => x.Item4).ToArray();
            string[] articleTitles = new_articles.ConvertAll(x => x.title).ToArray();
            List<string>[] connSentences = aw_list.ConvertAll(x => x.Item3).ToArray();
            articles = new_articles;
            updateDataGridView(true);
            int conn_ontos = Convert.ToInt32(connOntosCombo.SelectedItem);
            makeMostValuableOntologies(conn_ontos, nodeIds, connSentences, articleTitles);
            arrangeArticlesBtn.Enabled = true;
        }

        private void makeMostValuableOntologies(int n, List<string>[] nodeIds, List<string>[] connSentences, string[] articleTitles)
        {
            string ontology_path = projectDirectory + @"\Ontologies";
            if (!Directory.Exists(ontology_path))
                Directory.CreateDirectory(ontology_path);
            string texts_path = projectDirectory + @"\Texts";
            if (!Directory.Exists(texts_path))
                Directory.CreateDirectory(texts_path);
            Node[] n_a = new Node[ontology.nodes.Count];
            ontology.nodes.CopyTo(n_a);
            Relation[] r_a = new Relation[ontology.relations.Count];
            ontology.relations.CopyTo(r_a);
            JsonSerializer serializer = new JsonSerializer();
            for (int i = 0; i < n; i++)
            {
                string title = articleTitles[i].Trim();
                title = Regex.Replace(title, @"[\/:*?<>|+]", "");
                if (title.Length > 155)
                {
                    title = title.Substring(0, 155) + " (more)";
                }
                Onto copy = new Onto();
                copy.last_id = ontology.last_id;
                copy.namespaces = ontology.namespaces;
                copy.visualize_ont_path = ontology.visualize_ont_path;
                copy.nodes = n_a.ToList();
                copy.relations = r_a.ToList();
                List<Node> ontologyNodes = copy.nodes.ToList();
                ontologyNodes.RemoveAll(x => !nodeIds[i].Contains(x.id));
                List<string> ontologyNodesIds = ontologyNodes.ConvertAll(x => x.id);
                List<Relation> ontologyRelations = copy.relations.ToList();
                ontologyRelations.RemoveAll(x => !ontologyNodesIds.Contains(x.destination_node_id) || !ontologyNodesIds.Contains(x.source_node_id));
                copy.nodes = ontologyNodes;
                copy.relations = ontologyRelations;
                string ontology_filename = ontology_path + @"\" + title + ".ont";
                using (StreamWriter sw = new StreamWriter(ontology_filename))
                {
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        serializer.Serialize(writer, copy);
                    }
                }
                string texts_filename = texts_path + @"\" + title + ".txt";
                using (StreamWriter sw = new StreamWriter(texts_filename, false, System.Text.Encoding.UTF8))
                {
                    foreach (string connSentence in connSentences[i])
                    {
                        sw.WriteLine(connSentence);
                    }
                }
            }
        }

        private int wayCount(int cur, int dest, bool[,] G, int n)
        {
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                if (i != cur && G[cur, i])
                {
                    List<int> way = new List<int>(){ cur };
                    res += recWay(way, i, dest, G, n);
                }
            }
            return res;
        }

        private int recWay(List<int> way, int cur, int dest, bool[,] G, int n)
        {
            if (cur == dest)
            {
                return 1;
            }
            if (way.Contains(cur))
            {
                return 0;
            }
            way.Add(cur);
            List<int> neighbors = new List<int>();
            for (int i=0; i<n; i++)
            {
                if (i != cur && G[cur, i] && !way.Contains(i))
                    neighbors.Add(i);
            }
            if (neighbors.Count == 0)
            {
                return 0;
            } else
            {
                int res = 0;
                foreach (int nb in neighbors)
                {
                    res += recWay(way, nb, dest, G, n);
                }
                return res;
            }
        }
    }
}
