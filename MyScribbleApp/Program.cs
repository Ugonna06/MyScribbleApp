using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MyScribbleApp
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello World");

            //string help = AcronymMethod("Ugonna", false, 4);
            //string testInit = InitString("TobiSamuel", 6);

            //var test = SelectIndexes(8, 4);
            ////test.ForEach(Console.WriteLine);

            ////Console.WriteLine(testInit);
            // Console.WriteLine(testInit);

            //var tet = WordPattern("abba", "dog cat cat dog");

            //      foreach (var item in tet)
            //      {
            //		Console.WriteLine(item);
            //      }

            //var t = new int[] { 2,4,10 };

            //var test = ValidateIPAddressv2("22.22.2.01");

            //Console.WriteLine(test);

            //string wordTest = "dog cat dog";
            //string wordPatten = "aba";

            //Console.WriteLine(wordPattern(wordPatten, wordTest));

            //int[] nums = new int[3] { 3, 2, 4 };
            //int target = 6;

            //Console.WriteLine(TwoSum(nums, target));

            //LinkedList<string> myList = new LinkedList<string>();

            //myList.AddLast("AAA");
            //myList.AddLast("BBB");
            //myList.AddLast("CCC");
            //myList.AddLast("DDD");

            //myList.AddFirst("111");

            //LinkedListNode<string> node = myList.Find("BBB");
            //myList.AddAfter(node, "BBB-2");

            //foreach (var item in myList)
            //      {
            //		Console.WriteLine(item);
            //      }

            //LinkedList linkedList = new LinkedList();
            //linkedList.AddNodeToFront(5);
            //linkedList.AddNodeToFront(7);
            //linkedList.AddNodeToFront(1);
            //linkedList.AddNodeToFront(5);
            //linkedList.AddNodeToFront(17);
            //linkedList.AddNodeToFront(30);
            //linkedList.AddNodeToFront(68);
            //linkedList.AddNodeToFront(2);
            //linkedList.AddNodeToFront(10);

            //linkedList.PrintList();

            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = { 4, 5, 6 };
            //int array1OriginalLength = arr1.Length;
            //Array.Resize<int>(ref arr1, array1OriginalLength + arr2.Length);
            //Array.Copy(arr2, 0, arr1, array1OriginalLength, arr2.Length);
            //foreach (var e in arr1)
            //{
            //		Console.WriteLine(e);
            //}

            //int[] arr3 = { 1, 2, 3 };
            //int[] arr4 = { 4, 5, 6 };
            //arr3 = arr3.Concat(arr4).ToArray();
            //foreach (var e in arr3)
            //{
            //		Console.WriteLine(e);
            //}

            //Console.WriteLine(RomanToInt("MCMXCIV"));


            //List<int> a = new List<int>();
            //a.Add(1);
            //a.Add(2);
            //a.Add(3);

            //List<int> b = new List<int>();
            //b.Add(4);
            //b.Add(5);
            //b.Add(6);

            //List<int> c = new List<int>();
            //c.Add(9);
            //c.Add(8);
            //c.Add(9);

            //List<List<int>> test = new List<List<int>>();
            //test.Add(a);
            //test.Add(b);
            //test.Add(c);

            //Console.WriteLine(TunjiXMatrixSum(test));

            //Console.WriteLine(OccurenceCount(new int[] { 25, 2, 3, 57,38,41 }));
            List<string> a = new List<string>() { "INSERT", "fries", "4" };
            List<string> b = new List<string>() { "INSERT", "soda", "2" };
            List<string> c = new List<string>() { "VIEW", "-", "-" };
            List<string> d = new List<string>() { "VIEW", "-", "-" };
            List<string> e = new List<string>() { "INSERT", "hamburger", "5" };
            List<string> f = new List<string>() { "VIEW", "-", "-" };
            List<string> g = new List<string>() { "INSERT", "nuggets", "4" };
            List<string> h = new List<string>() { "INSERT", "cookie", "1" };
            List<string> i = new List<string>() { "VIEW", "-", "-" };
            List<string> j = new List<string>() { "VIEW", "-", "-" };
            List<string> k = new List<string>() { "INSERT", "fries", "4" };
            List<string> l = new List<string>() { "INSERT", "soda", "2" };
            List<string> m = new List<string>() { "VIEW", "-", "-" };
            List<string> n = new List<string>() { "VIEW", "-", "-" };
            List<string> o = new List<string>() { "INSERT", "hamburger", "5" };
            List<string> p = new List<string>() { "VIEW", "-", "-" };
            List<string> q = new List<string>() { "INSERT", "nuggets", "4" };
            List<string> r = new List<string>() { "INSERT", "cookie", "1" };
            List<string> s = new List<string>() { "VIEW", "-", "-" };
            List<string> t = new List<string>() { "VIEW", "-", "-" };



            List<List<string>> testcase = new List<List<string>>() { a, b, c, d, e, f, g, h, i, j, k,l ,m ,n,o,p,q,r,s,t };


            Console.WriteLine(getItems(testcase));

        }

        public static int ValidateIPAddress(string IP)
        {
            var result = 0;
            var splitIP = IP.Split('.');
            if (splitIP.Length != 4)
            {
                result = 0;
            }
            else
            {
                if (splitIP[0] == null || splitIP[1] == null || splitIP[2] == null || splitIP[3] == null || splitIP[0] == string.Empty || splitIP[1] == string.Empty || splitIP[2] == string.Empty || splitIP[3] == string.Empty)
                {
                    result = 0;
                }
                else
                {
                    for (var i = 0; i < splitIP.Length; i++)
                    {
                        var numbers = splitIP[i];
                        if (numbers.StartsWith("0"))
                        {
                            result = 0;
                            break;
                        }
                    }
                    result = 1;

                }
            }

            return result;
        }

        public static int ValidateIPAddressv2(string IP)
        {
            var result = 0;
            var splitIP = IP.Split('.');
            if (splitIP.Length != 4)
            {
                result = 0;
            }
            else
            {
                if (splitIP[0] == null || splitIP[1] == null || splitIP[2] == null || splitIP[3] == null || splitIP[0] == string.Empty || splitIP[1] == string.Empty || splitIP[2] == string.Empty || splitIP[3] == string.Empty)
                {
                    result = 0;
                }
                else
                {
                    for (var i = 0; i < splitIP.Length; i++)
                    {
                        var numbers = splitIP[i];
                        if (numbers.StartsWith("0"))
                        {
                            result = 0;
                            break;
                        }
                        else
                        {
                            for (var j = 0; j < numbers.Length; j++)
                            {
                                if (numbers[j] >= 0 && numbers[j] <= 9)
                                {
                                    result = 1;
                                    continue;
                                }
                            }

                            var number = int.Parse(numbers);
                            if (number >= 0 && number <= 255)
                            {
                                result = 1;
                                continue;
                            }
                            else
                            {
                                result = 0;
                                break;
                            }
                        }
                    }
                }
            }

            return result;
        }


        public static int oddTest(int[] myList)
        {
            int sum = 1;

            foreach (var item in myList)
            {
                var itum = item * sum;
                sum = itum;
            }

            if (sum % 2 != 0) return 0;

            return sum;
        }

        public static List<char> WordPattern(string pattern, string s)
        {
            var pat = pattern.ToCharArray();
            var str = s.Split(" ");
            var testPat = pat.Distinct().ToList();

            return testPat;
        }

        public static string AcronymMethod(string para, bool? mode, int codelength)
        {
            //mode of true creates an acronym of the first four letters while mode of false creates an acronym with the first, last and any other two characters
            string x = para.Trim();
            x = RemoveSpecialCharacters(x);
            string result = String.Empty;

            if (x.Length > 4)
            {
                if (x.Contains(' '))
                {

                }
                else
                {
                    result = mode == true ? x.Substring(0, codelength).ToUpper() : InitString(x, codelength);
                }
            }
            else
            {
                result = x.ToUpper();
            }
            return result;
        }

        public static string InitSpacedString(string fullstring)
        {


            return "";
        }

        public static string InitString(string fullstring, int codeLength)
        {
            string init = CreateCodePlaceHolder(codeLength);

            var indexes = SelectIndexes(fullstring.Length - 1, codeLength - 2);

            StringBuilder sb = new StringBuilder(init);
            sb[0] = fullstring[0];
            sb[init.Length - 1] = fullstring[fullstring.Length - 1];

            for (int i = 1; i <= codeLength - 2; i++)
            {
                sb[i] = fullstring[indexes.ElementAt(i - 1)];
            }
            string result = sb.ToString().ToUpper();
            return result;
        }

        public static string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c == ' '))
                {
                    sb.Append(c);
                }
                if (c == '/')
                {
                    sb.Append(' ');
                }
            }
            return sb.ToString();
        }

        public static Tuple<int, int> SelectIndex(int maxLength)
        {
            Random rnd = new Random();
            int firstNum = rnd.Next(1, maxLength - 1);
            int secondNum = rnd.Next(firstNum + 1, maxLength);
            Tuple<int, int> numSet = new Tuple<int, int>(firstNum, secondNum);
            return numSet;
        }

        public static List<int> SelectIndexes(int maxLength, int noOfIndexes)
        {
            List<int> result = new List<int>();
            Random rnd = new Random();
            int numb = 1;
            int inddd = noOfIndexes - 1;

            for (var i = 1; i <= noOfIndexes; i++)
            {
                numb = rnd.Next(numb, maxLength - inddd);
                result.Add(numb);
                ++numb;
                --inddd;
            }
            return result;
        }

        public static string CreateCodePlaceHolder(int codeLength)
        {
            StringBuilder sb = new StringBuilder();
            for (var i = 1; i <= codeLength; i++)
            {
                sb.Append('_');
            }
            return sb.ToString();
        }

        public static bool wordPattern(string pattern, string s)
        {
            List<char> patternArr = new List<char>();
            var sArr = s.Split(' ');

            foreach (char item in pattern)
            {
                patternArr.Add(item);
            }

            if (patternArr.Count() != sArr.Count()) return false;

            var reducedPat = patternArr.Distinct().ToArray();
            var reducedStr = sArr.Distinct().ToArray();

            if (reducedPat.Count() != reducedStr.Count()) return false;

            for (int i = 0; i < patternArr.Count; i++)
            {
                int patIndex = Array.IndexOf(reducedPat, patternArr[i]);
                int strIndex = Array.IndexOf(reducedStr, sArr[i]);

                if (patIndex != strIndex) return false;
            }
            return true;
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            for (int i = 0; i < nums.Count(); i++)
            {
                int rem = target - nums[i];

                int testCheck = Array.IndexOf(nums, rem, i + 1);

                if (testCheck > 0)
                {
                    result[0] = i;
                    result[1] = testCheck;
                    return result;
                }
            }
            return result;
        }

        public class ListNode
        {
            public int data;
            public ListNode next;

            public ListNode(int x)
            {
                this.data = x;
                this.next = null;
            }
        }

        public class LinkedList
        {
            ListNode head;
            int count;

            public LinkedList()
            {
                head = null;
                count = 0;
            }

            public void AddNodeToFront(int data)
            {
                ListNode node = new ListNode(data);
                node.next = head;
                head = node;
                count++;
            }

            public void AddNodeBehind(int data)
            {
                ListNode node = new ListNode(data);
                ListNode runner = head;

            }

            public void PrintList()
            {
                ListNode runner = head;
                while (runner != null)
                {
                    Console.WriteLine(runner.data);
                    runner = runner.next;
                }
            }
        }

        public static int RemoveDuplicates(int[] nums)
        {
            int[] disNum = nums.Distinct().ToArray();
            int res = nums.Count() - disNum.Count();
            return res;
        }


        public static int segment(int x, List<int> space)
        {
            int combo = space.Count() - (x - 1);
            List<int> resArr = new List<int>();

            for (int i = 0; i < combo; i++)
            {
                List<int> tes = new List<int>();
                for (int j = i; j < (x + i); j++)
                {
                    tes.Add(space[j]);
                }
                resArr.Add(tes.Min());
            }

            int res = resArr.Max();

            return res;
        }

        public static long prison(int n, int m, List<int> h, List<int> v)
        {
            List<int> horizontalBars = new List<int>();
            for (int i = 0; i <= n + 1; i++)
            {
                horizontalBars.Add(i);
            }

            List<int> verticalBars = new List<int>();
            for (int i = 0; i < m; i++)
            {
                verticalBars.Add(i);
            }

            foreach (var item in h)
            {
                int rem = horizontalBars.Find(a => a == item);
                horizontalBars.Remove(rem);
            }

            foreach (var item in v)
            {
                int rem = verticalBars.Find(a => a == item);
                verticalBars.Remove(rem);
            }

            int largestVSpace = 0;
            int largestHSpace = 0;

            for (int i = 0; i < verticalBars.Count(); i++)
            {
                int selected = verticalBars[i];
                int next = verticalBars.Count() - 1;
                if (i++ < verticalBars.Count())
                {
                    next = verticalBars[i + 1];
                }
                if (next > largestVSpace)
                {
                    largestVSpace = next;
                }
            }

            for (int i = 0; i < horizontalBars.Count(); i++)
            {
                int selected = horizontalBars[i];
                int next = horizontalBars.Count() - 1;
                if (i++ < horizontalBars.Count())
                {
                    next = horizontalBars[i + 1];
                }
                if (next > largestHSpace)
                {
                    largestHSpace = next;
                }
            }

            long res = largestVSpace * largestHSpace;

            return res;
        }

        public static List<int> getUnallottedUsers(List<List<int>> bids, int totalShares)
        {
            List<int> res = new List<int>();
            int iter = bids.Count();

            for (int i = 0; i < iter; i++)
            {
                int highestBidder = 0;
                int timestamp = 0;

                foreach (var item in bids)
                {
                    int bid = item[2];
                    int bidTime = item[3];

                    if (bid >= highestBidder)
                    {
                        if (highestBidder == bid)
                        {
                            if (bidTime < timestamp)
                            {
                                highestBidder = bid;
                                timestamp = bidTime;
                            }
                        }
                        else
                        {
                            highestBidder = bid;
                            timestamp = bidTime;
                        }
                    }
                }

                var buyer = bids.Where(a => a[2] == highestBidder && a[3] == timestamp).FirstOrDefault();

                totalShares = totalShares - buyer[1];
                bids.Remove(buyer);

                if (totalShares <= 0)
                {
                    foreach (var item in bids)
                    {
                        res.Add(item[0]);
                    }
                    break;
                }
            }

            return res;
        }

        public static int getNearestSum(int[] arr, int sum)
        {
            int nearestNum = 0;
            int ret = 0;

            for (int i = 0; i < arr.Count(); i++)
            {

                for (int j = i + 1; j < arr.Count(); j++)
                {
                    int t = arr[i] + arr[j];

                    if (t < sum && t > nearestNum)
                    {
                        ret = t;
                    }
                    nearestNum = t;
                }

            }
            return ret;
        }

        public static bool IsPalindrome(int x)
        {
            string palX = x.ToString();

            for (int i = palX.Length - 1; i >= 0; i--)
            {
                int invPos = (palX.Length - 1) - i;
                if (palX[i] != palX[invPos])
                {
                    return false;
                }
            }
            return true;
        }

        public static int RomanToInt(string s)
        {
            int arabicNum = 0;

            Dictionary<char, int> romNumeerals = new Dictionary<char, int>();
            romNumeerals.Add('I', 1);
            romNumeerals.Add('V', 5);
            romNumeerals.Add('X', 10);
            romNumeerals.Add('L', 50);
            romNumeerals.Add('C', 100);
            romNumeerals.Add('D', 500);
            romNumeerals.Add('M', 1000);

            for (int i = 0; i < s.Length; i++)
            {
                int currentVal = romNumeerals[s[i]];
                int nextVal = i >= (s.Length - 1) ? 0 : romNumeerals[s[i + 1]];
                if (currentVal < nextVal)
                {
                    arabicNum = arabicNum - currentVal;
                    continue;
                }
                arabicNum = arabicNum + currentVal;
            }

            return arabicNum;
        }

        public static List<int> Compare(List<int> a, List<int> b)
        {
            List<int> result = new List<int>();
            int result1 = 0;
            int result2 = 0;

            for (int i = 0; i < a.Count(); i++)
            {
                if (a[i] > b[i])
                {
                    result1 += 1;
                }
                else if (a[i] < b[i])
                {
                    result2 += 1;
                }
            }

            result.Add(result1);
            result.Add(result2);

            return result;

        }

        public static int TunjiXMatrixSum(List<List<int>> matrix)
        {
            int sum = 0;
            int invPos, eleFront, eleBack;

            for (int i = 0; i < matrix.Count(); i++)
            {
                invPos = (matrix.Count - 1) - i;

                eleFront = matrix.ElementAt(i).ElementAt(i);
                eleBack = matrix.ElementAt(i).ElementAt(invPos);
                sum = sum + (eleFront - eleBack);
            }
            int ans = Math.Abs(sum);

            return ans;
        }

        public static string CreatePhoneNumber(int[] numbers)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < numbers.Count(); i++)
            {
                if (i == 0)
                {
                    sb.Append("(");
                }
                sb.Append(numbers[i]);
                if (i == 2)
                {
                    sb.Append(") ");
                }
                if (i == 5)
                {
                    sb.Append("-");
                }
            }
            return sb.ToString();
        }

        public static int JaggedArrayWordCheck(char[][] board, string word)
        {
            int matches = 0;

            for (int i = 0; i < board.Count(); i++)
            {
                for (int j = 0; j < board[i].Count(); j++)
                {
                    Dictionary<char, string> wordMatch = new Dictionary<char, string>() { {'h', "" }, {'v', "" },{'d', "" } };
                    for (int k = 0; k < word.Length; k++)
                    {

                    }
                }       
            }


            return 1;
        }

        public static int[] OccurenceCount(int[] sourceArr)
        {
            List<int> count = new List<int>();
            var arr = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            var sourceStr = String.Join(',', sourceArr);
            int currentOccurence = 0, currentCount = 0;
            int itemToAdd;

            foreach (var item in arr)
            {
                if (item == ',') continue;

                if (count.Contains(item)) continue;

                currentCount = sourceStr.Count(s => s == item);

                if (currentCount > currentOccurence)
                {
                    itemToAdd = Convert.ToInt32(item.ToString());
                    count.Clear();
                    count.Add(itemToAdd);
                    currentOccurence = currentCount;
                }else if(currentCount == currentOccurence)
                {
                    itemToAdd = Convert.ToInt32(item.ToString());
                    count.Add(itemToAdd);
                    currentOccurence = currentCount;
                }
                else
                {
                    //
                }
            }

            return count.ToArray();
        }

        public static int RemoveElement(int[] nums, int val)
        {
            int count = 0;
            for (int i = 0; i < nums.Count(); i++)
            {
                if (nums[i] == val)
                {
                    nums[i] = 52;
                }else
                {
                    count++;
                }
            }
            Array.Sort(nums);
            return count;
        }

        public static int StrStr(string haystack, string needle)
        {
            if (String.IsNullOrEmpty(needle))
            {
                return 0;
            }

            int search = 0;
            string check = needle.Substring(0, 1);

            search = haystack.IndexOf(check);
            return search;
        }

        public static int SearchInsert(int[] nums, int target)
        {
            if (target > nums[nums.Count() - 1]) return nums.Count();
            if (target < nums[0]) return 0;
            int check = Array.IndexOf(nums, target);
            if (check >= 0) return check;

            for (int i = 0, j = nums.Count() - 1; i < nums.Count(); i++, j--)
            {
                if (target > nums[i] && target < nums[i + 1])
                {
                    return i + 1;
                }
                if (target < nums[j] && target > nums[j - 1])
                {
                    return j - 1;
                }
            }
            return 0;
        }

        public static int solution(int N, int[] A, int[] B, int[] H)
        {
            int destination = N - 1;

            List<List<int>> routes = new List<List<int>>();
            

            if (Array.IndexOf(H, destination) > -1) return 0; //this is to check if the destination already has a hospital
            if (Array.IndexOf(A.Concat(B).ToArray(), destination) < 0) return -1; //this is to check if the destination has no access road.

            for (int i = 0; i < A.Count() - 1; i++)
            {
                if( i == 0)
                {
                    routes.Add(new List<int>
                    {
                        A[i], B[i]
                    });
                }
            }

            return 5;

        }

        public static int PolygonCalc(int n)
        {

            static int nCalculator (int c)
            {
                if (c <= 1) return 0;
                int ret = c - 1 + nCalculator(c - 1);

                return ret;
            }

            int result = 1 + (4 * nCalculator(n));
            return result;
        }

        public static List<string> getItems (List<List<string>> entries)
        {
            List<string> items = new List<string>();
            List<itemList> insertItemsList = new List<itemList>();

            const string insert = "INSERT";
            const string view = "VIEW";
            int counter = 0;
            itemList entry = new itemList();

            foreach (var item in entries)
            {
                if (item[0].ToLower() == insert.ToLower())
                {
                    insertItemsList.Add(new itemList(item[1], item[2]));
                    insertItemsList = insertItemsList.OrderBy(a => a.price).ThenBy(a => a.itemName).ToList();
                    //var t = entries.OrderBy(a => a[2]);
                    continue;
                }

                if (item[0].ToLower() == view.ToLower())
                {
                    entry = insertItemsList[counter];
                    items.Add(entry.itemName);
                    counter++;
                    continue;
                }
            }
            return items;
        }
        
    }
    class itemList
    {
        public string itemName;// { get; set; }
        public int price;// { get; set; }
        public itemList(string itemNam, string pric)
        {
            itemName = itemNam;
            price = int.Parse(pric);
        }
        public itemList()
        {

        }
    }
}
