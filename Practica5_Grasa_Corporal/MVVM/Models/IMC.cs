﻿using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5_Grasa_Corporal.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class IMC
    {
        private int imcCalc;

        public IMC()
        {
            Altura = 150;
            Peso = 50;
            ImcCalc = CalcularIMC();
        }

        public int Altura { get; set; }
        public int Peso { get; set; }
        public int ImcCalc { get => imcCalc= CalcularIMC(); set => imcCalc = value; }

        public int CalcularIMC()
        {
            Double metros = (Altura/100.0);
            Console.Write(metros);
            int result = (int)(Peso /(Math.Pow(metros, 2)));
            return result;
        }
    }
}
