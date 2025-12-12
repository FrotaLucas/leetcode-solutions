using LeetCodeSolutions.BeeCrowd;
using LeetCodeSolutions.BeeCrowd.TdaRationalV1;
using LeetCodeSolutions.BeeCrowd.TdaRationalV2;
using LeetCodeSolutions.CoderByte;
using LeetCodeSolutions.Codibility;



var tda1 = new TdaRationalTaskV1();
//tda1.Solve();


var tda2 = new TdaRationalTaskV2();
//tda2.Solve();






var chocolates = new CountChocolate();
chocolates.Solve(13, 4);




var twoSum = new TwoSumProblem();
//twoSum.Solve([3, 5, 2, -4, 8, 11], 7);


var isRetangle = new DrawRetangle();
//true
var r = isRetangle.Solve("uurrddll");
//false
var r2 = isRetangle.Solve("rrrllluudd");
//true
var r3 = isRetangle.Solve("rrrluulldd");
//true
var r4 = isRetangle.Solve("ddlluurr");

var occ = new CountOccurancesAndFrequencyTask();
var frequency = occ.Solve("1;3;2;3;4;1;5;3");
Console.WriteLine(frequency);


