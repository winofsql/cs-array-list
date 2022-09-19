using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace cs_array_list
{
    class Program
    {
        static void Main(string[] args)
        {
            var act = new Program();

            // 一般的な配列
            var data = new int[5];
            data[0] = 5;
            data[4] = 1;
            act.print( $"配列長さ : {data.Length}" );

            act.print( "--- 整数配列" );
            foreach (var item in data) {
                act.print( item );
            }
            act.print( "--- ソート" );
            Array.Sort(data);
            foreach (var item in data) {
                act.print( item );
            }

            // 初期値設定1
            act.print( "--- 文字列配列" );
            var data2 = new string[] { "A10", "A11", "A12" };
            act.print( $"配列長さ : {data2.Length}" );
            // 通常 for
            for (int i = 0; i < data2.Length; i++) {
                act.print( data2[i] );
            }

            // 初期値設定2
            string[] data3 = { "aaa", "bbb", "ccc", "ddd" };
            act.print( $"配列長さ : {data3.Length}" );

            foreach(var str in data3) {
                act.print( str );
            }

            // List<T>
            var list = new List<string>();
            list.Add("java");
            list.Add("C#");
            list.Add("vb");
            act.print( $"List長さ : {list.Count}" );
            act.print( $"{list[0]} : {list[1]} : {list[2]}" );
            foreach(var value in list) {
                act.print( value );
            }

            // 既にある内容にさらに配列から追加
            list.AddRange(data2);
            act.print( "---" );
            foreach(var value in list) {
                act.print( value );
            }
            act.print( "--- ソート" );
            // ソート
            list.Sort();
            foreach(var value in list) {
                act.print( value );
            }

            act.print( "--- 配列" );
            // List<string> から 配列作成
            var arr = list.ToArray();
            foreach(var value in arr) {
                act.print( value );
            }

            act.print( "--- List" );
            // 文字列配列から List<string>
            list = data3.ToList();
            foreach(var value in list) {
                act.print( value );
            }


        }

        private void print(int v)
        {
            System.Console.WriteLine(v);
            Debug.WriteLine($"DBG:{v}");
        }
        private void print(string v)
        {
            System.Console.WriteLine(v);
            Debug.WriteLine($"DBG:{v}");
        }

    }
}
