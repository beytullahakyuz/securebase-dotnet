using System.Diagnostics;
using System.Text;

namespace CustomBaseApp
{
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void btnTexttoBase64_Click(object sender, EventArgs e) {
            string secretkey = txtSecretKey.Text.Trim();
            SecureBase.SBEncoding sbencoding;
            if (cmbEncoding.SelectedIndex == 0)
                sbencoding = SecureBase.SBEncoding.UNICODE;
            else
                sbencoding = SecureBase.SBEncoding.UTF8;
            SecureBase bs = new SecureBase(sbencoding);
            Stopwatch sp = new Stopwatch();
            sp.Start();
            if (sender == btnTexttoBase64) {
                bs.SetSecretKey(secretkey);
                txtBase64.Text = "";
                string data = txtData.Text.Trim();
                string encodeddata = string.Empty;
                try {
                    encodeddata = bs.Encode(data);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    encodeddata = "";
                }
                txtBase64.Text = encodeddata;
            } else if (sender == btnBase64toText) {
                bs.SetSecretKey(secretkey);
                txtDecodedData.Text = "";
                string data = txtEncodedBase64.Text.Trim();
                string decodeddata = string.Empty;
                try {
                    decodeddata = bs.Decode(data);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    decodeddata = "";
                }
                txtDecodedData.Text = decodeddata;
            }
            sp.Stop();
            statusbar.Text = sp.Elapsed.TotalMilliseconds + " ms";
        }

        private void btnLang_Click(object sender, EventArgs e) {
            if (btnLang.Text.ToLower() == "english") {
                lblSecretkey.Text = "Secret key:";
                e_lbldata.Text = "Data;";
                d_lbldata.Text = "Data;";
                btnTexttoBase64.Text = "Text to Base64";
                btnBase64toText.Text = "Base64 to Text";
                pageEncoding.Text = "Encoding";
                pageDecoding.Text = "Decoding";
                statusbar.Text = "Ready";
                btnLang.Text = "Türkçe";
            } else {
                lblSecretkey.Text = "Gizli anahtar:";
                e_lbldata.Text = "Veri;";
                d_lbldata.Text = "Veri;";
                btnTexttoBase64.Text = "Metin -> Base64";
                btnBase64toText.Text = "Base64 -> Metin";
                pageEncoding.Text = "Kodlama";
                pageDecoding.Text = "Kod Çözme";
                statusbar.Text = "Hazýr";
                btnLang.Text = "English";
            }
            this.Refresh();

        }

        private void frmMain_Load(object sender, EventArgs e) {
            cmbEncoding.SelectedIndex = 1;
        }
    }
}
