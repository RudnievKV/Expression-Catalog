using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
namespace Cursach
{
    public partial class Catalog : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb;";
        public OleDbConnection myConnection;
        public List<Exp> Phrase { get; set; }
        public List<Exp> PhraseSearch  { get; set; }
        public Exp statement=new Exp();
        public bool checkAuthor;
        public bool checkSource;
        public bool checkTheme;
        public string AuthorValue;
        public string SourceValue;
        public string ThemeValue;
        public List<Exp> InitialPhrase { get; set; }
        public Catalog()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            Phrase = GetPhrase();
            InitialPhrase = GetPhrase();
        }
        public List<Exp> GetPhrase()
        {
            string query_id = "SELECT exp_Expression, exp_Type, exp_Author, exp_Source, exp_Theme FROM Popular_expressions ORDER BY exp_id";
            OleDbCommand command = new OleDbCommand(query_id, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            var list = new List<Exp>();
            while (reader.Read())
            {
                list.Add(new Exp() 
                {
                    Expression = reader[0].ToString(),
                    Type = reader[1].ToString(),
                    Author = reader[2].ToString(),
                    Source = reader[3].ToString(),
                    Theme = reader[4].ToString(),
                });
            }
            reader.Close();
            return list;
        }
        public void RefreshGrid()
        {
            dataGridView.Rows.Clear();
            foreach (Exp i in Phrase)
            {
                dataGridView.Rows.Add(i.Expression, i.Type, i.Author, i.Source, i.Theme);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            dataGridView.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddorChange f2 = new AddorChange();
            f2.Phrase = Phrase;
            dataGridView.ClearSelection();
            f2.ShowDialog();
            RefreshGrid();
            dataGridView.ClearSelection();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                AddorChange f2 = new AddorChange(Phrase[dataGridView.SelectedCells[0].RowIndex], dataGridView.SelectedCells[0].RowIndex);
                f2.Phrase = Phrase;
                f2.q = dataGridView.SelectedCells[0].RowIndex;
                f2.ShowDialog();
                RefreshGrid();
                dataGridView.ClearSelection();
            }
            catch
            {
                MessageBox.Show("Пожалуйста, выберите строку перед изменением!");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int i = dataGridView.SelectedCells[0].RowIndex;
                Phrase.RemoveAt(i);
                RefreshGrid();
                dataGridView.ClearSelection();
            }
            catch
            {
                MessageBox.Show("Пожалуйста, выберите строку перед удалением!");
            }
        }
        private void btnCreateCriterior_Click(object sender, EventArgs e)
        {
            List<string> authors = new List<string>();
            List<string> sources = new List<string>();
            foreach (Exp i in Phrase) 
            {
                authors.Add(i.Author);
                sources.Add(i.Source);
            }
            Search f = new Search(true, authors, sources);
            f.Owner = this;
            f.Phrase = Phrase;
            f.Text = "Составить критерий поиска";
            f.ShowDialog();
            PhraseSearch = f.PhraseSearch;
            checkAuthor = f.checkBox1.Checked;
            AuthorValue = f.cmbSearchAuthor.Text;
            checkSource = f.checkBox2.Checked;
            SourceValue = f.cmbSearchSource.Text;
            checkTheme = f.checkBox3.Checked;
            ThemeValue = f.tbSearchTheme.Text;
            dvgSearch.Rows.Clear();
            foreach(Exp i in PhraseSearch)
            {
                dvgSearch.Rows.Add(i.Expression, i.Type, i.Author, i.Source, i.Theme);
            }
            dvgSearch.ClearSelection();

        }
        private void Main_HelpRequested_1(object sender, HelpEventArgs hlpevent)
        {
            using (var Instructions = new Instructions())
                Instructions.ShowDialog();

        }

        private void btnChangeCriteria_Click(object sender, EventArgs e)
        {
            if (PhraseSearch == null)
            {
                MessageBox.Show("Пожалуйста, составьте критерий перед его изменением!");
            }
            else
            {
                List<string> authors = new List<string>();
                List<string> sources = new List<string>();
                foreach (Exp i in Phrase)
                {
                    authors.Add(i.Author);
                    sources.Add(i.Source);
                }
                Search f = new Search(true, authors, sources);
                f.Owner = this;
                f.Phrase = Phrase;
                f.Text = "Изменить критерий поиска";

                f.checkBox1.Checked = checkAuthor;
                f.cmbSearchAuthor.Text = AuthorValue;
                f.checkBox2.Checked = checkSource;
                f.cmbSearchSource.Text = SourceValue;
                f.checkBox3.Checked = checkTheme;
                f.tbSearchTheme.Text = ThemeValue;

                f.ShowDialog();

                PhraseSearch = f.PhraseSearch;
                checkAuthor = f.checkBox1.Checked;
                AuthorValue = f.cmbSearchAuthor.Text;
                checkSource = f.checkBox2.Checked;
                SourceValue = f.cmbSearchSource.Text;
                checkTheme = f.checkBox3.Checked;
                ThemeValue = f.tbSearchTheme.Text;



                dvgSearch.Rows.Clear();
                foreach (Exp i in PhraseSearch)
                {
                    dvgSearch.Rows.Add(i.Expression, i.Type, i.Author, i.Source, i.Theme);
                }
                dvgSearch.ClearSelection();
            }
        }

        private void btnWritetxt_Click(object sender, EventArgs e)
        {
            File.Delete(@"databaseStatementsReport.txt");
            StreamWriter sw = new StreamWriter(@"databaseStatementsReport.txt", true, Encoding.UTF8);
            foreach(Exp i in PhraseSearch)
            {
                sw.WriteLine("Афоризм:\t" + i.Expression);
                sw.WriteLine("Тип:     \t" + i.Type);
                sw.WriteLine("Автор:   \t" + i.Author);
                sw.WriteLine("Источник:\t" + i.Source);
                sw.WriteLine("Тема:    \t" + i.Theme);
                sw.WriteLine();
            }
            sw.Close();
            MessageBox.Show("Файл успешно сохранён!", "");
            dvgSearch.ClearSelection();

        }
        private void DeleteAllData()
        {
            string query = "DELETE FROM Popular_expressions";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
        }
        private bool Equality()
        {
            for (int i = 0; i < Phrase.Count; i++)
            {
                string k1 = Phrase[i].Expression;
                string k2 = Phrase[i].Type;
                string k3 = Phrase[i].Author;
                string k4 = Phrase[i].Source;
                string k5 = Phrase[i].Theme;

                string q1 = InitialPhrase[i].Expression;
                string q2 = InitialPhrase[i].Type;
                string q3 = InitialPhrase[i].Author;
                string q4 = InitialPhrase[i].Source;
                string q5 = InitialPhrase[i].Theme;
                if (k1 != q1 ||
                    k2 != q2 ||
                    k3 != q3 ||
                    k4 != q4 ||
                    k5 != q5)
                {
                    return false;
                }
            }
            return true ;
        }
        private void InsertAllNewData(Exp i)
        {
            string query = $"INSERT INTO Popular_expressions (exp_Expression, exp_Type, exp_Author, exp_Source, exp_Theme) VALUES ('{i.Expression}','{i.Type}','{i.Author}','{i.Source}','{i.Theme}')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (InitialPhrase.Count != Phrase.Count)
            {
                DialogResult dialogResult1 = MessageBox.Show("Сохранить изменения в базу данных?", "Выход", MessageBoxButtons.YesNo);
                if (dialogResult1 == DialogResult.Yes)
                {
                    DeleteAllData();
                    foreach (Exp i in Phrase)
                        InsertAllNewData(i);
                }
            }
            else
            {
                if (!Equality())
                {
                    DialogResult dialogResult1 = MessageBox.Show("Сохранить изменения в базу данных?", "Выход", MessageBoxButtons.YesNo);
                    if (dialogResult1 == DialogResult.Yes)
                    {
                        DeleteAllData();
                        foreach (Exp i in Phrase)
                            InsertAllNewData(i);
                    }
                }

            }
            myConnection.Close();
        }
    }
}
