﻿using System;
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
                    if(arr[y] < 0){
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
        static void Main(string[] args)
        {
            int [] arr1 = {1,5,7,12,18,32};
            int [] arr2= {2,4,9,16,27,76,98};
            int [] arr = {4,-3,2,-5,5,-1,3};
            string Str = "Rose Reyes";
            ReverseSentence(Str); 
            // NPSwap(arr);
            //MergeTwoArray(arr1, arr2);
            // String Str = "aaaabbbbbbbbbbbccd";
            // MaxChar(Str);
        } 
    }
}

