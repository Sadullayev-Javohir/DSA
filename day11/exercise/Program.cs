using System;
using System.Collections.Generic;
using System.Text;

// class Program
// {
//   static void Main()
//   {
//     Dictionary<string, int> Precedence = new Dictionary<string, int>()
//     {
//       {"+", 1}, {"-", 1},
//       {"*", 2}, {"/", 2},
//       {"^", 3}
//     };

//     bool IsOperator(string token) => Precedence.ContainsKey(token);

//     bool IsLeftAssociative(string op)
//     {
//       if (!IsOperator(op)) throw new ArgumentException($"{op} operator emas");
//       return op != "^";
//     }

//     string[] tokens = { "+", "-", "/", "^", "a" };
//     foreach (var t in tokens)
//     {
//       if (IsOperator(t)) Console.WriteLine($"Operator: {t}, Chapga massivmi? {IsLeftAssociative(t)}");
//       else Console.WriteLine($"{t} operator emas");
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     string expr = "3 + 4.5 * (2 - 1) ^ 2";
//     var tokens = Tokenize(expr);

//     Console.WriteLine("Tokenlar: ");
//     foreach (var t in tokens)
//     {
//       Console.WriteLine(t);
//     }
//   }

//   static List<string> Tokenize(string expr)
//   {
//     var tokens = new List<string>();
//     int i = 0;

//     while (i < expr.Length)
//     {
//       char c = expr[i];

//       if (char.IsWhiteSpace(c))
//       {
//         i++;
//         continue;
//       }

//       if (char.IsDigit(c) || c == '.')
//       {
//         var sb = new StringBuilder();
//         while (i < expr.Length && (char.IsDigit(expr[i]) || expr[i] == '.'))
//           sb.Append(expr[i++]);
//         tokens.Add(sb.ToString());
//         continue;
//       }

//       if ("+-*/^()".Contains(c))
//       {
//         tokens.Add(c.ToString());
//         i++;
//         continue;
//       }

//       throw new ArgumentException($"Noto'g'ri belgi: {c}");
//     }
//     return tokens;
//   }
// }



// class Program
// {
//   static void Main()
//   {
//     string expr = "   ";
//     int i = 0;

//     while (i < expr.Length)
//     {
//       char c = expr[i];
//       if (char.IsWhiteSpace(c))
//       {
//         Console.WriteLine($"Bo'sh joy topildi: '{c}' indeksi {i}");
//         i++;
//         continue;

//       }
//       Console.WriteLine("Bo'sh joy emas");
//       i++;
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     string matn = "3.14 7";
//     int i = 0;

//     while (i < matn.Length)
//     {
//       char c = matn[i];

//       if (char.IsDigit(c) || c == '.')
//       {
//         var sb = new StringBuilder();
//         while (i < matn.Length && (char.IsDigit(matn[i]) || matn[i] == '.'))
//         {
//           sb.Append(matn[i]);
//           i++;
//         }
//         Console.WriteLine(sb);
//         continue;
//       }
//       i++;
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     string expr = "+ - () * ^ /";
//     int i = 0;

//     while (i < expr.Length)
//     {
//       char c = expr[i];
//       if ("+-/*^()".Contains(c))
//       {
//         Console.WriteLine("Topildi: " + c);
//         i++;
//         continue;
//       }
//       i++;
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     string expr = "3 + a";
//     int i = 0;

//     while (i < expr.Length)
//     {
//       char c = expr[i];

//       if (!char.IsDigit(c) && !char.IsWhiteSpace(c) && !"+-/*()^".Contains(c))
//       {
//         throw new ArgumentException($"Noto'g'ri belgi: {c} indeksi: {i}");
//       }
//       i++;
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     string expr = "3.14 + (-7)";

//   }

//   public static List<string> Tokenize(string expr)
//   {
//     var tokens = new List<string>();
//     int i = 0;
//     int n = expr.Length;

//     while (i < n)
//     {
//       char c = expr[i];

//       if (char.IsWhiteSpace(c)) { i++; continue; }

//       if (char.IsDigit(c) || c == '.' || (c == '-' && (tokens.Count == 0 || tokens[tokens.Count - 1] == "(" || IsOperator(tokens[tokens.Count - 1]))))
//       {
//         var sb = new StringBuilder();
//         if (c == '-')
//         {
//           sb.Append('-');
//           i++;
//           if (i >= n) { tokens.Add(sb.ToString()); break; }

//         }
//       }

//       if (c == '(' || c == ')' || "+-/*^".IndexOf(c) >= 0)
//       {
//         tokens.Add(c.ToString());
//         i++;
//         continue;
//       }

//     }
//   }
//   private static bool IsOperator(string token)
//   {
//     return "+-*/^".Contains(token);
//   }
// }

class Program1
{
  static void Main()
  {
    string expr = "3   +   5";
    int i = 0;
    int n = expr.Length;
    var tokens = new List<string>();

    while (i < n)
    {
      char c = expr[i];
      if (char.IsWhiteSpace(c))
      {
        i++;
        continue;
      }
      tokens.Add(c.ToString());
      i++;
    }

    tokens.ForEach(Console.WriteLine);
  }
}


class Program
{
  static void Main()
  {
    string expr = "( 3 + 5 ) * 2";
    int i = 0;
    int n = expr.Length;
    var tokens = new List<string>();

    while (i < n)
    {
      char c = expr[i];

      if (c == '(' || c == ')' || "*+-^/".IndexOf(c) >= 0)
      {
        tokens.Add(c.ToString());
        i++;
        continue;
      }
      i++;
    }

    tokens.ForEach(Console.WriteLine);
  }
}


