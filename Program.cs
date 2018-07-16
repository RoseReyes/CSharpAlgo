using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CSharpAlgo
{
    class Program
    {
        public class ListNode{
            public int val;
            public ListNode next;
        }
        public ListNode MergeTwoList(ListNode list1, ListNode list2) {
            ListNode newNode = new ListNode();
            ListNode runner = newNode;
            
            while (list1 != null && list2 != null) {
                if(list1.val <= list2.val){
                runner.next = list1;
                list1 = list1.next;
                }
                else {
                runner.next = list2;
                list2 = list2.next;
                }
                runner = runner.next;
            }
            if(list1 != null){
                runner.next = list1;
            }
            else {
                runner.next = list2;
            }
            return newNode.next;
        }

        public static int[] MergeTwoArray(int [] arr1, int [] arr2){

            int[] NewArray = new int[arr1.Length + arr2.Length];
            int a = 0, b = 0, i = 0;    

            while (a < arr1.Length && b < arr2.Length)
            {
                if (arr1[a] <= arr2[b]){
                    NewArray[i++] = arr1[a++];
                }
                else {
                    NewArray[i++] = arr2[b++];
                }
            }

            if (a < arr1.Length) {
                for (int x = a; x < arr1.Length; x++){
                    NewArray[i++] = arr1[x];
                }
            }
            else {
                for (int x = b; x < arr2.Length; x++){
                    NewArray[i++] = arr2[x];
                }
            }

            //Print the results
            for( int x =0; x < NewArray.Length; x++){
                System.Console.WriteLine(NewArray[x]);
            }
            return NewArray;
        }

        public static string MaxChar(string Str){
            int count = 0;
            var MaxChar = Str[0];

            for(int x = 0; x < Str.Length; x++){
                int currCount = 1;

                for(var y = x + 1; y < Str.Length; y++){
                    if (Str[x] != Str[y]){
                        break;
                    }
                    currCount++;
                }

                if(currCount > count){
                    count = currCount;
                    MaxChar = Str[x];
                }
            }
            
            Console.WriteLine("Maximum Character: {0}", MaxChar);
            return MaxChar.ToString();
        }
        public static int[] NPSwap(int [] arr){
            int y = 0, x = 0;
            int temp = 0;

            while(x < arr.Length){
                y = x + 1;
                while (y < arr.Length){
                    if(arr[y] > 0){
                        temp = arr[y];
                        arr[y] = arr[y - 1];
                        arr[y - 1] = temp;
                    }
                    y++;
                }
                x++;
            }
            //Print the results
            for(int z = 0; z < arr.Length; z++){
                System.Console.WriteLine(arr[z]);
            }
            return arr;
        }

        public static void ReverseSentence(string Str){
            StringBuilder sb = new StringBuilder();  
            string[] Split = Str.Split(' ');  
            for (int i = Split.Length - 1; i >= 0; i--)  
            {  
                sb.Append(Split[i]);  
                sb.Append(" ");  
            }  
            Console.WriteLine(sb);  
        }


        static string ToRoman(int input)
        {
            string[] roman = {"I","V","X","L","C","D","M"};
            int[] number = { 1, 5, 10, 50, 100, 500, 1000 };
            List<int> digits = new List<int>();
            StringBuilder output = new StringBuilder();
            int y = roman.Length-1;

            for(int x = number.Length - 1; x > -1; x--){
                digits.Add(input / number[x]);
                input = input % number[x];
            }

            for(int z = 0; z < digits.Count; z++){
                if(digits[z]!=0 && digits[z] == 4){
                    output.Append(String.Concat(Enumerable.Repeat(roman[y], 1)));
                    string result = String.Concat(Enumerable.Repeat(roman[y+1], 1));
                    output.Append(result);
                }
                else {
                    output.Append(String.Concat(Enumerable.Repeat(roman[y], digits[z])));
                    System.Console.WriteLine(output);
                }
                y--;
            }
            return output.ToString();
        }

        static int[] EaseArray(int[] Arr){
            for(int x = 0; x < Arr.Length - 1; x++){
                if(Arr[x] > 0 && Arr[x + 1] == Arr[x]){
                    Arr[x] *= 2;
                    Arr[x + 1] = 0;
                }
            }
            //Swap all non-zero numbers to the left
            int NonZeroCount = 0;
            for(int y = 0; y < Arr.Length; y++)
            {
                if(Arr[y] > 0)
                {
                    Arr[NonZeroCount] = Arr[y];
                    NonZeroCount++;
                }
            }
            //Change the tail part of the array to 0's
            for(int z = NonZeroCount; z < Arr.Length; z++)
            {
                Arr[z] = 0;
            }
            for(int w = 0; w < Arr.Length - 1; w++){
                System.Console.WriteLine(Arr[w]);
            }
            return Arr;
        }

        public List<String> sortedNumAlphabet(int num){

            List<String> sorted = new List<String>();
            int breakPoint = 0;
            
            for(int i = 1; i <= num; i++){
                sorted.Add(i.ToString());
                for(int j = 0; j <=9; j++){
                    sorted.Add(i.ToString() + j.ToString());
                    if(i.ToString() + j.ToString() == num.ToString()){
                        breakPoint = j;
                        break;
                    }
                }
            }
            for(int i = breakPoint; i <= 9; i++){
                sorted.Add(i.ToString());
            }
            return sorted;
        }

        static Boolean JumpGame(int[] arr){
            Boolean IdxResult = false;
            for(int x = 0; x < arr.Length - 1; x++){
                int LandingSpot = arr[x] + x;

                if(LandingSpot < arr.Length - 1){
                    if(arr[LandingSpot] == 0){
                        IdxResult = false;
                        LandingSpot = 0;
                    }
                    else {
                        IdxResult = true;
                        LandingSpot = 0;
                    }
                }   
            }
            return IdxResult;
        }

        static int[] ActiveInactiveState(int[] state, int days, int n){
            int[] temp = new int[n];

            for(int x = 0; x < n; x++) {
                temp[x] = state[x];
            }

            while(days-- > 0) {

                temp[0] = 0 ^ state[1];
                temp[n -1] = 0 ^ state[n - 2];

                for(int y = 1; y <= n - 2; y++)
                    temp[y] = state[y-1] ^ state[y+1];

                for(int z = 0; z < n; z++)
                    state[z] = temp[z];
            }

            for(int a = 0; a < state.Length; a++){
                System.Console.WriteLine(state[a]);
            }
            return state;
        }
         

        

        static void Main(string[] args)
        {
            int [] arr1 = {1,5,7,12,18,32};
            int [] arr2= {2,4,9,16,27,76,98};
            int [] arr = {2,3,5};
            int num = 8;
            int[] Arr = {2,4,5,0,0,5,4,8,6,0,6,8};
            int[] state = {0,1,1,1,0,1,1,0};
            int days = 4;
            int n = state.Length;
            ActiveInactiveState(state, days, n);
            EaseArray(Arr);
            Boolean IdxStatus = JumpGame(arr);
            Console.Write("The result is {0}", IdxStatus);
            string Str = "Rose Reyes";
            ReverseSentence(Str); 
            NPSwap(arr);
            MergeTwoArray(arr1, arr2);
            //String Str = "aaaabbbbbbbbbbbccd";
            MaxChar(Str);
            ToRoman(20);
        } 
    }
}

