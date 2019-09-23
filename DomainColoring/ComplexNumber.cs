using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainColoring
{
    class ComplexNumber
    {
        public float a { get; set; }
        public float b { get; set; }
        public float argument
        {
            get {
                float ret = (float)(Math.Atan2(b, a) * 57.2958) + 180;

                //If the any value (a or b) is infinite return argument of zero
                if (float.IsInfinity(ret) || float.IsNaN(ret))
                {
                    return 0;
                }

                return (float)(Math.Atan2(b, a) * 57.2958) + 180; }
            protected set { }
        }

        public float magnitude
        {
            get {
                //If the magnitude is infinite, return a very large number instead
                float ret = (float)Math.Sqrt((a * a) + (b * b));
                if (float.IsInfinity(ret) || float.IsNaN(ret))
                    return float.MaxValue;
                return ret;
            }
            protected set { }
        }

        public ComplexNumber conjugate {
            //Return the conjugate of the complex number
            //2 + 3i would return 2 - 3i
            get { return new ComplexNumber(a, -b); }
            protected set { }
        }

        public static ComplexNumber i {
            get { return new ComplexNumber(0, 1); }
            protected set { } }


        public ComplexNumber(float a, float b)
        {
            this.a = a;
            this.b = b;
        }

        public static ComplexNumber Tangent(ComplexNumber z)
        {
            return Sine(z) / Cosine(z);
        }

        public static ComplexNumber Cosine(ComplexNumber z)
        {
            return new ComplexNumber((float)(Math.Cos(z.a) * Math.Cosh(z.b)), (float)(Math.Sin(z.a) * Math.Sinh(z.b)));
        }

        public static ComplexNumber Sine(ComplexNumber z)
        {
            return new ComplexNumber((float)(Math.Sin(z.a) * Math.Cosh(z.b)), (float)(Math.Cos(z.a) * Math.Sinh(z.b)));
        }

        public static ComplexNumber operator +(double num1, ComplexNumber num2)
        {
            return new ComplexNumber((float)num1 + num2.a, num2.b);
        }

        public static ComplexNumber operator +(ComplexNumber num1, double num2)
        {
            return new ComplexNumber(num1.a + (float)num2, num1.b);
        }

        public static ComplexNumber operator +(int num1, ComplexNumber num2)
        {
            return new ComplexNumber(num1 + num2.a, num2.b);
        }

        public static ComplexNumber operator +(ComplexNumber num1, int num2)
        {
            return new ComplexNumber(num1.a + num2, num1.b);
        }

        public static ComplexNumber operator +(float num1, ComplexNumber num2)
        {
            return new ComplexNumber(num1 + num2.a, num2.b);
        }

        public static ComplexNumber operator +(ComplexNumber num1, float num2)
        {
            return new ComplexNumber(num1.a + num2, num1.b);
        }

        public static ComplexNumber operator -(double num2, ComplexNumber num1)
        {
            return new ComplexNumber(num1.a - (float)num2, num1.b);
        }

        public static ComplexNumber operator -(ComplexNumber num1, double num2)
        {
            return new ComplexNumber(num1.a - (float)num2, num1.b);
        }

        public static ComplexNumber operator -(int num2, ComplexNumber num1)
        {
            return new ComplexNumber(num1.a - num2, num1.b);
        }

        public static ComplexNumber operator -(ComplexNumber num1, int num2)
        {
            return new ComplexNumber(num1.a - num2, num1.b);
        }

        public static ComplexNumber operator -(float num2, ComplexNumber num1)
        {
            return new ComplexNumber(num1.a - num2, num1.b);
        }

        public static ComplexNumber operator -(ComplexNumber num1, float num2)
        {
            return new ComplexNumber(num1.a - num2, num1.b);
        }

        public static ComplexNumber operator *(double num2, ComplexNumber num1)
        {
            return new ComplexNumber(num1.a * (float)num2, num1.b * (float)num2);
        }

        public static ComplexNumber operator *(ComplexNumber num1, double num2)
        {
            return new ComplexNumber(num1.a * (float)num2, num1.b * (float)num2);
        }

        public static ComplexNumber operator *(int num2, ComplexNumber num1)
        {
            return new ComplexNumber(num1.a * num2, num1.b * num2);
        }

        public static ComplexNumber operator *(ComplexNumber num1, int num2)
        {
            return new ComplexNumber(num1.a * num2, num1.b * num2);
        }

        public static ComplexNumber operator *(float num2, ComplexNumber num1)
        {
            return new ComplexNumber(num1.a * num2, num1.b * num2);
        }

        public static ComplexNumber operator *(ComplexNumber num1, float num2)
        {
            return new ComplexNumber(num1.a * num2, num1.b * num2);
        }

        public static ComplexNumber operator+ (ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber(num1.a + num2.a, num1.b + num2.b);
        }

        public static ComplexNumber operator -(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber(num1.a - num2.a, num1.b - num2.b);
        }

        public static ComplexNumber operator *(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber((num1.a* num2.a) - (num1.b * num2.b), (num1.a * num2.b) + (num2.a * num1.b));
        }

        public static ComplexNumber operator ^(ComplexNumber num1, int pow)
        {
            //Raise a complex number to a power

            ComplexNumber complexNumber = num1;
            //Multiply it pow number of times
            for (int i = 1; i < pow; i++)
            {
                complexNumber = complexNumber * num1;
            }

            return complexNumber;
        }

        public static ComplexNumber operator ^(ComplexNumber num1, ComplexNumber num2)
        {
            float a = num1.a;
            float b = num1.b;
            float c = num2.a;
            float d = num2.b;

            //Raise a complex number to a complex power
            return (float)Math.Pow((a * a) + (b * b), c / 2) * Math.Pow(Math.E,-d * num1.argument) *
                new ComplexNumber((float)Math.Cos((c * num1.argument) + (0.5 * d * Math.Log((a * a) + (b * b)))),
                                  (float)Math.Sin((c * num1.argument) + (0.5 * d * Math.Log((a * a) + (b * b)))));
        }


        public static ComplexNumber operator /(int num, ComplexNumber den)
        {
            den *= den.conjugate;

            float num1 = num;

            if (den.a == 0)
            {
                num1 = 9999999;
            }
            else
            {
                num1 /= den.a;
            }
            return new ComplexNumber(num1, 0);
        }

        public static ComplexNumber operator /(double num, ComplexNumber den)
        {
            den *= den.conjugate;

            if(den.a == 0)
            {
                num = 9999999;
            }
            else
            {
                num /= den.a;
            }
            return new ComplexNumber((float)num, 0);
        }

        public static ComplexNumber operator /(float num, ComplexNumber den)
        {
            den *= den.conjugate;

            if (den.a == 0)
            {
                num = 9999999;
            }
            else
            {
                num /= den.a;
            }
            return new ComplexNumber(num,0);
        }

        public static ComplexNumber operator / (ComplexNumber num, ComplexNumber den)
        {
            //Multiply numerator and denominator by conjugate
            num *= den.conjugate;
            den *= den.conjugate;

            //Prevent division by zero
            if (den.a == 0)
            {
                num.a = 99999999;
                num.b = 99999999;
            }
            else
            {
                //Divide numerator by real protion of denominator,
                //There is no complex portion
                num.a /= den.a;
                num.b /= den.a;
            }

            return num;
        }

        public override string ToString()
        {
            return a + " + " + b + "i";
        }
    }
}
