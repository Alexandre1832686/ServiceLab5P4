using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceDonneLab5Partie4.model;

namespace ServiceDonneLab5Partie4.vue_model
{
    internal class ProgramVM
    {
        string _test;
        public string Test
        {
            get { return _test; }
            set { _test = value; }
        }

        public ProgramVM()
        {
            ApiHelper.InitializeClient();
            Test = await ApiHelper.GetNomStudent("ABCD11111111");
        }
    }
}
