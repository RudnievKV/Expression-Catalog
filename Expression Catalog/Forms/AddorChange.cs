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
namespace Cursach
{
    public partial class AddorChange : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb;";

        public OleDbConnection myConnection;
        private string mistakes = "";
        private Exp ExpressionToChange;
        private Exp statement;
        private bool isChange = false;
        public int q;
        public AddorChange()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }


        public AddorChange( Exp ExpressionToChange,int q)
        {
            InitializeComponent();
            Text = "Изменить";
            btnAddChange.Text = "Изменить";
            isChange = true;
            this.ExpressionToChange = ExpressionToChange;
            FillData();
        }
        
        private void FillData()
        {
            txtExp.Text = ExpressionToChange.Expression;
            txtType.Text = ExpressionToChange.Type;
            txtAuthor.Text = ExpressionToChange.Author;
            txtSource.Text = ExpressionToChange.Source;
            txtTheme.Text = ExpressionToChange.Theme;
        }
        public List<Exp> Phrase
        {
            get;
            set;
        }
        private void txtExp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b' && l != '-' && l != ' ' && l != ',' && l != '.' && l != '\"' && l != '!' && l != '?' || l == '\\')
                e.Handled = true;
        }

        private void txtType_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b' && l != '-')
                e.Handled = true;
        }

        private void txtAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b' && l != '-' && l != ' ')
                e.Handled = true;
        }

        private void txtSource_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b' && l != '-' && l != ' ')
                e.Handled = true;
        }

        private void txtTheme_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b' && l != '-' && l != ' ')
                e.Handled = true;
        }
        private void Add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void ReadData()
        {
            statement = new Exp();
            
            statement.Expression = txtExp.Text.Trim();
            statement.Type = txtType.Text.Trim();
            statement.Author = txtAuthor.Text.Trim();
            statement.Source = txtSource.Text.Trim();
            statement.Theme = txtTheme.Text.Trim();
            
        }
        private bool Duplicates()
        {
            foreach (Exp i in Phrase)
            {
                if (statement.Expression == i.Expression &&
                    statement.Type == i.Type &&
                    statement.Author == i.Author &&
                    statement.Source == i.Source &&
                    statement.Theme == i.Theme)
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckData()
            {
                if (txtExp.Text.Trim().Length <= 3)
                    mistakes += "Строка \"Крылатое высказывание\" должна содержать больше трех символа\n";
                if (txtType.Text.Trim().Length <= 3)
                    mistakes += "Строка \"Тип\" должна содержать больше трех символа\n";
                if (txtAuthor.Text.Trim().Length <= 3)
                    mistakes += "Строка \"Автор\" должна содержать больше трех символа\n";
                if (txtSource.Text.Trim().Length <= 4)
                    mistakes += "Строка \"Источник\" должна содержать больше четырех символа\n";
                if (txtTheme.Text.Trim().Length <= 3)
                    mistakes += "Строка \"Тема\" должна содержать больше трех символа\n";
                return txtExp.Text.Trim().Length > 3 &&
                   txtType.Text.Trim().Length > 3 &&
                   txtAuthor.Text.Trim().Length > 3 &&
                   txtSource.Text.Trim().Length > 4 &&
                   txtTheme.Text.Trim().Length > 3;
            }
            private void button1_Click(object sender, EventArgs e)
            {
                
                if (!CheckData())
                {
                    MessageBox.Show(mistakes, "Ошибка", MessageBoxButtons.OK);
                    mistakes = "";
                    return;
                }
                ReadData();
            
                if (isChange)
                {
                    if (Duplicates())
                    {
                        MessageBox.Show("Такое выражение уже существует", "Ошибка", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        txtExp.TabStop = false;
                        Phrase[q] = statement;
                    }
                    
                }
                else
                {
                    if (Duplicates())
                    {
                        MessageBox.Show("Такое выражение уже существует", "Ошибка", MessageBoxButtons.OK);
                        return;
                    }
                    else
                        Phrase.Add(new Exp()
                        {
                            Expression = txtExp.Text.Trim(),
                            Type = txtType.Text.Trim(),
                            Author = txtAuthor.Text.Trim(),
                            Source = txtSource.Text.Trim(),
                            Theme = txtTheme.Text.Trim(),
                        });
                }
                Close();
            }

            private void Add_Load(object sender, EventArgs e)
            {

            }

            private void Add_FormClosing(object sender, FormClosingEventArgs e)
            {

            }
        }
    }

