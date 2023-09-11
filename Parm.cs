using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartWithParms
{
    public class Parm : BaseVM
    {
        private string textParm = "Hello";

        public string TextParm { get => textParm; set => SetProperty(ref textParm, value); }

        public Parm()
        { }

        public Parm(string parm)
        {
            TextParm = parm;
        }       

    }
}
