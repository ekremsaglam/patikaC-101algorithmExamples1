using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace algorithmExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uygulamaya Hoşgelidiniz.");
            firstTask();
            secondTask();
            thirdTask();
            fourthTask();

        }//main end
        public static void firstTask(){
            Console.WriteLine("****************************");
            Console.Write("Lütfen gireceğeniz sayı miktarını giriniz : ");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("\nLütfen aralarında birer boşluk bırakar {0} tane sayıyı giriniz. ", n );
            string[] sayilarString = new string[n];
            sayilarString = (Console.ReadLine().Split(" "));
            int[] sayilar = new int[n];
            for(int i= 0 ; i<n ; i++){
                sayilar[i]= int.Parse(sayilarString[i]);
            }
            foreach(int i in sayilar){
                if(i%2==0){
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\n****************************");
        }//firstTask end

        public static void secondTask(){
            Console.WriteLine("Lütfen iki pozitif sayı giriniz.");
            int birinciDeger = int.Parse(Console.ReadLine());
            int ikinciDeger = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen {0} adet sayıyı birer boşluk bırakarak giriniz.",birinciDeger);

            string[] sayilarString = new string[birinciDeger];
            sayilarString = (Console.ReadLine().Split(" "));
            int[] sayilar = new int[birinciDeger];
            for(int i= 0 ; i<birinciDeger ; i++){
                sayilar[i]= int.Parse(sayilarString[i]);
            }
            foreach(int i in sayilar){
                if(i%ikinciDeger==0){
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\n****************************");
        }//secondTask end           
        public static void thirdTask(){
            Console.Write("Lütfen pozitif bir sayı giriniz : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nLütfen {0} adet kelimeyi birer boşluk bırakarak giriniz.",n);
            string[] kelimeler = new string[n];
            kelimeler = (Console.ReadLine().Split(" "));
            for(int i=(n-1) ; i>=0 ; i--){
                Console.WriteLine(kelimeler[i]);
            }
        }//thirdTask end 
        public static void fourthTask(){
            Console.WriteLine("Lütfen bir cümle yazınız.");
            List<string> kelimeler = new List<string>();
            foreach(string s in (Console.ReadLine().Split(" "))){
                kelimeler.Add(s);
            }
            Console.WriteLine("Kelime sayısı : " + kelimeler.Count);

            ArrayList charArraylist = new ArrayList();
            char[] specialChar = {'.',',',';',':','"','#','%','*'};
            foreach (string kelime in kelimeler){
                foreach (char c in kelime){
                    if(!specialChar.Contains(c)){
                        charArraylist.Add(c);
                    }
                }
            }     
            Console.WriteLine("Harf sayısı : " + charArraylist.Count);
        }//fourthTask end


    }
}
