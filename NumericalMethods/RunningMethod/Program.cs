namespace RunningMethod
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            const int n = 4;

            var k = new double[n];
            var m = new double[n];
            var t = new double[n];
            var p = new double[n];
            var q = new double[n];
            var x = new double[n];

            //var a = new[,]
            //        {
            //            { 4.5, 0.5, 0, 0 },
            //            { 1, 2.6, 0.9, 0 },
            //            { 0, 0.4, 2.5, 0.5 },
            //            { 0, 0, 0.5, 1.5 }
            //        };

            //var b = new double[] { 1, 0, 1, 0 };


            var a = new[,]
                        {
                            { 2, 1, 0, 0 },
                            { 1, 10, -5, 0 },
                            { 0, 1, -5, 2 },
                            { 0, 0, 1, 4 }
                        };

            var b = new double[] { -5, -18, -40, -27 };

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    k[i] = 0;
                    m[i] = 1;
                }
                else
                {
                    k[i] = a[i, i - 1];
                    m[i] = -a[i, i];
                }

                if (i == n - 1)
                {
                    t[i] = 0;
                }
                else
                {
                    t[i] = a[i, i + 1];
                }
            }

            p[0] = t[0] / m[0];
            q[0] = -b[0] / m[0];

            for (int i = 1; i < n; i++)
            {
                p[i] = -t[i] / (k[i] * p[i - 1] - m[i]);
                q[i] = (b[i] - k[i] * q[i - 1]) / (k[i] * p[i - 1] - m[i]);
            }

            x[n - 1] = (b[n - 1] - k[n - 1] * q[n - 2]) / (k[n - 1] * p[n - 2] - m[n - 1]);

            for (int i = n - 2; i > 0; i--)
            {
                x[i] = p[i] * x[i + 1] + q[i];
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"x({i}) = {x[i]}");
            }

            // true: x0 = -3 x1 = 1 x2 = 5 x4 = -8

            Console.ReadLine();

        }


        /*
         program lalala;
const n=4;
var i,j:integer;
a:array[1..n,1..n] of real;
b,x,k,m,t,p,q:array[1..n] of real;
tmp:real;
 
begin
for i:=1 to n do
    begin
    for j:=1 to n do
        begin
        write('a(',i,',',j,')=');
        readln(a[i,j]);
        end;
    write('b(',i,')=');
    readln(b[i]);
    end;
   
for i:=1 to n do
    begin
    if i=1 then
       k[i]:=0
    else
        k[i]:=a[i,i-1];
        m[i]:=-a[i,i];
    if i=n then
        t[i]:=0
    else
        t[i]:=a[i,i+1];
    end;
   
p[1]:=t[1]/m[1];
q[1]:=-b[1]/m[1];
for i:=2 to n do
    begin
    p[i]:=-t[i]/(k[i]*p[i-1]-m[i]);
    q[i]:=(b[i]-k[i]*q[i-1])/(k[i]*p[i-1]-m[i]);
    end;
 
x[n]:=(b[n]-k[n]*q[n-1])/(k[n]*p[n-1]-m[n]);
for i:=n-1 downto 1 do
    x[i]:=p[i]*x[i+1]+q[i];
   
for i:=1 to n do
    writeln('x(',i,')=',x[i]);
end.
         */
    }
}
