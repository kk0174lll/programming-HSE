﻿using LaboratoryWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork1.works.work1
{
    class Task2_1 : ATask
    {
        public Task2_1()
        {
            taskName = "v19. task 2";
        }

        static bool checkArea(int x, int y)
        {
            int positiveLimit = 5;
            int negativelimit = -5;
            if (x < 0 && y > 0)
            {
                return false;
            }
            if (x < negativelimit || x > positiveLimit)
            {
                return false;
            }
            if (y < negativelimit || y > positiveLimit)
            {
                return false;
            }

            return (y < (-x + positiveLimit)) && (y > (x + negativelimit)) && (y > (-x + negativelimit));
        }


        static String calculate(int x, int y)
        {
            bool result = checkArea(x, y);
            return $"x={x} y={y} in area = {result}";
        }

        protected override void executeTasck()
        {
            int x, y;
            x = Utils.readInt("x");
            y = Utils.readInt("y");
            Utils.printText($"{calculate(x, y)}", true, ETextType.NORMAL);
        }
    }
}
