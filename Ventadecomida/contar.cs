using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventadecomida
{
    class contar
    {
        int c1, c2,c3;
        //public int c1 { get => c1; set => c1 = value; }
        //public int c2 { get => c2; set => c2 = value; }
        //public int c3 { get => c3; set => c3 = value; }       

        public void setc1(int a)
        {
            this.c1 = a;
        }
        public int getc1()
        {
            return this.c1;
        }
        public void setc2(int a)
        {
            this.c2 = a;
        }
        public int getc2()
        {
            return this.c2;
        }
        public void setc3(int a)
        {
            this.c3 = a;
        }
        public int getc3()
        {
            return this.c3;
        }
        public void sumar1(int a)
        {            
            setc1(a + this.getc1());
            System.Console.WriteLine(this.getc1());
        }
        public void sumar2(int a)
        {
            setc2(a + this.getc2());
        }
        public int cal1()
        {
            int r;
            r = this.getc1() * 59;
            this.setc3(  this.getc3() + r);
            return r;
        }
        public int cal2()
        {
            int r;
            r = this.getc2() * 59;
            this.setc3(this.getc3() + r);
            return r;
           
        }
    }
}
