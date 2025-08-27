class Program
{
  static bool IsPalindromeAlnum(string s)
  {
    if (string.IsNullOrEmpty(s)) return true;

    int i = 0, j = s.Length - 1;
    while (i < j)
    {
      while (i < j && !char.IsLetterOrDigit(s[i])) i++;
      while (i < j && !char.IsLetterOrDigit(s[j])) j--;

      if (char.ToLowerInvariant(s[i]) != char.ToLowerInvariant(s[j])) return false;
      i++; j--;
    }
    return true;
  }

  static void Main()
  {
    Console.WriteLine(IsPalindromeAlnum("1mum1"));
  }
}

// class Program
// {
//   static List<int> FindAnagram(string s, string p)
//   {
//     var res = new List<int>();
//     if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(p) || p.Length > s.Length) return res;

//     int[] need = new int[26];
//     int[] window = new int[26];

//     foreach (var c in p) need[c - 'a']++;

//     int left = 0;
//     for (int right = 0; right < s.Length; right++)
//     {
//       window[s[right] - 'a']++;

//       if (right - left + 1 > p.Length)
//       {
//         window[s[left] - 'a']--;
//         left++;
//       }
//       if (right - left + 1 == p.Length)
//       {
//         bool match = true;
//         for (int k = 0; k < 26; k++)
//         {
//           if (window[k] != need[k]) {match = false; break;}
//         }
//         if (match) res.Add(left);
//       }
//     }
//     return res;
//   }
//   static void Main()
//   {
//     string s = "cbaebabacd";
//     string p = "abc";

//     var result = FindAnagram(s, p);

//     foreach (var i in result)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }

// class Program
// {
//   static bool AreAnagrams(string s, string t)
//   {
//     if (s == null || t == null) return false;
//     if (s.Length != t.Length) return false;

//     var freq = new Dictionary<char, int>();

//     foreach (var ch in s)
//     {
//       if (freq.ContainsKey(ch)) freq[ch]++;
//       freq[ch] = 1;
//     }

//     foreach (var ch in t)
//     {
//       if (!freq.ContainsKey(ch)) return false;
//       freq[ch]--;
//       if (freq[ch] == 0) freq.Remove(ch);
//     }
//     return freq.Count == 0;
//   }

//   // static bool IsAnagram(string s, string t)
//   // {
//   //   if (s == null || t == null) return false;
//   //   if (s.Length != t.Length) return false;

//   //   var freq = new Dictionary<char, int>();
//   //   foreach (var ch in s)
//   //   {
//   //     if (freq.ContainsKey(ch)) freq[ch]++;
//   //     freq[ch] = 1;
//   //   }
//   //   foreach (var ch in t)
//   //   {
//   //     if (!freq.ContainsKey(ch)) return false;
//   //     freq[ch]--;
//   //     if (freq[ch] == 0) freq.Remove(ch);
//   //   }
//   //   return freq.Count == 0;
//   // }

//   static bool IsAnagram(string s, string t)
//   {
//     if (s == null || t == null) return false;
//     if (s.Length != t.Length) return false;

//     int[] counts = new int[26];

//     for (int i = 0; i < s.Length; i++)
//     {
//       counts[s[i] - 'a']++;
//       counts[t[i] - 'a']--;
//     }

//     for (int i = 0; i < 26; i++)
//     {
//       if (counts[i] != 0) return false;
//     }
//     return true;
//   }

//   static void Main()
//   {
//     Console.WriteLine(IsAnagram("anagram", "nagrama"));
//   }
// }

