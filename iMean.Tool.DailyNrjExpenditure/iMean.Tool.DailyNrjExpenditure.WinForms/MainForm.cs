using iMean.Tool.DailyNrjExpenditure.WinForms.Presenters;
using MaterialSkin2DotNet.Controls;

namespace iMean.Tool.DailyNrjExpenditure.WinForms
{
    public partial class MainForm : MaterialForm, IMainView
    {
        private readonly FormPresenter _presenter;

        public MainForm()
        {
            InitializeComponent();

            _presenter = new FormPresenter(this);

            if (!DesignMode)
            {
                InitializeEvents();
            }
        }

        public string Title
        {
            get { return Text; }
            set { Text = value; }
        }

        public event EventHandler ViewClose;

        public event EventHandler ViewLoad;

        private void InitializeEvents()
        {
            Load += ViewLoad;
            FormClosed += (sender, args) => ViewClose(sender, args);
        }
    }
}