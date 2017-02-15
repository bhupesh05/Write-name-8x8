using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This is console application...
//console clear and setcurserpositon are used so it will not work here..
//This program will work on vs code , vs studio and in any c# compiler (cse)... 
//You can copy it to run in your desktop...
//This program is create by Bhupesh singh 
//Bilaspur India.

namespace Alphabat8x8
{

    class Program
    {
        static ulong getbin(char ch)
        {
            ulong b=0xfffffffffffff8ff;
            switch(ch)
            {
                case 'a': b=0x3cffc3c3ffffc3c3; break;
                case 'b': b=0xf8fcc6fcfec3fefc; break;
                case 'c': b=0x3effc0c0c0c0ff3e; break;
                case 'd': b=0xf8fec3c3c3c3fef8; break;
                case 'e': b=0xffffc0fcfcc0ffff; break;
                case 'f': b=0xffffc0fcfcc0c0c0; break;
                case 'g': b=0x3effc0c0c7c3ff3e; break;
                case 'h': b=0xc3c3c3ffffc3c3c3; break;
                case 'i': b=0x7e7e181818187e7e; break;
                case 'j': b=0x7f7f0c0c0cccfc78; break;
                case 'k': b=0xc3c6ccf8f8ccc6c3; break;
                case 'l': b=0xc0c0c0c0c0c0ffff; break;
                case 'm': b=0xc3e7ffdbc3c3c3c3; break;
                case 'n': b=0xc3e3f3dbdbcfc7c3; break;
                case 'o': b=0x3cffc3c3c3c3ff3c; break;
                case 'p': b=0xfeffc3fffcc0c0c0; break;
                case 'q': b=0x7cfec6c6c6defe7b; break;
                case 'r': b=0xfeffc3fef8ccc6c3; break;
                case 's': b=0x7effc0fc3f03ff7e; break;
                case 't': b=0xffff181818181818; break;
                case 'u': b=0xc3c3c3c3c3c3ff3c; break; 
                case 'v': b=0xc3c3c3c3c3663c18; break; 
                case 'w': b=0xc3c3c3c3dbffe7c3; break;
                case 'x': b=0xc3c3661c3866c3c3; break;
                case 'y': b=0xc3c3663c18181818; break;
                case 'z': b=0xffff060c1870ffff; break;
                case ' ': b=0x0000000000000000; break;
                case '!': b=0x1818181818001818; break;
                case '0': b=0x3cffc3d3cbc3ff3c; break;
                case '1': b=0x1838381818187e7e; break;
                case '2': b=0x7effc3061860ffff; break;
                case '3': b=0x7effc30e0ec3ff7e; break;
                case '4': b=0xc3c3c3ff7f030303; break;
                case '5': b=0xffffc0fe7f03ff7e; break;
                case '6': b=0x7fffc0feffc3ff7e; break;
                case '7': b=0xffff03060c181818; break;
                case '8': b=0x7effc37e7ec3ff7e; break;
                case '9': b=0x7effc3ff7f03fffe; break;                
                default:  b=0xffffffffffffffff; break;
            }
            return b;
        }
        static void Main()
        {
            ulong cha=0x3cffc3c3ffffc3c3;
            const ulong bit=0x8000000000000000;
            Console.WriteLine("This program is create by Bhupesh singh\n Bilaspur India.\n");
            Console.WriteLine("Your Name \n");
            string name="hi "+Console.ReadLine().ToLower()+"!";
            Console.WriteLine("Enter a Character to fill");
            char ch=Console.ReadLine()[0];
            Console.Clear();
            int len=name.Length;
            int x=0,y=0,w=1,z=0,k=1;
            for(z=0;z<len;z++,w+=9)
             {
                if(w>70) {  w=2;   k+=9;   }
                
                if(k>20) {    Console.Write("Console space full"); Console.ReadKey();    return;    }

                cha=getbin(name[z]);
    
                for(y=0;y<64;y++,x++)
                {         
                        if((cha & bit)==bit)
                        {
                            Console.SetCursorPosition(x%8+w,y/8+k);
                            Console.Write(ch);
                        } 
                        cha<<=1;
                }
             } 
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
