﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LottieAnimationEx
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadingPage : PopupPage
    {
        public LoadingPage()
        {
            InitializeComponent();
        }
    }
}