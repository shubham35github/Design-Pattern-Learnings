



using System.ComponentModel.Design;
using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

             bool res=Pal("");
             Console.WriteLine(res);



             int[] arr = {1,2,3,4,5};
           

            if(Enum.TryParse("shubham", out Values va))
            {
                Console.WriteLine("yes");

            }
            else
            {
                Console.WriteLine(va);

            }

            int[] resArr = ProductUsingDev(arr);
             for (int i = 0; i < arr.Length; i++)
             {
                 Console.WriteLine(resArr[i]);
             }
             resArr = ProductWithoutUsingDev(arr);
             for (int i = 0; i < arr.Length; i++)
             {
                 Console.WriteLine(resArr[i]);
             }
             string s = "[()]{}{[()()]()}";
             bool isBal = BalanceParenthesis(s);
             Console.WriteLine(isBal);

             Console.WriteLine("Lengest parenthesis={0}",LongestParenthesis("()(()))))"));
             Console.WriteLine("((() Lengest parenthesis={0}", LongestParenthesis("((()"));
             RemoveAdjacentDupicates("careermonk");

             Queue<int> queue = new Queue<int>();
             queue.Enqueue(1);
             queue.Enqueue(2);
             queue.Enqueue(3);
             queue.Enqueue(4);
             queue.Enqueue(5);
             queue = ReverseQueue(queue);
             while(queue.Count > 0)
             {
                 Console.WriteLine(queue.Dequeue());
             }
        }
        public enum Values : ushort
        {
            ABNORM = 0,
            ABSENT = 4,
            CONTAM = 14
        }
        private static int LongestParenthesis(string v)
        {
            Stack<char> stack = new Stack<char>();
            int cnt = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (IsOpenBrace(v[i]))
                {
                    stack.Push(v[i]);
                }
                else
                {
                    if (stack.Count > 0 && CheckClosingBrace(v[i], stack.Pop()))
                    {
                        cnt = cnt + 2;
                    }
                }
            }
            return cnt;
        }

         

             public int[] productExceptSelf(int[] nums)
             {
                 int numsLength = nums.Length;
                 int prefixProduct = 1;
                 int suffixProduct = 1;
                 int[] result = new int[numsLength];
                 for (int i = 0; i < numsLength; i++)
                 {
                     result[i] = prefixProduct;
                     prefixProduct *= nums[i];
                 }
                 for (int i = numsLength - 1; i >= 0; i--)
                 {
                     result[i] *= suffixProduct;
                     suffixProduct *= nums[i];
                 }
                 return result;
             }















             private static Queue<int> ReverseQueue(Queue<int> queue)
         {
            Stack<int> stack = new Stack<int>();
             while (queue.Count > 0)
             {
                 stack.Push(queue.Dequeue());
             }
             while (stack.Count > 0)
             {
                 queue.Enqueue(stack.Pop());
             }
             return queue;
         }

         private static void RemoveAdjacentDupicates(string str)
         {
             Stack<char> stack = new Stack<char>();
             int i ;
             for (i = 0;i<str.Length;i++)
             {

                 if (stack.Count == 0 || str[i] != stack.Peek())
                 {
                     stack.Push(str[i]);
                 }
                 else
                 {
                     stack.Pop();
                 }
             }
             i= stack.Count-1;
             while(stack.Count>0)
             {
                 Console.WriteLine(stack.Pop());

             }
         }

         private static bool BalanceParenthesis(string s)
         {
             Stack<char> stack = new Stack<char>();
             foreach (char item in s)
             {
                 if (IsOpenBrace(item))
                 {
                     stack.Push(item);
                     Console.WriteLine(item);
                 }
                 else
                 {
                     if(!CheckClosingBrace(item,stack.Pop()))
                     {
                         return false;
                     }
                 }
             }
             return false;
         }

         private static bool CheckClosingBrace(char item, char popItem)
         {
             if (popItem == '[' && item==']')
             {
                 return true;
             }
             else if(popItem == '{' && item == '}')
             {
                 return true;
             }
             else if(popItem == '(' && item == ')')
             {
                 return true;
             }
             return false; 
         }

         private static bool IsOpenBrace(char item)
         {
             if(item=='[' || item == '{' || item == '(')
             {
                 return true;
             }
             return false;
         }

         private static int[] ProductUsingDev(int[] arr)
         {

             int[] prod = new int[arr.Length];
             int totalProd = 1;
             for(int i = 0;i< arr.Length; i++)
             {
                 totalProd = totalProd*arr[i];
             }
             for(int i = 0; i< arr.Length; i++)
             {
                 prod[i] = totalProd/arr[i];
             }
             return prod;
         }

         private static int[] ProductWithoutUsingDev(int[] arr)
         {
             int[] prod = new int[arr.Length];
             int totalProd = 1;
             for (int i = 0; i < arr.Length; i++)
             {
                 totalProd = totalProd * arr[i];
             }
             for (int i = 0; i < arr.Length; i++)
             {
                 prod[i] = totalProd / arr[i];
             }
             return prod;
         }

         static bool Pal(string s)
         {
             int left = 0;
             int right= s.Length - 1;
             while(left < right)
             {
                 if (s[left] == s[right])
                 {
                     left++;
                     right--;
                 }
                 else
                 {
                     return false;
                 }
             }
             return true;
         }
    }
}
