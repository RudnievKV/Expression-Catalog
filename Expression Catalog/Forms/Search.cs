using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursach
{
    public partial class Search : Form
    {
        // Переменная для хранения данных текущего выражения.
        public Exp statement;
        // Форма поиска
        bool isSearch = false;
        // Форма изменения
        bool isChange = false;
        Exp statementSearch;
        public Search(bool isSearch, List<string> listAuthors, List<string> listSourse)
        {
            InitializeComponent();
            this.isSearch = isSearch;
            foreach (string s in listAuthors)
                cmbSearchAuthor.Items.Add(s);
            foreach (string s in listSourse)
                cmbSearchSource.Items.Add(s);
        }
        public List<Exp> Phrase { get; set; }
        public List<Exp> PhraseSearch {get;set;}
        public void ReadDataSearch()
        {
            statement = new Exp();
            statement.Author = cmbSearchAuthor.Text.Trim();
            statement.Source = cmbSearchSource.Text.Trim();
            statement.Theme = tbSearchTheme.Text.Trim();
        }

        public void btnSearch_Click_Click(object sender, EventArgs e)
        {
            string criteria_Author = "";
            string criteria_Source = "";
            string criteria_Theme = "";
            PhraseSearch = new List<Exp>();
            var listq = new List<Exp>();
            statementSearch = new Exp();
            ReadDataSearch();
            if (isChange == true)
            {
                // ReadDataSearch();
                if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
                {
                    criteria_Author = cmbSearchAuthor.Text;
                    criteria_Source = cmbSearchSource.Text;
                    criteria_Theme = tbSearchTheme.Text;
                    foreach (Exp i in Phrase)
                    {
                        if (i.Author == criteria_Author && criteria_Source == i.Source && criteria_Theme == i.Theme)
                            PhraseSearch.Add(new Exp()
                            {
                                Expression = i.Expression,
                                Type = i.Type,
                                Author = i.Author,
                                Source = i.Source,
                                Theme = i.Theme,
                            });
                    }

                }
                else if (checkBox1.Checked && checkBox2.Checked)
                {
                    criteria_Author = cmbSearchAuthor.Text;
                    criteria_Source = cmbSearchSource.Text;
                    foreach (Exp i in Phrase)
                    {
                        if (i.Author == criteria_Author && criteria_Source == i.Source)
                            PhraseSearch.Add(new Exp()
                            {
                                Expression = i.Expression,
                                Type = i.Type,
                                Author = i.Author,
                                Source = i.Source,
                                Theme = i.Theme,
                            });
                    }
                }
                else if (checkBox2.Checked && checkBox3.Checked)
                {
                    criteria_Source = cmbSearchSource.Text;
                    criteria_Theme = tbSearchTheme.Text;
                    foreach (Exp i in Phrase)
                    {
                        if (criteria_Source == i.Source && criteria_Theme == i.Theme)
                            PhraseSearch.Add(new Exp()
                            {
                                Expression = i.Expression,
                                Type = i.Type,
                                Author = i.Author,
                                Source = i.Source,
                                Theme = i.Theme,
                            });
                    }
                }
                else if (checkBox1.Checked && checkBox3.Checked)
                {
                    criteria_Author = cmbSearchAuthor.Text;
                    criteria_Theme = tbSearchTheme.Text;
                    foreach (Exp i in Phrase)
                    {
                        if (i.Author == criteria_Author && criteria_Theme == i.Theme)
                            PhraseSearch.Add(new Exp()
                            {
                                Expression = i.Expression,
                                Type = i.Type,
                                Author = i.Author,
                                Source = i.Source,
                                Theme = i.Theme,
                            });
                    }
                }
                else if (checkBox1.Checked)
                {
                    criteria_Author = cmbSearchAuthor.Text;
                    foreach (Exp i in Phrase)
                    {
                        if (i.Author == criteria_Author)
                            PhraseSearch.Add(new Exp()
                            {
                                Expression = i.Expression,
                                Type = i.Type,
                                Author = i.Author,
                                Source = i.Source,
                                Theme = i.Theme,
                            });
                    }
                }
                else if (checkBox2.Checked)
                {
                    criteria_Source = cmbSearchSource.Text;
                    foreach (Exp i in Phrase)
                    {
                        if (criteria_Source == i.Source)
                            PhraseSearch.Add(new Exp()
                            {
                                Expression = i.Expression,
                                Type = i.Type,
                                Author = i.Author,
                                Source = i.Source,
                                Theme = i.Theme,
                            });
                    }
                }
                else if (checkBox3.Checked)
                {
                    criteria_Theme = tbSearchTheme.Text;
                    foreach (Exp i in Phrase)
                    {
                        if (criteria_Theme == i.Theme)
                            PhraseSearch.Add(new Exp()
                            {
                                Expression = i.Expression,
                                Type = i.Type,
                                Author = i.Author,
                                Source = i.Source,
                                Theme = i.Theme,
                            });
                    }
                }

                Close();
            }
            if (isSearch)
            {
                if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
                {
                    criteria_Author = cmbSearchAuthor.Text;
                    criteria_Source = cmbSearchSource.Text;
                    criteria_Theme = tbSearchTheme.Text;
                    foreach(Exp i in Phrase)
                    {
                        if (i.Author == criteria_Author && criteria_Source == i.Source && criteria_Theme == i.Theme)
                        PhraseSearch.Add(new Exp()
                        {
                            Expression = i.Expression,
                            Type = i.Type,
                            Author = i.Author,
                            Source = i.Source,
                            Theme = i.Theme,
                        });
                    }

                }
                else if (checkBox1.Checked && checkBox2.Checked)
                    {
                        criteria_Author = cmbSearchAuthor.Text;
                        criteria_Source = cmbSearchSource.Text;
                        foreach (Exp i in Phrase)
                        {
                            if (i.Author == criteria_Author && criteria_Source == i.Source)
                                PhraseSearch.Add(new Exp()
                                {
                                    Expression = i.Expression,
                                    Type = i.Type,
                                    Author = i.Author,
                                    Source = i.Source,
                                    Theme = i.Theme,
                                });
                        }
                    }
                else if (checkBox2.Checked && checkBox3.Checked)
                    {
                        criteria_Source = cmbSearchSource.Text;
                        criteria_Theme = tbSearchTheme.Text;
                        foreach (Exp i in Phrase)
                        {
                            if (criteria_Source == i.Source && criteria_Theme == i.Theme)
                                PhraseSearch.Add(new Exp()
                                {
                                    Expression = i.Expression,
                                    Type = i.Type,
                                    Author = i.Author,
                                    Source = i.Source,
                                    Theme = i.Theme,
                                });
                        }
                    }
                else if (checkBox1.Checked && checkBox3.Checked)
                    {
                        criteria_Author = cmbSearchAuthor.Text;
                        criteria_Theme = tbSearchTheme.Text;
                        foreach (Exp i in Phrase)
                        {
                            if (i.Author == criteria_Author && criteria_Theme == i.Theme)
                                PhraseSearch.Add(new Exp()
                                {
                                    Expression = i.Expression,
                                    Type = i.Type,
                                    Author = i.Author,
                                    Source = i.Source,
                                    Theme = i.Theme,
                                });
                        }
                    }
                else if (checkBox1.Checked)
                    {
                        criteria_Author = cmbSearchAuthor.Text;
                        foreach (Exp i in Phrase)
                        {
                            if (i.Author == criteria_Author)
                                PhraseSearch.Add(new Exp()
                                {
                                    Expression = i.Expression,
                                    Type = i.Type,
                                    Author = i.Author,
                                    Source = i.Source,
                                    Theme = i.Theme,
                                });
                        }
                    }
                else if (checkBox2.Checked)
                    {
                        criteria_Source = cmbSearchSource.Text;
                        foreach (Exp i in Phrase)
                        {
                            if (criteria_Source == i.Source)
                                PhraseSearch.Add(new Exp()
                                {
                                    Expression = i.Expression,
                                    Type = i.Type,
                                    Author = i.Author,
                                    Source = i.Source,
                                    Theme = i.Theme,
                                });
                        }
                    }
                else if (checkBox3.Checked)
                    {
                        criteria_Theme = tbSearchTheme.Text;
                        foreach (Exp i in Phrase)
                        {
                            if (criteria_Theme == i.Theme)
                                PhraseSearch.Add(new Exp()
                                {
                                    Expression = i.Expression,
                                    Type = i.Type,
                                    Author = i.Author,
                                    Source = i.Source,
                                    Theme = i.Theme,
                                });
                        }
                    }
            }
            criteria_Author = cmbSearchAuthor.Text;
            criteria_Source = cmbSearchSource.Text;
            criteria_Theme = tbSearchTheme.Text;

            Close();
            }

            


        

        private void Search_Load(object sender, EventArgs e)
        {


        }
        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
        private void tbSearchTheme_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b' && l != '-' && l != ' ')
                e.Handled = true;
        }

        private void cmbSearchAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b' && l != '-' && l != ' ')
                e.Handled = true;
        }

        private void cmbSearchSource_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b' && l != '-' && l != ' ')
                e.Handled = true;
        }

        private void tbSearchWorld_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b' && l != '-' && l != ' ')
                e.Handled = true;
        }

        private void gbMain_Enter(object sender, EventArgs e)
        {

        }
        // заблокировать кнопку закрыть
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
    }
}
