using System.Data;

namespace tugas_Desktop
{
    public partial class NoteTaker : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;
        public NoteTaker()
        {
            InitializeComponent();
        }

        private void NoteTaker_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            previousnotes.DataSource = notes;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if(editing)
            {
                notes.Rows[previousnotes.CurrentCell.RowIndex]["title"] = titlebox.Text;
                notes.Rows[previousnotes.CurrentCell.RowIndex]["title"] = notebox.Text;
            }
            else
            {
                notes.Rows.Add(titlebox.Text, notebox.Text);
            }
            titlebox.Text = "";
            notebox.Text = "";
            editing = false;
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
               try
            {
                notes.Rows[previousnotes.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex) { Console.WriteLine("Not a Valid not");  }
        }

        private void loadbutton_Click(object sender, EventArgs e)
        {
            titlebox.Text = notes.Rows[previousnotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            notebox.Text = notes.Rows[previousnotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;     
        }

        private void newbutton_Click(object sender, EventArgs e)
        {
            titlebox.Text = "";
            notebox.Text = "";
        }

        private void previousnotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            titlebox.Text = notes.Rows[previousnotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            notebox.Text = notes.Rows[previousnotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
    }
}