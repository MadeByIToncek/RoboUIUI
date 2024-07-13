using System.Net.Http;

namespace RoboUI2 {
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new();
        private static readonly string address = "http://localhost:7777";
        public Form1()
        {
            InitializeComponent();
            hreset_lock_CheckedChanged(null, null);
            Reset();
            LoadTeams();
        }

        private async void LoadTeams()
        {
            string teams = await GetProperty("/api/listTeams");
            foreach (var item in teams.Split('\n'))
            {
                dropteam1.Items.Add(item);
                dropteam2.Items.Add(item);
            };
        }

        private void hreset_lock_CheckedChanged(object sender, EventArgs e)
        {
            hreset.Enabled = hreset_lock.Checked;
        }

        private async void hreset_Click(object sender, EventArgs e)
        {
            await SendCommand("/api/hardreset");
            await Reset();
        }

        private async void sreset_Click(object sender, EventArgs e)
        {
            await SendCommand("/api/reset");
            await Reset();
        }
        private async void reset_click(object sender, EventArgs e)
        {
            await Reset();
        }

        private async Task Reset()
        {
            //dropMode.Items.Clear();
            //foreach (Mode m in Enum.GetValues<Mode>()) {
            //    dropMode.Items.Add(m.ToString());
            //}
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            string text = await GetProperty("/api/mode");
            bool success = Enum.TryParse(text, true, out Mode mode);
            if (success)
            {
                switch (mode)
                {
                    case Mode.hidden:
                    case Mode.preload:
                        //CCBox.Enabled = true;
                        resetBox.Enabled = true;
                        preloadBox.Enabled = true;
                        playcontrolBox.Enabled = false;
                        resultsBox.Enabled = false;
                        targets.Enabled = false;
                        break;
                    case Mode.loaded:
                    case Mode.ingame:
                        //CCBox.Enabled = true;
                        resetBox.Enabled = true;
                        preloadBox.Enabled = false;
                        playcontrolBox.Enabled = true;
                        resultsBox.Enabled = false;
                        targets.Enabled = true;
                        break;
                    case Mode.counting:
                        //CCBox.Enabled = true;
                        resetBox.Enabled = true;
                        preloadBox.Enabled = false;
                        playcontrolBox.Enabled = false;
                        resultsBox.Enabled = true;
                        targets.Enabled = false;
                        break;
                    case Mode.results:
                        //CCBox.Enabled = true;
                        resetBox.Enabled = true;
                        preloadBox.Enabled = false;
                        playcontrolBox.Enabled = false;
                        resultsBox.Enabled = false;
                        targets.Enabled = false;
                        break;
                }
            }
            else
            {
                throw new Exception(text);
            }
        }

        private async Task<string> GetProperty(string path)
        {
            try
            {
                return await (await client.GetAsync(address + path)).Content.ReadAsStringAsync();
            }
            catch (Exception)
            {
                return await new Task<string>(() => "");
            }
        }

        private async Task SendCommand(string path)
        {
            await SendCommand(path, "");
        }

        private async Task SendCommand(string path, string text)
        {
            try
            {
                var response = await client.PostAsync(address + path, new StringContent(text));
            }
            catch (Exception)
            {

            }
        }

        private async void Preload_send_Click(object sender, EventArgs e)
        {
            if (dropteam1.Text != dropteam2.Text)
            {
                await SendCommand("/api/changeTeams", dropteam1.Text + ";" + dropteam2.Text);
                await Reset();
            }
            else
            {
                MessageBox.Show("Tým nemùže soupeøit sám proti sobì.");
            }
        }

        private async void play_send_Click(object sender, EventArgs e)
        {
            await SendCommand("/api/play");
            await Reset();
        }
        private async void interrupt_send_Click(object sender, EventArgs e)
        {
            await SendCommand("/api/interrupt");
            await Reset();
        }

        int a = 0, b = 0, c = 0, d = 0;
        private async Task UpdateScore()
        {
            await SendCommand("/api/balls", a + ";" + b + ";" + c + ";" + d);
        }

        private async void aplus_Click(object sender, EventArgs e)
        {
            a += 1;
            await UpdateScore();
        }

        private async void aminus_Click(object sender, EventArgs e)
        {
            a -= 1;
            await UpdateScore();
        }

        private async void bplus_Click(object sender, EventArgs e)
        {
            b += 1;
            await UpdateScore();
        }

        private async void bminus_Click(object sender, EventArgs e)
        {
            b -= 1;
            await UpdateScore();
        }

        private async void cplus_Click(object sender, EventArgs e)
        {
            c += 1;
            await UpdateScore();
        }

        private async void cminus_Click(object sender, EventArgs e)
        {
            c -= 1;
            await UpdateScore();
        }

        private async void dplus_Click(object sender, EventArgs e)
        {
            d += 1;
            await UpdateScore();
        }

        private async void dminus_Click(object sender, EventArgs e)
        {
            d -= 1;
            await UpdateScore();
        }

        private async void points_send_Click(object sender, EventArgs e)
        {
            await SendCommand("/api/submitScore", points1.Value + ":" + points2.Value);
            await Reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp = dropteam1.SelectedIndex;
            dropteam1.SelectedIndex = dropteam2.SelectedIndex;
            dropteam2.SelectedIndex = temp;
        }
    }
}