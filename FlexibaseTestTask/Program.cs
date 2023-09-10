using System.Text;

namespace FlexibaseTestTask
{
    public class Program
    {
        public static List<object> FirstTask(List<object> nums) 
        {
            for (int i = 0; i < nums.Count; i++)
            {
                StringBuilder replacement = new();

                if (int.Parse(nums[i].ToString()) % 3 == 0) replacement.Append("fizz");
                if (int.Parse(nums[i].ToString()) % 5 == 0) replacement.Append("-buzz");

                if (replacement.Length != 0)
                {
                    if (replacement[0] == '-')
                    {
                        replacement.Remove(0, 1);
                    }

                    nums[i] = replacement.ToString();
                }
            }

            return nums;
        }

        public static List<object> SecondTask(List<object> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                StringBuilder replacement = new();

                if (int.Parse(nums[i].ToString()) % 3 == 0) replacement.Append("fizz");
                if (int.Parse(nums[i].ToString()) % 5 == 0) replacement.Append("-buzz");
                if (int.Parse(nums[i].ToString()) % 4 == 0) replacement.Append("-muzz");
                if (int.Parse(nums[i].ToString()) % 7 == 0) replacement.Append("-guzz");

                if (replacement.Length != 0)
                {
                    if (replacement[0] == '-') replacement.Remove(0, 1);

                    nums[i] = replacement.ToString();
                }
            }

            return nums;
        }

        public static List<object> ThirdTask(List<object> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                StringBuilder replacement = new();

                bool nullmod3 = int.Parse(nums[i].ToString()) % 3 == 0;
                bool nullmod5 = int.Parse(nums[i].ToString()) % 5 == 0;

                if (nullmod3) replacement.Append("dog");
                if (nullmod5) replacement.Append("-cat");

                if (nullmod3 && nullmod5)
                {
                    replacement.Clear();
                    replacement.Append("good-boy");
                }

                if (int.Parse(nums[i].ToString()) % 4 == 0) replacement.Append("-muzz");
                if (int.Parse(nums[i].ToString()) % 7 == 0) replacement.Append("-guzz");

                if (replacement.Length != 0)
                {
                    if (replacement[0] == '-') replacement.Remove(0, 1);

                    nums[i] = replacement.ToString();
                }
            }

            return nums;
        }

        public static void Main()
        {
            List<object> nums = new List<object>();

            for (int i = 1; i < 16; i++) 
            {
                nums.Add(i);
            }

            nums.Add(60);
            nums.Add(105);
            nums.Add(420);

            ThirdTask(nums);

            foreach (object x in nums)
            {
                Console.WriteLine(x);   
            }    
        }
    }
}