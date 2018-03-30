﻿using System;
using System.Collections.Generic;

namespace dotnetcoreproject
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseWordsDemo test1 = new ReverseWordsDemo();
            Console.WriteLine(test1.ReverseWords("Let's take LeetCode contest"));

            FizzBuzzDemo test2 = new FizzBuzzDemo();
            IList<string> sResult = test2.FizzBuzz(15);

            int[,] island = new int[,] { { 0, 1, 0, 0 }, { 1, 1, 1, 0 }, { 0, 1, 0, 0 }, { 1, 1, 0, 0 } };
            IslandPerimeterDemo test3 = new IslandPerimeterDemo();
            Console.WriteLine(test3.IslandPerimeter(island).ToString());

            NextGreaterElementDemo test4 = new NextGreaterElementDemo();
            int[] nResult = test4.NextGreaterElement(new int[] { 4, 1, 2 }, new int[] { 1, 3, 4, 2 });

            TreeNode root = new TreeNode(2147483647);
            root.left = new TreeNode(2147483647);
            root.right = new TreeNode(2147483647);
            AverageofLevelsinBinaryTreeDemo test5 = new AverageofLevelsinBinaryTreeDemo();
            IList<double> dResult = test5.AverageOfLevels(root);

            SingleNumberDemo test6 = new SingleNumberDemo();
            Console.WriteLine(test6.SingleNumber(new int[] { 17, 12, 5, -6, 12, 4, 17, -5, 2, -3, 2, 4, 5, 16, -3, -4, 15, 15, -4, -5, -6 }));

            HammingDistanceDemo test7 = new HammingDistanceDemo();
            Console.WriteLine(test7.HammingDistance(1, 16));

            MaxConsecutiveOnesDemo test8 = new MaxConsecutiveOnesDemo();
            Console.WriteLine(test8.FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 1, 1, 1 }));

            MaximumDepthofBinaryTreeDemo test9 = new MaximumDepthofBinaryTreeDemo();
            Console.WriteLine(test9.MaxDepth(root));

            TreeNode root10 = new TreeNode(4);
            TreeNode left10 = new TreeNode(2);
            left10.left = new TreeNode(1);
            left10.right = new TreeNode(3);
            TreeNode right10 = new TreeNode(7);
            right10.left = new TreeNode(6);
            right10.right = new TreeNode(9);
            root10.left = left10;
            root10.right = right10;
            InvertBinaryTreeDemo test10 = new InvertBinaryTreeDemo();
            TreeNode nodeResult10 = test10.InvertTree(root10);

            FindAllNumbersDisappearedinanArrayDemo test11 = new FindAllNumbersDisappearedinanArrayDemo();
            IList<int> pResult11 = test11.FindDisappearedNumbers(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 });


            TreeNode root12 = new TreeNode(5);
            TreeNode left12 = new TreeNode(3);
            left12.left = new TreeNode(2);
            left12.right = new TreeNode(4);
            TreeNode right12 = new TreeNode(6);
            right12.right = new TreeNode(7);
            root12.left = left12;
            root12.right = right12;

            TwoSumIVDemo test12 = new TwoSumIVDemo();
            Console.WriteLine(test12.FindTarget(root12, 9) ? "true" : "false");

            ConstructStringfromBinaryTreeDemo test13 = new ConstructStringfromBinaryTreeDemo();
            Console.WriteLine(test13.Tree2str(root12));

            ListNode curL1 = new ListNode(2);
            curL1.next = new ListNode(4);
            curL1.next.next = new ListNode(3);

            ListNode curL2 = new ListNode(5);
            curL2.next = new ListNode(6);
            curL2.next.next = new ListNode(4);
            AddTwoNumbersDemo test14 = new AddTwoNumbersDemo();
            ListNode rNode14 = test14.AddTwoNumbers(curL1, curL2);

            TreeNode root15 = new TreeNode(5);
            root15.left = new TreeNode(2);
            root15.right = new TreeNode(13);

            ConvertBSTtoGreaterTreeDemo test15 = new ConvertBSTtoGreaterTreeDemo();
            TreeNode ret15 = test15.convertBST(root15);

            ConstructtheRectangleDemo test16 = new ConstructtheRectangleDemo();
            int[] nRet16 = test16.ConstructRectangle(5);
            Console.WriteLine(nRet16[0].ToString() + "," + nRet16[1].ToString());

            int[] nNums171 = new int[] { 1, 2, 2, 1 };
            int[] nNums172 = new int[] { 2, 2 };
            IntersectionofTwoArraysDemo test17 = new IntersectionofTwoArraysDemo();
            int[] nRet17 = test17.Intersection(nNums171, nNums172);

            ExcelSheetColumnTitleDemo test18 = new ExcelSheetColumnTitleDemo();
            Console.WriteLine(test18.ConvertToTitle(27));

            ExcelSheetColumnNumberDemo test19 = new ExcelSheetColumnNumberDemo();
            Console.WriteLine(test19.TitleToNumber("AA").ToString());

            TreeNode root201 = new TreeNode(5);
            TreeNode left201 = new TreeNode(3);
            left201.left = new TreeNode(2);
            left201.right = new TreeNode(4);
            TreeNode right201 = new TreeNode(6);
            right201.right = new TreeNode(7);
            root201.left = left201;
            root201.right = right201;
            TreeNode root202 = new TreeNode(5);
            TreeNode left202 = new TreeNode(3);
            left202.left = new TreeNode(2);
            left202.right = new TreeNode(4);
            TreeNode right202 = new TreeNode(6);
            right202.right = new TreeNode(7);
            root202.left = left202;
            root202.right = right202;
            SameTreeDemo test20 = new SameTreeDemo();
            Console.WriteLine(test20.IsSameTree(root201, root202) ? "same tree" : "not same tree");

            TreeNode root21 = new TreeNode(3);
            TreeNode right21 = new TreeNode(20);
            right21.left = new TreeNode(15);
            right21.right = new TreeNode(7);
            root21.left = new TreeNode(9);
            root21.right = right21;
            SumofLeftLeavesDemo test21 = new SumofLeftLeavesDemo();
            Console.WriteLine(test21.SumOfLeftLeaves(root21).ToString());


            TreeNode root22 = new TreeNode(1);
            TreeNode left22 = new TreeNode(2);
            TreeNode right22 = new TreeNode(3);
            left22.left = new TreeNode(4);
            right22.left = new TreeNode(5);
            root22.left = left22;
            root22.right = right22;
            BinaryTreeTiltDemo test22 = new BinaryTreeTiltDemo();
            Console.WriteLine(test22.FindTilt(root22).ToString());

            TreeNode root23 = new TreeNode(1);
            TreeNode right23 = new TreeNode(3);
            right23.left = new TreeNode(2);
            root23.right = right23;
            MinimumAbsoluteDifferenceinBSTDemo test23 = new MinimumAbsoluteDifferenceinBSTDemo();
            Console.WriteLine(test23.GetMinimumDifference(root23));

            ValidAnagramDemo test24 = new ValidAnagramDemo();
            Console.WriteLine(test24.IsAnagram("anagram", "nagaram") ? "true" : "false");

            ContainsDuplicateDemo test25 = new ContainsDuplicateDemo();
            Console.WriteLine(test25.ContainsDuplicate(new int[] {3, 2, 5, 4, 3, 1, 6}) ? "true" : "false");

            IntersectionofTwoArraysIIDemo test26 = new IntersectionofTwoArraysIIDemo();
            int[] nRes26 = test26.Intersect(new int[]{1, 2, 2, 1}, new int[]{2, 2});

            DiameterofBinaryTreeDemo test27 = new DiameterofBinaryTreeDemo();
            Console.WriteLine(test27.DiameterOfBinaryTree(root23).ToString());

            TreeNode root28 = new TreeNode(3);
            TreeNode left28 = new TreeNode(4);
            TreeNode right28 = new TreeNode(5);
            left28.left = new TreeNode(1);
            left28.right = new TreeNode(1);
            root28.left = left28;
            root28.right = right28;
            SubtreeofAnotherTreeDemo test28 = new SubtreeofAnotherTreeDemo();
            Console.WriteLine(test28.IsSubtree(root28, left28) ? "true" : "false");

            BinaryTreeLevelOrderTraversalIIDemo test29 = new BinaryTreeLevelOrderTraversalIIDemo();
            IList<IList<int>> ret29 = test29.LevelOrderBottom(root28);

            PowerofTwoDemo test30 = new PowerofTwoDemo();
            Console.WriteLine(test30.IsPowerOfTwo(9) ? "true" : "false");

            PowerofThreeDemo test31 = new PowerofThreeDemo();
            Console.WriteLine(test31.IsPowerOfThree(9) ? "true" : "false");

            PowerofFourDemo test32 = new PowerofFourDemo();
            Console.WriteLine(test32.IsPowerOfFour(16) ? "true" : "false");

            SearchInsertPositionDemo test33 = new SearchInsertPositionDemo();
            Console.WriteLine(test33.SearchInsert(new int[]{1, 3, 6, 9}, 7).ToString());

            EncodeandDecodeTinyURLDemo test34 = new EncodeandDecodeTinyURLDemo();
            Console.WriteLine(test34.decode(test34.encode("http://leetcode.com")));

            FindPivotIndexDemo test35 = new FindPivotIndexDemo();
            Console.WriteLine(test35.PivotIndex(new int[]{-1,-1,-1,0,1,-1}).ToString());

            SelfDividingNumbersDemo test36 = new SelfDividingNumbersDemo();
            IList<int> ret36 = test36.SelfDividingNumbers(1, 22);

            TreeNode root37 = new TreeNode(1);
            root37.left = new TreeNode(2);
            root37.right = null;
            MinimumDepthofBinaryTreeDemo test37 = new MinimumDepthofBinaryTreeDemo();
            Console.WriteLine(test37.MinDepth(root37).ToString());

            NumberComplementDemo test38 = new NumberComplementDemo();
            Console.WriteLine(test38.FindComplement(5).ToString());

            KeyboardRowDemo test39 = new KeyboardRowDemo();
            Console.WriteLine(test39.FindWords(new string[]{"Hello", "Alaska", "Dad", "Peace"}).ToString());

            BinaryNumberwithAlternatingBitsDemo test40 = new BinaryNumberwithAlternatingBitsDemo();
            Console.WriteLine(test40.HasAlternatingBits(10).ToString());

            int[,] grid41 = new int[,] {{0,0,1,0,0,0,0,1,0,0,0,0,0},
                                        {0,0,0,0,0,0,0,1,1,1,0,0,0},
                                        {0,1,1,0,1,0,0,0,0,0,0,0,0},
                                        {0,1,0,0,1,1,0,0,1,0,1,0,0},
                                        {0,1,0,0,1,1,0,0,1,1,1,0,0},
                                        {0,0,0,0,0,0,0,0,0,0,1,0,0},
                                        {0,0,0,0,0,0,0,1,1,1,0,0,0},
                                        {0,0,0,0,0,0,0,1,1,0,0,0,0}};
            MaxAreaofIslandDemo test41 = new MaxAreaofIslandDemo();
            Console.WriteLine(test41.MaxAreaOfIsland(grid41).ToString());

            MoveZeroesDemo test42 = new MoveZeroesDemo();
            int[] nums42 = new int[] {0, 1, 0, 3, 12};
            test42.MoveZeroes(nums42);

            MissingNumberDemo test43 = new MissingNumberDemo();
            Console.WriteLine(test43.MissingNumber(new int[]{9,6,4,2,3,5,7,0,1}).ToString());

            ArrayPartitionIDemo test44 = new ArrayPartitionIDemo();
            Console.WriteLine(test44.ArrayPairSum(new int[]{1,4,3,2}).ToString());

            FindtheDifferenceDemo test45 = new FindtheDifferenceDemo();
            Console.WriteLine(test45.FindTheDifference("abcd", "abcde").ToString());

            DetectCapitalDemo test46 = new DetectCapitalDemo();
            
            
            TwoSumIIInputarrayissortedDemo test47 = new TwoSumIIInputarrayissortedDemo();
            int[] nRet47 = test47.TwoSum(new int[]{-1, 0}, -1);
            Console.WriteLine(nRet47[0].ToString() + "," + nRet47[1].ToString());

            AddDigitsDemo test48 = new AddDigitsDemo();
            Console.WriteLine(test48.AddDigits(38).ToString());

            MaximumProductofThreeNumbersDemo test49 = new MaximumProductofThreeNumbersDemo();
            Console.WriteLine(test49.MaximumProduct(new int[]{1,2,3,4}).ToString());

            TreeNode root50 = new TreeNode(2);
            root50.left = new TreeNode(2);
            root50.right = new TreeNode(5);
            root50.right.left = new TreeNode(5);
            root50.right.right = new TreeNode(7);
            SecondMinimumNodeInaBinaryTreeDemo test50 = new SecondMinimumNodeInaBinaryTreeDemo();
            Console.WriteLine(test50.FindSecondMinimumValue(root50).ToString());

            TreeNode root51 = new TreeNode(1);
            root51.left = new TreeNode(2);
            root51.right = new TreeNode(3);
            root51.left.right = new TreeNode(5);
            BinaryTreePathsDemo test51 = new BinaryTreePathsDemo();
            Console.WriteLine(test51.BinaryTreePaths(root51).ToString());

            StringCompressionDemo test52 = new StringCompressionDemo();
            Console.WriteLine(test52.Compress(new char[] {'a','a','b','b','c','c','c'}).ToString());

            RemoveElementDemo test53 = new RemoveElementDemo();
            Console.WriteLine(test53.RemoveElement(new int[]{2}, 3).ToString());

            ListNode curL541 = new ListNode(1);
            curL541.next = new ListNode(2);
            curL541.next.next = new ListNode(4);

            ListNode curL542 = new ListNode(1);
            curL542.next = new ListNode(3);
            curL542.next.next = new ListNode(4);
            MergeTwoSortedListsDemo test54 = new MergeTwoSortedListsDemo();
            ListNode lResult54 = test54.MergeTwoLists(curL541, curL542);

            SqrtXDemo test55 = new SqrtXDemo();
            Console.WriteLine(test55.MySqrt(8).ToString());

            FindAnagramMappingsDemo test56 = new FindAnagramMappingsDemo();
            int[] nResult56 = test56.AnagramMappings(new int[]{12, 28, 46, 32, 50}, new int[]{50, 12, 32, 46, 28});

            MergeSortedArrayDemo test57 = new MergeSortedArrayDemo();
            test57.Merge(new int[]{1, 3, 5, 6, 8, 10, 0, 0, 0, 0, 0, 0}, 6, new int[]{2, 4, 6, 7, 12, 13}, 6);

            ThirdMaximumNumberDemo test58 = new ThirdMaximumNumberDemo();
            Console.WriteLine(test58.ThirdMax(new int[]{2, 2, 3, 1}).ToString());

            ImplementstrStrDemo test59 = new ImplementstrStrDemo();
            Console.WriteLine(test59.StrStr("hello", "ll").ToString());

            LengthofLastWordDemo test60 = new LengthofLastWordDemo();
            Console.WriteLine(test60.lengthOfLastWord("a ").ToString());

            PlusOneDemo test61 = new PlusOneDemo();
            int[] nRet = test61.PlusOne(new int[]{9, 9, 9, 9, 9});

            CanPlaceFlowersDemo test62 = new CanPlaceFlowersDemo();
            test62.CanPlaceFlowers(new int[]{0, 0, 1, 0, 0, 0, 0, 1}, 2);

            ToeplitzMatrixDemo test63 = new ToeplitzMatrixDemo();
            bool bRet63 = test63.IsToeplitzMatrix(new int[,]{{1,2,3,4},{5,1,2,3},{9,5,1,2}});

            PerfectNumberDemo test64 = new PerfectNumberDemo();
            bool bRet64 = test64.CheckPerfectNumber(28);

            MinStack test65 = new MinStack();
            test65.Push(-2);
            test65.Push(0);
            test65.Push(-3);
            int nRet65 = test65.GetMin();
            nRet65 = test65.Top();
            test65.Pop();
            nRet65 = test65.GetMin();

            NumArray test66 = new NumArray(new int[]{-2, 0, 3, -5, 2, -1});
            int nRet66 = test66.SumRange(0, 2);
            nRet66 = test66.SumRange(2, 5);
            nRet66 = test66.SumRange(0, 5);

            JewelsandStonesDemo test67 = new JewelsandStonesDemo();
            Console.WriteLine(test67.NumJewelsInStones("aA", "aAAbbbb").ToString());

            RotateArrayDemo test68 = new RotateArrayDemo();
            test68.Rotate1(new int[]{1,2,3,4,5,6,7}, 3);

            LongestCommonPrefixDemo test69 = new LongestCommonPrefixDemo();
            Console.WriteLine(test69.LongestCommonPrefix(new string[]{"aac", "ab"}));

            PartitionLabelsDemo test70 = new PartitionLabelsDemo();
            IList<int> ret70 = test70.PartitionLabels("ababcbacadefegdehijhklij");

            SingleElementinaSortedArrayDemo test71 = new SingleElementinaSortedArrayDemo();
            Console.WriteLine(test71.SingleNonDuplicate(new int[]{1,1,2,3,3,4,4,8,8}).ToString());

            LetterCasePermutationDemo test72 = new LetterCasePermutationDemo();
            IList<string> ret72 = test72.LetterCasePermutation("a1b2");

            LargestNumberAtLeastTwiceofOthersDemo test73 = new LargestNumberAtLeastTwiceofOthersDemo();
            Console.WriteLine(test73.DominantIndex(new int[]{3, 6, 1, 0}).ToString());

            RotateStringDemo test74 = new RotateStringDemo();
            bool bRet74 = test74.RotateString("abcde", "cdeab");

            LongestWordinDictionaryDemo test75 = new LongestWordinDictionaryDemo();
            Console.WriteLine(test75.LongestWord(new string[]{"rac","rs","ra","on","r","otif","o","onpdu","rsf","rs","ot","oti","racy","onpd"}));

            FindSmallestLetterGreaterThanTargetDemo test76 = new FindSmallestLetterGreaterThanTargetDemo();
            Console.WriteLine(test76.NextGreatestLetter(new char[]{'c', 'f', 'j'}, 'd').ToString());

            RepeatedStringMatchDemo test77 = new RepeatedStringMatchDemo();
            Console.WriteLine(test77.RepeatedStringMatch("abcd", "cdabcdab").ToString());

            LongestHarmoniousSubsequenceDemo test78 = new LongestHarmoniousSubsequenceDemo();
            Console.WriteLine(test78.FindLHS(new int[]{1,2,3,3,1,-14,13,4}).ToString());

            ShortestUnsortedContinuousSubarrayDemo test79 = new ShortestUnsortedContinuousSubarrayDemo();
            Console.WriteLine(test79.FindUnsortedSubarray(new int[]{2, 4, 5, 8, 9, 10, 15}).ToString());

            Base7Demo test80 = new Base7Demo();
            Console.WriteLine(test80.ConvertToBase7(101));

            TreeNode root81 = new TreeNode(1);
            root81.left = new TreeNode(4);
            root81.right = new TreeNode(5);
            root81.left.left = new TreeNode(4);
            root81.left.right = new TreeNode(4);
            root81.right.right = new TreeNode(5);
            LongestUnivaluePathDemo test81 = new LongestUnivaluePathDemo();
            Console.WriteLine(test81.LongestUnivaluePath(root81).ToString());

            UniqueMorseCodeWordsDemo test82 = new UniqueMorseCodeWordsDemo();
            Console.WriteLine(test82.UniqueMorseRepresentations(new string[]{"gin", "zen", "gig", "msg"}).ToString());

            NumberofLinesToWriteStringDemo test83 = new NumberofLinesToWriteStringDemo();
            int[] ret83 = test83.NumberOfLines(new int[]{10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10}, "abcdefghijklmnopqrstuvwxyz");

            MaxIncreasetoKeepCitySkylineDemo test84 = new MaxIncreasetoKeepCitySkylineDemo();
            Console.WriteLine(test84.MaxIncreaseKeepingSkyline(new int[4][]{new int[4]{3,0,8,4},new int[4]{2,4,5,7},new int[4]{9,2,6,3},new int[4]{0,3,1,0}}).ToString());

            MaximumAverageSubarrayIDemo test85 = new MaximumAverageSubarrayIDemo();
            Console.WriteLine(test85.FindMaxAverage(new int[]{1,12,-5,-6,50,3}, 4).ToString());

            AssignCookiesDemo test86 = new AssignCookiesDemo();
            Console.WriteLine(test86.FindContentChildren(new int[]{1,2,3}, new int[]{1,1}));
        }
    }
}
