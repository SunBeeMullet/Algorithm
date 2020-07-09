using System;

class MainClass {
  public static void Main (string[] args) {
    string i,j;
    int a,b,ans,b0,b1,b2;

    i = Console.ReadLine();

    string[] tokens_0 = i.Split();
    a = int.Parse(tokens_0[0]);
    j = tokens_0[1];

    char[] tokens_1 = j.ToCharArray();
    b0 = tokens_1[0];
    b1 = tokens_1[1];
    b2 = tokens_1[2];
    b = int.Parse(tokens_0[1]);

    ans = a*b0;
    Console.WriteLine (ans);
    ans = a*b1;
    Console.WriteLine (ans);
    ans = a*b2;
    Console.WriteLine (ans);
    ans = a*b;
    Console.WriteLine (ans);
  }
}