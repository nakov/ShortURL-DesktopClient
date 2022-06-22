using System;
using System.Net;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using RestSharp;
using RestSharp.Serialization.Json;

namespace ShortURL_DesktopClient
{
    public partial class FormURLBoard : Form
    {
        private string apiBaseUrl;

        public FormURLBoard()
        {
            InitializeComponent();
        }

        private void URLBoardForm_Shown(object sender, EventArgs e)
        {
            var formConnect = new FormConnect();
            if (formConnect.ShowDialog() == DialogResult.OK)
            {
                this.apiBaseUrl = formConnect.ApiUrl;
                LoadURLs();
            }
            else
            {
                this.Close();
            }
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            LoadURLs();
        }

        private async void LoadURLs()
        {
            try
            {
                var restClient = new RestClient(this.apiBaseUrl) { Timeout = 3000 };
                var request = new RestRequest("/urls", Method.GET);
                ShowMsg("Loading URLs ...");
                var response = await restClient.ExecuteAsync(request);
                if (response.IsSuccessful & response.StatusCode == HttpStatusCode.OK)
                {
                    // Visualize the returned URLs
                    var urls = new JsonDeserializer().Deserialize<List<URLEntry>>(response);
                    if (urls.Count > 0)
                        ShowSuccessMsg($"Search successful: {urls.Count} URLs loaded.");
                    else
                        ShowSuccessMsg($"No URLs found.");
                    DisplayURLsInListView(urls);
                }
                else
                    ShowError(response);
            }
            catch (Exception ex)
            {
                ShowErrorMsg(ex.Message);
            }
        }

        private void DisplayURLsInListView(List<URLEntry> urls)
        {
            this.listViewURLs.Clear();

            // Create column headers
            var headers = new ColumnHeader[] {
                new ColumnHeader { Text = "Original URL", Width = 250 },
                new ColumnHeader { Text = "Short URL", Width = 400 },
                new ColumnHeader { Text = "DateCreated", Width = 200 },
                new ColumnHeader { Text = "Visits", Width = 50 },
            };
            this.listViewURLs.Columns.AddRange(headers);

            // Add items and groups to the ListView control
            var groups = new Dictionary<string, ListViewGroup>();
            foreach (var url in urls)
            {
                var parsedDateTime = DateTime.Parse(url.DateCreated).ToUniversalTime();
                var item = new ListViewItem(new string[] {
                    "" + url.URL, url.ShortURL, parsedDateTime.ToString("yyyy-MM-dd HH:mm:ss"), url.Visits });
                this.listViewURLs.Items.Add(item);
            }

            this.listViewURLs.Groups.AddRange(groups.Values.ToArray());
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            var formAddURL = new FormAddURL();
            if (formAddURL.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var restClient = new RestClient(this.apiBaseUrl) { Timeout = 3000 };
                    var request = new RestRequest("/urls", Method.POST);
                    request.AddJsonBody(new
                    {
                        url = formAddURL.URL,
                        shortCode = formAddURL.Code
                    });
                    ShowMsg($"Adding new URL ...");
                    var response = await restClient.ExecuteAsync(request);
                    if (response.IsSuccessful & response.StatusCode == HttpStatusCode.OK)
                    {
                        ShowSuccessMsg($"URL added.");
                        LoadURLs();
                    }
                    else
                        ShowError(response);
                }
                catch (Exception ex)
                {
                    ShowErrorMsg(ex.Message);
                }
            }
        }

        private void ShowError(IRestResponse response)
        {
            if (string.IsNullOrWhiteSpace(response.ErrorMessage))
            {
                string errText = $"HTTP error `{response.StatusCode}`.";
                if (!string.IsNullOrWhiteSpace(response.Content))
                    errText += $" Details: {response.Content}";
                ShowErrorMsg(errText);
            }
            else
                ShowErrorMsg($"HTTP error `{response.ErrorMessage}`.");
        }

        private void ShowMsg(string msg)
        {
            toolStripStatusLabel.Text = msg;
            toolStripStatusLabel.ForeColor = SystemColors.ControlText;
            toolStripStatusLabel.BackColor = SystemColors.Control;
        }

        private void ShowSuccessMsg(string msg)
        {
            toolStripStatusLabel.Text = msg;
            toolStripStatusLabel.ForeColor = Color.White;
            toolStripStatusLabel.BackColor = Color.Green;
        }

        private void ShowErrorMsg(string errMsg)
        {
            toolStripStatusLabel.Text = $"Error: {errMsg}";
            toolStripStatusLabel.ForeColor = Color.White;
            toolStripStatusLabel.BackColor = Color.Red;
        }
    }
}
