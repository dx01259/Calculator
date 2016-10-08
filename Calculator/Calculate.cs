using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculate
    {
        //起步距离2公里，起步价18元，2公里到8公里每公里1元，8公里以后每公里1.2元，等时费每分钟0.5
        public double theFeeForTaxi(double distance, double time = 0)
        {
            double the_fee_for_distance = 0;
            double the_fee_for_time = time * 0.5;

            if(distance <= 2)
            {
                the_fee_for_distance = 18;
            }else if(distance <= 8)
            {
                the_fee_for_distance = 18 + (distance - 2) * 1;
            }
            else
            {
                the_fee_for_distance = 18 + (8 - 2) * 1 + (distance - 8) * 1.2;
            }


            return the_fee_for_distance + the_fee_for_time;
        }
    }
}
