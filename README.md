# Algorithm Practice

Solutions to small algorithm exercises from [Codewars](https://www.codewars.com) and
[LeetCode](https://leetcode.com), written in C# with a test for each one. .NET 10, xUnit.

The point is the practice, not the shortest answer: some solutions avoid the obvious built-in on purpose
(each says so in a comment), to work the problem out by hand.

---

## Exercises

| Exercise | Source | Solution | Tests |
|---|---|---|---|
| Best travel | [Codewars](https://www.codewars.com/kata/55e7280b40e1c4a06d0000aa) | [`BestTravel.cs`](ArturRios.AlgorithmPractice/BestTravel.cs) | [`BestTravelTests.cs`](ArturRios.AlgorithmPractice.Tests/BestTravelTests.cs) |
| Median of two sorted arrays | [LeetCode](https://leetcode.com/problems/median-of-two-sorted-arrays/) | [`MediumOfTwoSortedArrays.cs`](ArturRios.AlgorithmPractice/MediumOfTwoSortedArrays.cs) | [`MediumOfTwoSortedArraysTests.cs`](ArturRios.AlgorithmPractice.Tests/MediumOfTwoSortedArraysTests.cs) |
| Multiples of 3 or 5 | [Codewars](https://www.codewars.com/kata/514b92a657cdc65150000006/) | [`MultiplesOfThreeOrFive.cs`](ArturRios.AlgorithmPractice/MultiplesOfThreeOrFive.cs) | [`MultiplesOfThreeOrFiveTests.cs`](ArturRios.AlgorithmPractice.Tests/MultiplesOfThreeOrFiveTests.cs) |
| String ends with? | [Codewars](https://www.codewars.com/kata/51f2d1cafc9c0f745c00037d) | [`StringEndsWith.cs`](ArturRios.AlgorithmPractice/StringEndsWith.cs) | [`StringEndsWithTests.cs`](ArturRios.AlgorithmPractice.Tests/StringEndsWithTests.cs) |
| Valid braces | [Codewars](https://www.codewars.com/kata/5277c8a221e209d3f6000b56) | [`ValidBraces.cs`](ArturRios.AlgorithmPractice/ValidBraces.cs) | [`ValidBracesTests.cs`](ArturRios.AlgorithmPractice.Tests/ValidBracesTests.cs) |

Each solution is a static class with one public `Solution` method, so a test reads the same way the
exercise is stated:

```csharp
MultiplesOfThreeOrFive.Solution(10); // 23: 3 + 5 + 6 + 9
```

Notes on the choices made:

- **Best travel** finds the best sum of `k` distances not over `t` without LINQ or recursion: it walks
  every combination of `k` indexes in order, the way an odometer turns over.
- **String ends with?** doesn't use `string.EndsWith`; it compares the tail of the string instead.

---

## Running the tests

You need the [.NET 10 SDK](https://dotnet.microsoft.com/download).

```bash
dotnet test ArturRios.AlgorithmPractice.sln
```

One exercise's tests only:

```bash
dotnet test ArturRios.AlgorithmPractice.sln --filter "FullyQualifiedName~ValidBraces"
```

---

## Project layout

```
ArturRios.AlgorithmPractice/          one file per exercise
ArturRios.AlgorithmPractice.Tests/    one xUnit test class per exercise
ArturRios.AlgorithmPractice.sln
```

---

## Adding an exercise

1. Add `ArturRios.AlgorithmPractice/<Name>.cs`: a static class with a `Solution` method, and a comment
   with the exercise's link (and any rule you set yourself, such as "no LINQ").
2. Add `ArturRios.AlgorithmPractice.Tests/<Name>Tests.cs` with the exercise's examples as test cases.
3. Add a row to the table above.

---

## License

[Artur Rios Attribution License](LICENSE) © 2026 Artur Rios.
