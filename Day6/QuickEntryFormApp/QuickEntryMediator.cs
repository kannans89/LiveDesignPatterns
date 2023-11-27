using System;
using System.Windows.Forms;
using System.Linq;

public class QuickEntryMediator
{
    private TextBox txtEntry;
    private ListBox lstDetails;

    public QuickEntryMediator(TextBox textBox, ListBox listBox)
    {
        txtEntry = textBox;
        lstDetails = listBox;

        txtEntry.TextChanged += TextChangeHanlder;
    }

    private void TextChangeHanlder(object sender, EventArgs e) {
        TextFieldChanged();
    }
    private void TextFieldChanged()
    {
        // Get the current text in the TextBox
        string prefix = txtEntry.Text;

        // Check if the text is empty
        if (prefix.Length == 0)
        {
            // If it's empty, clear the selected item in the ListBox and exit the method
            lstDetails.ClearSelected();
            return;
        }

        // Convert the items in the ListBox to an array
        var items = lstDetails.Items.Cast<object>().ToArray();

        // Initialize a flag to track if a match is found
        bool found = false;

        // Iterate through the items in the ListBox
        for (int i = 0; !found && i < items.Length; i++)
        {
            // Get the current item
            object item = items[i];

            // Convert the item to a string
            string s = item.ToString();

            // Check if the string starts with the entered prefix
            if (s.StartsWith(prefix))
            {
                // If a match is found, set the item as selected in the ListBox
                lstDetails.SetSelected(i, true);
                found = true;
            }
        }

        // If no match is found, clear the selected item in the ListBox
        if (!found)
        {
            lstDetails.ClearSelected();
        }
    }
}
