using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfBTApp
{
    public class MainViewModel : ObservableObject
    {
        private LanguageModel _language;
        
        public List<LanguageModel> Languages { get; set; }

        public LanguageModel Language
        {
            get { return _language; }
            set { SetProperty2(ref _language, value, LanguageModelChanged); }
        }

        private void SetProperty2<T>(ref T value1, T value2, Action<T> changed, [CallerMemberName] string? name = null)
        {
            OnPropertyChanged(name);
            value1 = value2;
            changed.Invoke(value2);
        }

        private void LanguageModelChanged(LanguageModel value)
        {
            App.SwitchLanguage(value);
        }


        public MainViewModel()
        {
            Languages = new List<LanguageModel>();

            Languages.Add(new LanguageModel("KOR"));
            Languages.Add(new LanguageModel("ENG"));

            Language = Languages.FirstOrDefault()!;
        }
    }
}
