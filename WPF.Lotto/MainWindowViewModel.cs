using System;
using System.Windows.Input;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using WPF.Lotto.Services;

namespace WPF.Lotto
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region Declareations

        private readonly ITextService _textService;
        private string _red1;
        private string _red2;
        private string _red3;
        private string _red4;
        private string _red5;
        private string _blue;

        #endregion

        #region Property

        public IMessageBoxService DXMessageBoxService
        {
            get => GetService<IMessageBoxService>();
        }

        #endregion

        #region Memberfunction

        [Command]
        public void TestCommand()
        {
            DXMessageBoxService.ShowMessage(_textService.GetText());
        }

        public string Red1
        {
            get => _red1;
            set => SetValue(ref _red1, value);
        }


        public string Red2
        {
            get => GetValue<string>(nameof(_red2));
            set => SetValue(value, nameof(_red2));
        }


        public string Red3
        {
            get => _red3;
            set => _red3 = value;
        }

        public string Red4
        {
            get { return _red4; }
            set { _red4 = value; }
        }

        public string Red5
        {
            get => _red5;
            set => _red5 = value;
        }

        public string Blue
        {
            get => _blue;
            set => _blue = value;
        }

        #endregion

        public MainWindowViewModel(ITextService textService)
        {
            _textService = textService;
            _red1 = "02";
            _red2 = "04";
            _red3 = "03";
            _red4 = "04";
            _red5 = "05";
            _blue = "06";
        }
    }
}