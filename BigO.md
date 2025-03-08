# Big O Notation

An estimation, the order of approximation (Ordnung).

The language used to talk about how long an algorithm take to run. Allows comparison of algorithms regardless of computer differences.

## O(n)

As the number of inputs increases, the number of operations increases linearly, exact as much as the number of elements in the input.
E.g.
- 1 element == 1 operation
- 10 elements = 10 oprations

# Rules
1. Worst case. Even if the function with example input exits before interating all inputs, the Big O notation will be taken for the worst case, e.g. if all elements require interating.
2. Remove constants. Anywhere that we have O(1), e.g. the function in detail would be O(1 + n/2 + 100), removing the constants = O(n).
3. Different terms for inputs. Where a function has more than 1 input parameter, e.g. 2 arrays as parameters. It is not O(n), each input has a term: O(a + b). A function with nested loops, e.g. 2 nested loops, is O(n * n) or O(n^2) O of n squared. Also called Quadratic time. If you have more than 1 input parameters AND nested loops, the Big O would use multiplication instead of addition, e.g. O(a * b) instead of O(a + b).
4. Drop Non Dominants. A function with a loop, and a separate nested loop would be O(n + n^2). The n is dropped, just O(n^2) is left, as it is the dominant term.


O(n!) - this is Factorial time, a nested loop for every input. Probably will not see it.

# Pillars of code
1. Readable
2. Speed - time complexity
3. Memory - space complexity

# Space complexity
Have to consider the Stack (functions/values/references) and the Heap (objects, etc).
What causes Space Complexity?
- Varibles
- Data structures
- Function Calls
- Allocations


