using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpFundementals
{
  class LeetCode
  {
    public string LongestCommonPrefix(string[] strs)
    {
      if (strs.Length == 0) return "";
      string pre = strs[0];
      for (int i = 1; i < strs.Length; i++)
        while (strs[i].IndexOf(pre) != 0)
          pre = pre.Substring(0, pre.Length - 1);
      return pre;
    }
    public bool IsParenthesesValid(string s)
    {
      //() help from the future --- use a stack
      var checker = new Dictionary<char, char>();
      checker.Add('(', ')');
      checker.Add('[', ']');
      checker.Add('{', '}');

      //var checker1 = (title:"Lost", author: "Sam");
      bool results = false;
      for (int i = 0; i < s.Length; i++)
      {
        if (checker.ContainsKey(s[i]))
        {
          if (s.IndexOf(checker[s[i]]) == 0)
          {
            results = false;
          }
          else
          {
            results = true;
          }
        }
      }
      return results;

    }
  }
}
