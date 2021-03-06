﻿using System.Windows.Input;
using Xamarin.Forms;

namespace XTraining.PageModels
{
    public class MainPageModel : FreshMvvm.FreshBasePageModel
    {
        public MainPageModel()
        {
            this.navigateCommand = new Command<string>(OnNavigate);
        }

        private Command<string> navigateCommand;

        public ICommand NavigateCommand => this.navigateCommand;

        public override void Init(object initData)
        {
            base.Init(initData);
        }

        private async void OnNavigate(string target)
        {
            if (target == "chart")
            {
                await CoreMethods.PushPageModel<ChartPageModel>(null, false, true);
            }
            else if (target == "datagrid")
            {
                await CoreMethods.PushPageModel<DataGridPageModel>(null, false, true);
            }
            else if (target == "list")
            {
                await CoreMethods.PushPageModel<ListPageModel>(null, false, true);
            }
        }
    }
}
