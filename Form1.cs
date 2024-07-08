using System.Net.Http;

namespace RoboUI2 {
    public partial class Form1 : Form {
        private static readonly HttpClient client = new();
        public Form1() {
            InitializeComponent();
            Reset();
            hreset_lock_CheckedChanged(null, null);
        }

        private void hreset_lock_CheckedChanged(object sender, EventArgs e) {
            hreset.Enabled = hreset_lock.Checked;
        }

        private void hreset_Click(object sender, EventArgs e) {
            SendCommand("/api/hardreset");
        }

        private void sreset_Click(object sender, EventArgs e) {
            SendCommand("/api/reset");
        }
        private void reset_click(object sender, EventArgs e) {
            Reset();
        }

        private async void Reset() {
            dropMode.Items.Clear();
            foreach (Mode m in Enum.GetValues<Mode>()) {
                dropMode.Items.Add(m.ToString());
            }
            string text = await GetProperty("/api/mode");
            bool success = Enum.TryParse(text, true, out Mode mode);
            if (success) {
                switch (mode) {
                    case Mode.hidden:
                    case Mode.preload:
                        CCBox.Enabled = true;
                        resetBox.Enabled = true;
                        preloadBox.Enabled = true;
                        playcontrolBox.Enabled = false;
                        resultsBox.Enabled = false;
                        break;
                    case Mode.ingame:
                        CCBox.Enabled = true;
                        resetBox.Enabled = true;
                        preloadBox.Enabled = false;
                        playcontrolBox.Enabled = true;
                        resultsBox.Enabled = false;
                        break;
                    case Mode.counting:
                        CCBox.Enabled = true;
                        resetBox.Enabled = true;
                        preloadBox.Enabled = false;
                        playcontrolBox.Enabled = false;
                        resultsBox.Enabled = true;
                        break;
                    case Mode.results:
                        CCBox.Enabled = true;
                        resetBox.Enabled = true;
                        preloadBox.Enabled = false;
                        playcontrolBox.Enabled = false;
                        resultsBox.Enabled = false;
                        break;
                }
            } else {
                throw new Exception(text);
            }
        }

        private async Task<string> GetProperty(string path) {
            return await (await client.GetAsync(targetURL.Text + path)).Content.ReadAsStringAsync();
        }

        private async void SendCommand(string path) {
            await SendCommand(path, "");
        }

        private async Task SendCommand(string path, string text) {
            var response = await client.PostAsync(targetURL.Text + path, new StringContent(text));
        }

        private async void modechg_send_Click(object sender, EventArgs e) {
            if (dropMode.SelectedText != null) {
                await SendCommand("/api/changeMode", dropMode.SelectedText);
                Reset();
            }
        }
    }
}