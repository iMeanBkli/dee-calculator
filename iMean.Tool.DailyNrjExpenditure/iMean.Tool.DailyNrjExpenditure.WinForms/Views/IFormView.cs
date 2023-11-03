namespace iMean.Tool.DailyNrjExpenditure.WinForms.Views;

public interface IFormView : IView
{
    event EventHandler ViewClose;
    event EventHandler ViewLoad;
}
