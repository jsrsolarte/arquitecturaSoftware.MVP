namespace ArquitecturaSoftware.MVP.Presenter.ViewPorts
{
    public interface IMainView
    {
        void SetImage(string urlImage);

        void SetTitle(string title);

        void HideLogInForm();

        void EnableGetImageButton();
    }
}