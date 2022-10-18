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
        public void ejercicio1(int m)
        {
            Vector pares=new Vector();
            Vector impares = new Vector();
            for (int i = 1; i <= n; i++)
            {
                if (i % m == 0)
                {
                    if (v[i]%2==0){
                        pares.insertar(v[i]);
                    }
                    else
                    {
                        impares.insertar(v[i]);
                    }
                }
            }

            pares.ordenar();
            impares.ordenar();

            int ipares = 1;
            int iimpares = 1;

            for (int i = 1; i <= n; i++)
            {
                if (i % m == 0)
                {
                    if (iimpares <= impares.n)
                    {
                        v[i] = impares.v[iimpares];
                        iimpares++;
                    }
                    else
                    {
                        
                        v[i] = pares.v[ipares];
                        ipares++;
                    }
                }
            }
        }
        public int frecuencia(int ele,int m, int a, int b)
        {
            int c = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % m == 0 && v[i] == ele)
                {
                    c++;
                }
            }
            return c;
        }
        public void ordenarrango(int m, int a, int b)
        {
            for (int i = a; i < b; i++)
            {
                for (int j = i + 1; j <= b; j++)
                {
                    if (i % m == 0 && j % m == 0)
                    {
                        if (v[i] > v[j])
                        {
                            int aux = v[i];
                            v[i] = v[j];
                            v[j] = aux;
                        }
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

        public void ejercicio2(Vector e, Vector f,int m, int a, int b)
        {
            ordenarrango(m, a, b);
            for (int i = a; i <= b; i++)
            {
                if (i%m==0)
                {
                    int ele = v[i];
                    int frec = frecuencia(v[i], m, a, b);
                    if (e.frecuencia(ele) == 0)
                    {
                        e.insertar(ele);
                        f.insertar(frec);
                    }
                  
                }

            }
        }
        
    }
}
