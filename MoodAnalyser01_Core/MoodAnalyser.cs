﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser01_Core
{
   public class MoodAnalyser
    {
        private string message;        //the private message field of the mood analyser class
        
        public MoodAnalyser(string message)        //initialising the parameterised constructor
        {
            this.message = message;
        }

        public string AnalyseMood()                  //declaring the analyse mood method
        {
            try                                      //the try and catch block is for exception handling
            {
                if (this.message.Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }

            catch
            {
                return "HAPPY";
            }
        }
    }
}
