using System;
using LeetCodeSolutions.Problems.BeeCrowd.TdaRationalV1;
using LeetCodeSolutions.Problems.BeeCrowd.TdaRationalV2;
using LeetCodeSolutions.Problems.CoderByte;
using LeetCodeSolutions.Problems.Codibility;



var tda1 = new TdaRationalTaskV1();
//tda1.Solve();


var tda2 = new TdaRationalTaskV2();
//tda2.Solve();

var binary = new FindBinaryGapOfZerosTask();
//binary.Solve(9);
//binary.Solve(1041);

var permutation = new CheckPermutationTask();
//permutation.Solve([2, 3, 5, 1]);
//permutation.SolveV2([2, 3, 15, 1]);
//permutation.SolveV2([2, 1, 15, 1, 3]);


var maxCounter = new MaxCounterTask();
//maxCounter.Solve( 5 ,[3, 4, 4, 6, 1, 4, 4]);

var missingInteger = new FindMissingInteger();
//missingInteger.Solve([2, 4, 5, 1]);


var small = new FindSmallestTask();
//small.Solve([-1, -2, -3, -3, 0, 1, 2, 3]);
//small.SolveV2([0,1,2,3]);

var unpaired = new FindUnpairedTask();
unpaired.Solve([2, 3, 1, 4, 4, 1, 3]);
unpaired.Solve([2, 3, 1, 4, 2, 5, 4, 1, 3]);


var chocolates = new CountChocolate();
chocolates.Solve(13, 4);


var rotation = new RotateNumbersTask();
//rotation.Solve([3, 8, 9, 7, 6], 3);


var christmasTree = new MarryChristimasTree();
christmasTree.Solve(10);
