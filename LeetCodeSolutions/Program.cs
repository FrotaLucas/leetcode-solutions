using LeetCodeSolutions.BeeCrowd;
using LeetCodeSolutions.BeeCrowd.TdaRationalV1;
using LeetCodeSolutions.BeeCrowd.TdaRationalV2;
using LeetCodeSolutions.CoderByte;
using LeetCodeSolutions.Codibility;



var tda1 = new TdaRationalTaskV1();
//tda1.Solve();


var tda2 = new TdaRationalTaskV2();
//tda2.Solve();

var binary = new FindBinaryGapOfZerosTask();
//binary.Solve(9);
//binary.Solve(1041);



var maxCounter = new MaxCounterTask();
//maxCounter.Solve( 5 ,[3, 4, 4, 6, 1, 4, 4]);

var missingInteger = new FindMissingInteger();
//missingInteger.Solve([2, 4, 5, 1]);


var small = new FindSmallestTask();
//small.Solve([-1, -2, -3, -3, 0, 1, 2, 3]);
//small.SolveV2([0,1,2,3]);

var word = new LongestWordTask();
//word.Solve("time## flows here");

var unpaired = new FindUnpairedTask();
unpaired.Solve([2, 3, 1, 4, 4, 1, 3]);
unpaired.Solve([2, 3, 1, 4, 2, 5, 4, 1, 3]);


var chocolates = new CountChocolate();
chocolates.Solve(13, 4);


var rotation = new RotateNumbersTask();
//rotation.Solve([3, 8, 9, 7, 6], 3);


var christmasTree = new MarryChristimasTree();
//christmasTree.Solve(30);

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


