using iMean.Tool.DailyNrjExpenditure.WinForms.Views;

namespace iMean.Tool.DailyNrjExpenditure.WinForms.Presenters;

public class Presenter<TView> : IPresenter
    where TView : IView
{
    protected TView? _view;

    public Presenter(TView view)
    {
        _view = view ?? throw new ArgumentNullException(nameof(view));
    }
}
