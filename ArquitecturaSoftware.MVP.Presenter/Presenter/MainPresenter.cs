using ArquitecturaSoftware.MVP.Model;
using ArquitecturaSoftware.MVP.Model.Service;
using ArquitecturaSoftware.MVP.Presenter.ViewPorts;
using System.Threading.Tasks;

namespace ArquitecturaSoftware.MVP.Presenter.Presenter
{
    public class MainPresenter
    {
        private IMainView _view;
        private NasaService _nasaService;

        public void AddView(IMainView mainView)
        {
            _view = mainView;
            _nasaService = new NasaService();
            _view.SetTitle("Type your intitutional email to enable het the image:");
            _view.SetImage("https://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/NASA_logo.svg/1200px-NASA_logo.svg.png");
        }

        public async Task GetRandomImageAsync()
        {
            RandomImage dataImage = await _nasaService.GetRandomImageAsync();
            _view.SetImage(dataImage.Url);
            _view.SetTitle("");
            _view.HideLogInForm();
            _view.EnableGetImageButton();
        }

        public void ValidateInstitutionalMail(string mail)
        {
            if(!string.IsNullOrEmpty(mail) && mail.Contains("@udea.edu.co"))
            {
                _view.SetTitle($"Hello {mail}");
                _view.HideLogInForm();
                _view.EnableGetImageButton();
            }
        }
    }
}