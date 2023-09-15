using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ1
{
    internal class Retangulo
    {
            //atributos
            private int b;
            private int h;
            private int a;

            //metodos 
            public void setBase(int p)
            {
                b = p;
            }

            public void setAltura(int p)
            {
                h = p;
            }

            public int getBase()
            {
                return b;
            }

            public int getAltura()
            {
                return h;
            }

            public int getArea()
            {
                return a;
            }

            public void calcularArea()
            {
                a = b * h;
            }
        }
    }

