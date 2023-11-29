using System.Data.SqlClient;

namespace WinFormYieldReturnApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //PopulateListFromDb();

            PopulateListWithFileNames();
        }

        private void PopulateListWithFileNames()
        {

            foreach (string fileName in GetFileNames("C:\\temp"))
            {
                listBox1.Items.Add(fileName);
            }
        }

        private async void PopulateListFromDb()
        {

            await foreach (string orgName in GetOrganizationNames())
            {
                listBox1.Items.Add(orgName);
            }
        }
        private IEnumerable<string> GetFileNames(string directoryPath)
        {
            // Ensure the directory exists
            if (Directory.Exists(directoryPath))
            {
                // Enumerate files in the directory
                foreach (string filePath in Directory.EnumerateFiles(directoryPath))
                {
                    // listBox1.Items.Add(Path.GetFileName(filePath));
                    yield return Path.GetFileName(filePath);
                }
            }
            else
            {
                yield return "Directory not found";
            }
        }


         async IAsyncEnumerable<string> GetOrganizationNames()
        {
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
    }
}