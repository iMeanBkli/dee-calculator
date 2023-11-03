using iMean.Tool.DailyNrjExpenditure.WinForms.Views;

namespace iMean.Tool.DailyNrjExpenditure.WinForms.Presenters;

public class FormPresenter : Presenter<IFormView>
{
    public FormPresenter(IFormView view)
        : base(view)
    {
        SubscribeViewEvents();
    }

    protected virtual void SubscribeViewEvents()
    {
        _view.ViewClose += OnViewClose;
        _view.ViewLoad += OnViewLoad;
    }

    protected virtual void UnsubscribeViewEvents()
    {
        _view.ViewClose -= OnViewClose;
        _view.ViewLoad -= OnViewLoad;
    }

    protected virtual void OnViewClose(object? sender, EventArgs e)
    {
        UnsubscribeViewEvents();

        _view = null;
    }

    protected virtual void OnViewLoad(object? sender, EventArgs e)
    {
    }
}
