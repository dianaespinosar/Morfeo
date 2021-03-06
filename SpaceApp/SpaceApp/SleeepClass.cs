﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Academic License - for use in teaching, academic research, and meeting
 * course requirements at degree granting institutions only.  Not for
 * government, commercial, or other organizational use.
 *
 * sleep.c
 *
 * Code generation for function 'sleep'
 *
 */

/* Include files */
//#include "sleep.h"
//#include <stdio.h>
//#include <string.h>

/* Custom Source Code */
//me
/* Type Definitions */
//# include <stdio.h>

/* Function Definitions */


namespace SpaceApp
{
    class SleeepClass
    {


        public String sleepMOrf(double[] x, double[] y)
        {
            double[] deep_sleep = new double[10229];
            int x3;
            int aux;
            int i;
            double j;

            //(void) y;
            //memset(&deep_sleep[0], 0, 10229U * sizeof(double));
            x3 = -1;
            aux = 0;
            for (i = 0; i < x.Length; i++)
            {
                if (!(x[i] <= 1.0))
                {
                    j = x[i] - x[aux];
                    if (((!(j <= 0.841)) || (!(j > 0.69))) && (!(j <= 0.691)) && (j <= 1.061) &&
                        (j > 0.841))
                    {
                        x3++;
                        deep_sleep[x3] = x[i];
                    }

                    aux++;
                }
            }
            double val = (deep_sleep[10228] - deep_sleep[0]) / 60.0 / 60.0;
            String res = ("Hours in deep sleep: " + val);
            return res;
        }

        /* End of code generation (sleep.c) */

    }
}
