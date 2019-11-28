using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRegularExpresion
{
    public class ModelName : BaseNotify
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if(value!=null && value.Length>1)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
