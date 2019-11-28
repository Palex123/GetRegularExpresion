using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRegularExpresion
{
    public class ModelProperties : BaseNotify
    {
        private string pathWeb;
        public string PathWeb
        {
            get { return pathWeb; }
            set
            {
                if(value!=null && value.Length>3 )
                {
                    pathWeb = value;
                    OnPropertyChanged();
                }
            }
        }
        private string patternString1;
        public string PatternString1
        {
            get { return patternString1; }
            set
            {
                if(value!=null && value.Length>0)
                {
                    patternString1 = value;
                    OnPropertyChanged();
                }
            }
        }

        private string patternString2;
        public string PatternString2
        {
            get { return patternString2; }
            set
            {
                if(value!=null && value.Length>0)
                {
                    patternString2 = value;
                    OnPropertyChanged();
                }
            }
        }

        private string webResponse;
        public string WebResponse
        {
            get { return webResponse; }
            set
            {
                if(value!=null && value.Length>0)
                {
                    webResponse = value;
                    OnPropertyChanged();
                }
            }
        }

    }
}
