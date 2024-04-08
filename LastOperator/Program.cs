// See https://aka.ms/new-console-template for more information

List<int> bigList = [1, 2, 3, 4, 5, 6, 7, 8];

Console.WriteLine("==== Element By Linq ====");

var firstElementWithLinq = bigList.First();
var lastElementWithLinq = bigList.Last();

Console.WriteLine("The first element of the list with length of {0} using index is {1} and the last is {2}. \n",
    firstElementWithLinq, lastElementWithLinq, bigList.Count);

Console.WriteLine("==== Element By Index from end ====");

var firstElementWithSliceOperator = bigList[0];
var lastElementWithSliceOperator = bigList[^1];

Console.WriteLine("The first element of the list with length of {0} using index is {1} and the last is {2}.\n",
    firstElementWithSliceOperator, lastElementWithSliceOperator, bigList.Count);

Console.WriteLine("==== Element By Range ====");

var betweenWithRange = bigList[1..6];

Console.WriteLine("The new list with Range operator is {0}.\n", string.Join(",", betweenWithRange));

Console.WriteLine("==== Element By Range and Index from end ====");

var betweenWithRangeIndex = bigList[^3..^1];

Console.WriteLine("The new list with Range and Index From End Operator is {0}.\n", string.Join(",", betweenWithRangeIndex));

Console.WriteLine("==== All Element By Range ====");

var allBetweenWithIndex = bigList[..];

Console.WriteLine("The new list with a Range operator is {0}.\n", string.Join(",", allBetweenWithIndex));

Console.WriteLine("==== Between last Element By Range ====");

var betweenLastWithIndex = bigList[..3];

Console.WriteLine("The new list with a Range operator is {0}.\n", string.Join(",", betweenLastWithIndex));

Console.WriteLine("==== From the initial Element By Range ====");

var fromTheInitialElementWithIndex = bigList[3..];

Console.WriteLine("The new list with a Range operator is {0}.\n", string.Join(",", fromTheInitialElementWithIndex));


