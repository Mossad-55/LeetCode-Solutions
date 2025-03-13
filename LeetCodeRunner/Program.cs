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
