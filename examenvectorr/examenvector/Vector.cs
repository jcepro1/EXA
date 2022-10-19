using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenvector
{
    class Vector
    {
        // LIMITE DEL VECTOR SERA 100
        const int MAX = 100;
        //PROPIEDADES DELA      CLASE VECTOR 
        private int[] v;
        private int n;
        public Vector()
        {
            n = 0;
            v = new int[MAX];
        }
        public void CargarRamdom(int n1, int a, int b)
        {
            Random r;
            r = new Random();
            int i;
            n = n1;
            for (i = 1; i <= n; i++)
                v[i] = r.Next(a, b);
        }

        public string Descargar()
        {
            string s;
            int i;
            s = " ";
            for (i = 1; i <= n; i++)
                s = s + v[i] + " | ";
            return s;
        }
       
        private void insertar(int ele)
        {
            n++;
            v[n] = ele;
        }
        public void ordenar()
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = i+1; j <= n; j++)
                {
                    if (v[i] > v[j])
                    {
                        int aux = v[i];
                            v[i]=v[j];
                            v[j]=aux;
                    }
                }
            }
        }
    
        public int frecuencia(int ele)
        {
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                if (v[i] == ele)
                {
                    c++;
                }
            }
            return c;
        }


        //public String examen1(Vector v2)
        //{
        //    Vector vr = new Vector();
        //    for (int i = 1; i <= n; i++)
        //    {
        //        int ele = v[i];
        //        if (v2.frecuencia(ele)==0 && vr.frecuencia(ele)==0)
        //        {
        //                vr.insertar(ele);
        //        }

        //    }
        //    return vr.Descargar();
        //}

        public String examen1(Vector v2)
        {
            Vector vr = new Vector();
            for (int i = 1; i <= n; i++)
            {
                int ele = v[i];
                if (v2.frecuencia(ele) == 0 && vr.frecuencia(ele) == 0)
                {
                    vr.insertar(ele);
                }

            }
            for (int i = 1; i <= v2.n; i++)
            {
                int ele = v2.v[i];
                if (frecuencia(ele) == 0 && vr.frecuencia(ele) == 0)
                {
                    vr.insertar(ele);
                }

            }
            return vr.Descargar();
        }
        public void examen2(int a, int b)
        {
            Vector vr = new Vector();
            for (int i = b; i >= a; i--)
            {
                vr.insertar(v[i]);
            }
            vr.ordenar();
            int x = 1;
            int y = vr.n;
            bool bandera = true;
            for (int i = b; i >= a; i--)
            {
                if (bandera)
                {
                    v[i] = vr.v[y];
                    y--;
                }
                else
                {
                    v[i] = vr.v[x];
                    x++;
                }
                bandera = !bandera;
            }

        }
        
    }
}
