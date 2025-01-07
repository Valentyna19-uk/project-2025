
    using System;
    using System.Collections.Specialized;

    namespace Rectangle
    {
        class Rectangle
        {
            private int a;
            private int b;
            private Rectangle obj;

            public Rectangle(int a_, int b_)
            {
                this.a = a_;
                this.b = b_;
                Console.Write("Vuklukano konstruktor z parametramu");
                //Console.Write(this);
                Console.Write("\n");
            }

            public Rectangle()
            {
                this.a = 0;
                this.b = 0;
                Console.Write("Vuklukano konstruktor bez parametriv");
                //Console.Write(this);
                Console.Write("\n");
            }

            public Rectangle(Rectangle obj)
            {
                this.obj = obj;
            }

            public void Dispose()
            {
                Console.Write("Vuklukano destruktor ");
                //Console.Write(this);
                Console.Write("\n");
            }

            public void Mult(int value)
            {
                a *= value;
                b *= value;
            }

            public static implicit operator bool(Rectangle t)
            {
                if (t.a == t.b) return true;
                return false;
            }

            public static Rectangle operator ++(Rectangle t)
            {
                t.a++;
                t.b++;
                return t;
            }

            public static Rectangle operator --(Rectangle t)
            {
                t.a--;
                t.b--;
                return t;
            }

            public static implicit operator string(Rectangle t)
            {
                string str;
                str = t.a.ToString() + " " + t.b.ToString();
                return str;
            }
            public void re(string str)
            {
                string[] subs = str.Split(' ');
                a = int.Parse(subs[0]);
                b = int.Parse(subs[1]);
            }

            public int getA()
            {
                return a;
            }

            public int getB()
            {
                return b;
            }

            public void setA(int a_)
            {
                a = a_;
            }

            public void setB(int b_)
            {
                b = b_;
            }

            public void setRectangle(int a_, int b_)
            {
                a = a_;
                b = b_;
            }

            public void print()
            {
                Console.Write("\na = ");
                Console.Write(a);
                Console.Write("\nb = ");
                Console.Write(b);
                Console.Write("\nperimetr = ");
                Console.Write(p());
                Console.Write("\nploscha = ");
                Console.Write(pp());
                Console.WriteLine("\n");
            }

            public int p()
            {
                return a + a + b + b;
            }

            public int pp()
            {
                return a * b;
            }
        }

        class Globals
        {
            public static Rectangle init()
            {
                Rectangle obj = new Rectangle();
                int a;
                int b;
                int perimetr;
                int ploscha;
                Console.Write("input a\n");
                a = int.Parse(Console.ReadLine());
                Console.Write("input b\n");
                b = int.Parse(Console.ReadLine());
                obj.setRectangle(a, b);
                obj.print();
                newTask(obj);
                return new Rectangle(obj);
            }

            public static void newTask(Rectangle f)
            {
                ++f;
                Console.WriteLine("\nAdd 1:");
                f.print();
                --f;
                Console.WriteLine("\nSubtract 1:");
                f.print();
                Console.WriteLine("\nInput num x: ");
                int x;
                x = int.Parse(Console.ReadLine());
                f.Mult(x);
                Console.WriteLine("\nMultiply by x:");
                f.print();
                string str = f;
                Console.WriteLine("\nConverted to string:\n" + str);
                Rectangle ff = new Rectangle();
                ff.re(str);
                Console.WriteLine("\nReconverted:");
                ff.print();
                if (f) Console.WriteLine("\nSquare\n");
                else Console.WriteLine("\nNot square\n");
            }

            static void Main(string[] args)
            {
                init();
            }
        }
    }


