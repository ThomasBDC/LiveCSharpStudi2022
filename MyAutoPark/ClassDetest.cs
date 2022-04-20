using System;
using System.Collections.Generic;
using System.Text;

namespace MyAutoPark
{
    public class ClassDetest
    {
        public ClassDetest(int proprietePrive)
        {
            MyPrivateProperty = proprietePrive;
        }
        


        //Accès private
        private int MyPrivateProperty;

        //Accès public
        public int MyPublicProperty;



        public int CalculWithPrivateProperty(int param)
        {
            var reponse = param + MyPrivateProperty;
            return reponse;
        }



        //Accès internal


        //Accès protected
    }
}
