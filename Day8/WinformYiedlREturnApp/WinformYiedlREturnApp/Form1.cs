using System.Data.SqlClient;

namespace WinformYiedlREturnApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //PopluateListBoxWithFileNames();

            PoplulateListBoxWithOrganizationNames();
        }

        private async void PoplulateListBoxWithOrganizationNames()
        {
          await  foreach (var name in GetOrganizationNames()) { 
               listBox1.Items.Add(name);
            }
        }


        private async IAsyncEnumerable<string> GetOrganizationNames() {

            using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=MyOrgnization;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true"))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("SELECT name FROM Organizations", connection))
                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {

                        yield return reader.GetString(0);
                    }
                }
            }


        }

        private void PopluateListBoxWithFileNames()
        {
            foreach (string fileName in GetFileNames("C:\\Windows\\System32"))
            {
                listBox1.Items.Add(fileName);
            }
        }


        private IEnumerable<string> GetFileNames(string directoryPath)
        {

            if (Directory.Exists(directoryPath))
            {
                foreach (string filePath in 
                    Directory.EnumerateFiles(directoryPath))
                {
                    yield return Path.GetFileName(filePath);
                }
            }
        }
    }
}