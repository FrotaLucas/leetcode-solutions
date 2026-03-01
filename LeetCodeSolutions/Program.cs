using LeetCodeSolutions.AdventOfCode.Advent_2018;
using LeetCodeSolutions.BeeCrowd;
using LeetCodeSolutions.BeeCrowd.TdaRationalV1;
using LeetCodeSolutions.BeeCrowd.TdaRationalV2;
using LeetCodeSolutions.CoderByte;
using LeetCodeSolutions.Codibility;



var tda1 = new TdaRationalTaskV1();
//tda1.Solve();


var tda2 = new TdaRationalTaskV2();
//tda2.Solve();



var obj = new CountOccurancesAndFrequencyTask();
obj.Solve("1;3;2;3;4;1;5;3");


var res = new EquiLeader();
int[] A = [4, 3, 4, 4, 4, 2]; //true tem 2 leaders 
int[] B = [3, 3, 3]; ///true tem 2 leaders
int[] C = [3, 1, 1]; //false nao tem leader

//ERA PARA PELO MENOS MOSTRAR 1 LEADER. 1 EH LIEDER
int[] D = [3, 1, 1,       1, 2, 2, 1, 1]; //true  tem 3 leader


//Console.WriteLine(res.Solve(D));

var freq = new CountOfFrequency();

string ids_string = "abcdef,bababc,abbcde,abcccd,aabcdd,abcdee,ababab";

int r = freq.Solve(ids_string);

Console.WriteLine(r);

