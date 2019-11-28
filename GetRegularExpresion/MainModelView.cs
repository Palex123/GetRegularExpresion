using CommandLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GetRegularExpresion
{
    public class MainModelView: BaseNotify
    {
        ModelProperties modelProperties;

        public ModelProperties ModelProperties
        {
            get
            {
                if(modelProperties==null)
                {
                    modelProperties = new ModelProperties();
                }
                return modelProperties;
            }
            set
            {
                modelProperties = value;
                OnPropertyChanged();
            }
        }
        private IAsyncCommand getUrlContent;
        public IAsyncCommand GetUrlContent
        {
            get
            {
                return getUrlContent ?? (getUrlContent= AsyncCommand.Create(token =>
                       Services.DownloadStringAsync(modelProperties.PathWeb, token)));
            }
        }

        public MainModelView()
        {
            modelProperties = new ModelProperties();
            modelProperties.PathWeb = "http://znachenie-tajna-imeni.ru/muzhskie-kazahskie-imena-so-znachenimi";
        }
    }
}
