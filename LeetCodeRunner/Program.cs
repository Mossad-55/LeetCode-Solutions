using Easy;
using Medium;

// Contains Duplicate Test Case
Console.WriteLine("Contains Duplicate Test Case (1 / 1):");
Console.WriteLine("Input: [1,2,3,1]");
Console.WriteLine($"Output: {ContainsDuplicate.Solution([1,2,3,1])}");

// Valid Anagram Test Case
Console.WriteLine("Valid Anagram Test Case (1 / 1):");
Console.WriteLine("Input: s = \"anagram\" t = \"nagaram\"");
Console.WriteLine($"Output: {ValidAnagram.Solution("anagram", "nagaram")}");

// Group Anagrams Test Case
Console.WriteLine("Group Anagrams Test Case (1 / 1):");
Console.WriteLine("Input: strs = [\"eat\",\"tea\",\"tan\",\"ate\",\"nat\",\"bat\"]");
Console.Write("Output: ");
var res = GroupAnagrams.Solve([ "eat", "tea", "tan", "ate", "nat", "bat" ]);
foreach(var lis in res){
    Console.Write($"[");
    
    foreach(var s in lis){
        Console.Write($"\"{s}\",");
    }
    Console.Write($"], ");
}
Console.WriteLine();

// Top K Freqent Elements Test Case
Console.WriteLine("Top K Frequent Elements Test Case (1 / 1):");
Console.WriteLine("Input: nums = [1,1,1,2,2,3], k = 2");
var topKFrequentElements = TopKFrequentElements.Solve([1,1,1,2,2,3], 2);
Console.WriteLine($"Output : [{topKFrequentElements[0]},{topKFrequentElements[1]}]");

// Encode and Decode Strings Test Case
Console.WriteLine("Enconde and Decode Strings Test Case (1 / 1):");
Console.WriteLine("Input: strs = [\"I\", \"Love\", \"C#\"]");
var encodedStr = EncodeAndDecodeStrings.Encode(["I", "Love", "C#"]);
Console.WriteLine($"The Encoded string: {encodedStr}");
var decodedStrs = EncodeAndDecodeStrings.Decode(encodedStr);
Console.WriteLine($"The Decoded string: [\"{decodedStrs[0]}\", \"{decodedStrs[1]}\", \"{decodedStrs[2]}\"]");

// Product of Array Except Self Test Case
Console.WriteLine("Product of Array Except Self Test Case (1 / 1):");
Console.WriteLine("Input: nums = [1,2,3,4]");
var res2 = ProductOfArrayExceptSelf.Solve([1,2,3,4]);
Console.WriteLine($"Output: result = [{res2[0]},{res2[1]},{res2[2]},{res2[3]}]");

// I'm not going to do it for the sudoku thingy :) DIY

// Longest Consecutive Sequence Test Case
Console.WriteLine("Longest Consecutive Sequence Test Case (1 / 1):");
Console.WriteLine("Input: nums = [100,4,200,1,3,2]");
Console.WriteLine($"Output: {LongestConsecutiveSequence.Solve([100,4,200,3,2,1])}");
Console.WriteLine("Explanation: the longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.");

// Valid Palindrome Test Case
Console.WriteLine("Valid Palindrome Test Case (1 / 1):");
Console.WriteLine("Input: s = \"A man, a plan, a canal: Panama\"");
Console.WriteLine($"Output: {ValidPalindrome.Solve("A man, a plan, a canal: Panama")}");

// Two Sum II - Input Array Is Sorted
Console.WriteLine("Two Sum II Test Case (1 / 1):");
Console.WriteLine("Input: nums = [2,7,11,15], target = 9");
var twoSumII = TwoSumII.Solve([2,7,11,15], 9); 
Console.WriteLine($"Output: [{twoSumII[0]}, {twoSumII[1]}]");
