using ArquitecturaSoftware.MVP.Presenter.Presenter;
using ArquitecturaSoftware.MVP.Presenter.ViewPorts;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace ArquitecturaSoftware.MVP.WebView.Pages
{
    public class IndexModel : PageModel, IMainView
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly MainPresenter _presenter;

        public string InitialMessage { get; set; }
        public string Mail { get; set; }
        public bool GetImageEnabled { get; set; } = true;
        public bool LogInFormHidden { get; set; } = false;

        public string Image { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _presenter = new MainPresenter();
            _presenter.AddView(this);
        }

        public void OnGet()
        {
        }

        public void OnPostLogIn()
        {
            Mail = Request.Form["Mail"];
            _presenter.ValidateInstitutionalMail(Mail);
        }

        public async Task OnPostGetImageAsync()
        {
            await _presenter.GetRandomImageAsync();
        }

        public void SetImage(string urlImage)
        {
            Image = urlImage;
        }

        public void SetTitle(string title)
        {
            InitialMessage = title;
        }

        public void EnableGetImageButton()
        {
            GetImageEnabled = false;
        }

        public void HideLogInForm()
        {
            LogInFormHidden = true;
        }
    }
}