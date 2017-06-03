using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja1.Szachownica
 {
 private string[,] plansza;

 public Szachownica()
  {
  plansza=new string[8,8];
  }

 public string this[char x, int y]
  {
  get
  {
 return plansza[x-65,y];
  }
  set
  {
  plansza[x-65,y]=value;
  }
 }

 {
 Szachownica sz=new Szachownica();
 sz['A',1]="test"
 Console.WriteLine(sz['A',1]);
 }
}
