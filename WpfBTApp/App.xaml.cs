﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Windows;

namespace WpfBTApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static Dictionary<string, ResourceDictionary> _languages;
        private static ResourceDictionary _currentLanguage;

        public App()
        {
            ResourceDictionary korean = GetResource("Korean");
            ResourceDictionary english = GetResource("English");

            _languages = new Dictionary<string, ResourceDictionary>();
            _languages.Add("KOR", korean);
            _languages.Add("ENG", english);

            //_currentLanguage = korean;
            //Resources.MergedDictionaries.Add(english);
        }

        private ResourceDictionary GetResource(string nation)
        {
            ResourceDictionary resource = new ResourceDictionary();
            resource.Source = new Uri($"/WpfBTApp;component/Themes/{nation}.xaml", UriKind.RelativeOrAbsolute);

            return resource;
        }

        internal static void SwitchLanguage(LanguageModel language)
        {
            App.Current.Resources.MergedDictionaries.Remove(_currentLanguage);
            App.Current.Resources.MergedDictionaries.Add(_languages[language.Code]);
        }
    }
}
