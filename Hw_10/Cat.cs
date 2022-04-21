using System;
using System.Collections.Generic;
using System.Text;

namespace Hw_10
{
    public class Cat
    {

        //ToDo: finish this method
        public bool CatIsPlaying(bool isSummer, int temp)
        {

            //first parameter indicates if it is summer or not
            //second parameter indicates temperature
            //Add content here so all tests would pass!
            if (isSummer == true)
            {
                if (temp >= 25 && temp <= 45)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (isSummer == false)
            {
                if (temp >= 25 && temp <= 35)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

                return false;
        }
    }
}
