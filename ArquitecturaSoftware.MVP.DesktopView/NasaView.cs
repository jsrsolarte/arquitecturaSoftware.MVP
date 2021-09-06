using ArquitecturaSoftware.MVP.Presenter.Presenter;
using ArquitecturaSoftware.MVP.Presenter.ViewPorts;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArquitecturaSoftware.MVP.DesktopView
{
    public partial class NasaView : Form, IMainView
    {

        private MainPresenter _presenter;
        public NasaView()
        {
            InitializeComponentAsync();
            _presenter = new MainPresenter();
            _presenter.AddView(this);
            getImageButton.Enabled = false;
        }

        public void EnableGetImageButton()
        {
            getImageButton.Enabled = true;
        }

        public void HideLogInForm()
        {
            logInForm.Visible = false;
            Refresh();
        }

        public void SetImage(string urlImage)
        {
            pictureBox1.Load(urlImage);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            Refresh();
        }

        public void SetTitle(string title)
        {
            titleLabel.Text = title;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            _presenter.ValidateInstitutionalMail(mailTextBox.Text);
        }

        private void getImageButton_ClickAsync(object sender, EventArgs e)
        {
           _presenter.GetRandomImageAsync();
        }
    }
}
